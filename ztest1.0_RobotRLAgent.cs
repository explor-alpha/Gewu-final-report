using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using Random = UnityEngine.Random;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using Unity.Sentis;

// [zq_new] 1. 定义步态参数结构 (MoB核心)
[System.Serializable]
public struct GaitParams
{
    public float T1; // 周期 (Walk~40, Run~25)
    public float dh; // 幅度 (Walk~20, Run~40)
    public float d0; // 偏置 (Walk~0, Run~20)
}

public class RobotRLAgent : Agent
{
    // [zq_new] 2. 引入MoB控制变量
    [SerializeField] private GaitParams currentGait; // 当前平滑过渡值
    public GaitParams targetGait;  // 训练目标值
    [SerializeField] private int changeGaitTimer = 0; // 训练计时器

    int tp = 0;
    int tq = 0;
    int tt = 0;
    public bool fixbody = false;
    public bool train;
    // float uff = 0;
    float uf1 = 0;
    float uf2 = 0;
    
    // 动作与控制变量
    float[] u = new float[16];
    float[] ut = new float[16];
    float[] utt = new float[16];
    float[] utotal = new float[16];
    
    // [zq_x] T1现在是动态变量，这里只保留定义
    int T1 = 40; 
    int tp0 = 0;

    // 枚举保留，用于Inspector兼容，但在MoB逻辑中不再作为切换依据
    public enum StyleB { walk = 0, run = 1, jump = 2 }
    public enum StyleQ { trot = 0, bound = 1, pronk = 2 }
    public enum StyleL { drive = 0, walk = 1, jump = 2 }
    public enum StyleR { biped = 0, quadruped = 1, legwheeled = 2 }
    
    Transform body;
    public int ObservationNum;
    public int ActionNum;
    [Header("RobotType")]
    public StyleR Robot;
    [Header("Biped")]
    public StyleB BipedTargetMotion;
    public ModelAsset Openloong;

    
    // 略去其他无关变量...
    StyleB LastBmotion;
    List<float> P0 = new List<float>();
    List<float> W0 = new List<float>();
    Vector3 pos0;
    Quaternion rot0;
    ArticulationBody[] arts = new ArticulationBody[40];
    ArticulationBody[] acts = new ArticulationBody[16];

    // PD参数
    float[] kb = new float[16] { 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30 };
    float[] kb1 = new float[16]; // 默认为0
    float[] kb2 = new float[16]; // 默认为0
    float dh = 25;
    float d0 = 15;
    float ko = 2;
    float kh = 0;

    public override void Initialize()
    {
        arts = this.GetComponentsInChildren<ArticulationBody>();
        ActionNum = 0;
        for (int k = 0; k < arts.Length; k++)
        {
            if(arts[k].jointType.ToString() == "RevoluteJoint")
            {
                acts[ActionNum] = arts[k];
                ActionNum++;
            }
        }
        body = arts[0].GetComponent<Transform>();
        pos0 = body.position;
        rot0 = body.rotation;
        arts[0].GetJointPositions(P0);
        arts[0].GetJointVelocities(W0);

        // [zq_new] 初始化默认步态 (新手村配置: 慢走)
        currentGait.T1 = 40;
        currentGait.dh = 10;
        currentGait.d0 = 0;
        targetGait = currentGait;
        
        Debug.Log($"Initialize: ActionNum = {ActionNum}");
    }

    private bool _isClone = false; 
    void Start()
    {
        Time.fixedDeltaTime = 0.01f;
        if (train && !_isClone) 
        {
            // [zq_new] 增加克隆数量以加速训练 (7900X 建议 20个)
            for (int i = 1; i < 20; i++) 
            {
                GameObject clone = Instantiate(gameObject); 
                clone.transform.position = transform.position + new Vector3(i * 3f, 0, 0);
                clone.name = $"{name}_Clone_{i}"; 
                clone.GetComponent<RobotRLAgent>()._isClone = true; 
            }
        }
    }

    public override void OnEpisodeBegin()
    {
        tp = 0;
        tq = 0;
        tt = 0;
        for (int i = 0; i< 16; i++) { u[i] = 0; ut[i] = 0; utt[i] = 0; }

        // [zq_new] 增加 Observation Space (2相位 + 3参数 = 5)
        // 请务必在 Unity Inspector 把 Observation Size 改为原来的 + 5
        ObservationNum = 9 + 2 * ActionNum + 5;

        if (fixbody) arts[0].immovable = true;
        if (!fixbody)
        {
            arts[0].TeleportRoot(pos0, rot0);
            arts[0].velocity = Vector3.zero;
            arts[0].angularVelocity = Vector3.zero;
            arts[0].SetJointPositions(P0);
            arts[0].SetJointVelocities(W0);
        }

        // [zq_new] 每次重置时随机化目标 (课程学习入口)
        if (train) RandomizeGaitCommand_Smoothed();
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(body.InverseTransformDirection(Vector3.down));
        sensor.AddObservation(body.InverseTransformDirection(arts[0].angularVelocity));
        sensor.AddObservation(body.InverseTransformDirection(arts[0].velocity));
        for (int i = 0; i < ActionNum; i++)
        {
            sensor.AddObservation(acts[i].jointPosition[0]);
            sensor.AddObservation(acts[i].jointVelocity[0]);
        }

        // [zq_new] 注入 MoB 关键观测
        // 1. 相位 (Sin/Cos)
        float phase = (float)tp / (2f * Mathf.Max(1f, currentGait.T1)); 
        sensor.AddObservation(Mathf.Sin(2 * Mathf.PI * phase));
        sensor.AddObservation(Mathf.Cos(2 * Mathf.PI * phase));

        // 2. 意图 (Command)
        sensor.AddObservation(currentGait.T1);
        sensor.AddObservation(currentGait.dh);
        sensor.AddObservation(currentGait.d0);
    }

    float EulerTrans(float eulerAngle)
    {
        if (eulerAngle <= 180) return eulerAngle;
        else return eulerAngle - 360f;
    }

    public override void OnActionReceived(ActionBuffers actionBuffers)
    {
        // 1. RL 输出处理 (低通滤波)
        for (int i = 0; i < 16; i++) utotal[i] = 0;
        var continuousActions = actionBuffers.ContinuousActions;
        var kk = 0.9f;
        
        for (int i = 0; i < ActionNum; i++)
        {
            u[i] = u[i] * kk + (1 - kk) * continuousActions[i];
            ut[i] += u[i];
            utt[i] += ut[i];
            // 基础控制量 (kb为P项，kb1/kb2为积分项)
            utotal[i] = kb[i] * u[i] + kb1[i] * ut[i] + kb2[i] * utt[i];
            if (fixbody) utotal[i] = 0;
        }

        // [zq_new] 2. 统一混合控制 (MoB Core)
        // 你的模型是12关节，idx如下
        int[] idx = new int[6] { 3, 4, 5, 9, 10, 11 };
        
        // 设置Gain (使用一套比较通用的参数)
        // 建议：如果发现RL反抗太强，可以把这些参数适当减小 (如 40->20)
        float[] ktemp1 = new float[12] { 10, 10, 45, 20, 40, 10, 10, 10, 40, 20, 45, 10 };
        for (int i = 0; i < 12; i++) kb[i] = ktemp1[i];

        if (Robot == StyleR.biped /*&& ActionNum == 12*/) // 确保只对双足生效
        {
            // 从动态变量获取参数
            T1 = (int)currentGait.T1; 
            dh = currentGait.dh;
            d0 = currentGait.d0;

            // 统一混合公式
            // 左腿 (uf1)
            utotal[Mathf.Abs(idx[0]) - 1] += (dh * uf1 + d0) * Mathf.Sign(idx[0]); // 髋 (注意: idx-1是因为数组从0开始)
            utotal[Mathf.Abs(idx[1]) - 1] -= 2 * (dh * uf1 + d0) * Mathf.Sign(idx[1]); // 膝
            utotal[Mathf.Abs(idx[2]) - 1] += (dh * uf1 + d0) * Mathf.Sign(idx[2]); // 踝
            
            // 右腿 (uf2)
            utotal[Mathf.Abs(idx[3]) - 1] += (dh * uf2 + d0) * Mathf.Sign(idx[3]);
            utotal[Mathf.Abs(idx[4]) - 1] -= 2 * (dh * uf2 + d0) * Mathf.Sign(idx[4]);
            utotal[Mathf.Abs(idx[5]) - 1] += (dh * uf2 + d0) * Mathf.Sign(idx[5]);

            // [zq_x] 移除 EndEpisode，允许平滑过渡
            if (!train) SetModel("gewu", Openloong);
        }

        // 执行
        for (int i = 0; i < ActionNum; i++) SetJointTargetDeg(acts[i], utotal[i]);
    }

    // ... SetJointTargetDeg 保持不变 ...
    void SetJointTargetDeg(ArticulationBody joint, float x)
    {
        var drive = joint.xDrive;
        drive.stiffness = 2000f;
        drive.damping = 100f;
        drive.forceLimit = 300f;
        drive.target = x;
        joint.xDrive = drive;
    }
    // ... SetJointTargetPosition 保持不变 ...
    void SetJointTargetPosition(ArticulationBody joint, float x)
    {
        x = (x + 1f) * 0.5f;
        var x1 = Mathf.Lerp(joint.xDrive.lowerLimit, joint.xDrive.upperLimit, x);
        var drive = joint.xDrive;
        drive.stiffness = 2000f;
        drive.damping = 100f;
        drive.forceLimit = 200f;
        drive.target = x1;
        joint.xDrive = drive;
    }

    public override void Heuristic(in ActionBuffers actionsOut)
    {
        // [zq_new] 推理模式：手动控制
        // if (!train)
        // {
        //     if (Input.GetKey(KeyCode.Space)) // 按住空格跑
        //     {
        //         targetGait.T1 = 25; targetGait.dh = 40; targetGait.d0 = 20;
        //     }
        //     else // 松开走
        //     {
        //         targetGait.T1 = 40; targetGait.dh = 10; targetGait.d0 = 0;
        //     }
        // }
    }

    void FixedUpdate()
    {
        // [zq_new] 训练模式：课程学习与域随机化
        if (train)
        {
            changeGaitTimer++;
            if (changeGaitTimer > 300) // 每3秒变一次
            {
                changeGaitTimer = 0;
                RandomizeGaitCommand_Smoothed();
            }
            // 平滑插值
            currentGait.T1 = Mathf.Lerp(currentGait.T1, targetGait.T1, 0.1f);
            currentGait.dh = Mathf.Lerp(currentGait.dh, targetGait.dh, 0.1f);
            currentGait.d0 = Mathf.Lerp(currentGait.d0, targetGait.d0, 0.1f);
        }
        // 推理模式也要平滑
        else 
        {
            changeGaitTimer++;
            // 起点：慢走
            const float startT1 = 40f;
            const float startDh = 10f;
            const float startD0 = 0f;

            // 终点：快跑
            const float endT1 = 25f;
            const float endDh = 40f;
            const float endD0 = 20f;

            // 每 ... 前进 10%
            float progress = Mathf.Clamp01(changeGaitTimer / 3000f); 

            targetGait.T1 = Mathf.Lerp(startT1, endT1, progress);
            targetGait.dh = Mathf.Lerp(startDh, endDh, progress);
            targetGait.d0 = Mathf.Lerp(startD0, endD0, progress);

            currentGait.T1 = Mathf.Lerp(currentGait.T1, targetGait.T1, 0.1f);
            currentGait.dh = Mathf.Lerp(currentGait.dh, targetGait.dh, 0.1f);
            currentGait.d0 = Mathf.Lerp(currentGait.d0, targetGait.d0, 0.1f);
        }

        tp++;
        tq++;
        tt++;
        
        // [zq_new] 使用动态 T1 计算波形
        float curT1 = currentGait.T1;
        if (tp > 0 && tp <= curT1)
        {
            tp0 = tp;
            uf1 = (-Mathf.Cos(3.14f * 2 * tp0 / curT1) + 1f) / 2f;
            uf2 = 0;
        }
        if (tp > curT1 && tp <= 2 * curT1)
        {
            tp0 = (int)(tp - curT1);
            uf1 = 0;
            uf2 = (-Mathf.Cos(3.14f * 2 * tp0 / curT1) + 1f) / 2f;
        }
        if (tp >= 2 * curT1) tp = 0;

        // Reward 计算 (保持不变，或根据需要微调)
        var vel = body.InverseTransformDirection(arts[0].velocity);
        var wel = body.InverseTransformDirection(arts[0].angularVelocity);
        var live_reward = 1f;
        var ori_reward1 = -0.1f * Mathf.Abs(EulerTrans(body.eulerAngles[0]));
        var ori_reward2 = -2f * Mathf.Abs(wel[1]);
        var ori_reward3 = -0.1f * Mathf.Min(Mathf.Abs(body.eulerAngles[2]), Mathf.Abs(body.eulerAngles[2] - 360f));
        // 鼓励向前速度
        var vel_reward2 = vel[2] - Mathf.Abs(vel[0]) + kh * Mathf.Abs(vel[1]);
        var reward = live_reward + (ori_reward1 + ori_reward2 + ori_reward3) * ko + vel_reward2;
        
        AddReward(reward);
        
        if (Mathf.Abs(EulerTrans(body.eulerAngles[0])) > 20f || Mathf.Abs(EulerTrans(body.eulerAngles[2])) > 20f ) // || tt>=1000
        {
            if(train) EndEpisode();
        }
    }

    // [zq_new] 渐进式课程学习逻辑
    void RandomizeGaitCommand_Smoothed()
    {
        int step = Academy.Instance.StepCount;
        // 计算课程进度 (0.0 到 1.0)，在 200万步时完成
        float progress = Mathf.Clamp01((float)step / 2000000f);

        // 动态范围：随着训练深入，难度逐渐加大
        float minT1 = Mathf.Lerp(38f, 24f, progress);
        float maxDh = Mathf.Lerp(14f, 41f, progress); // 从小碎步(14) 扩展到 大跨步(41)
        float maxD0 = Mathf.Lerp(5f, 20f, progress);  // 从直立(5) 扩展到 蹲姿(20)

        targetGait.T1 = Random.Range(minT1, 41f);
        targetGait.dh = Random.Range(9f, maxDh);
        targetGait.d0 = Random.Range(0f, maxD0);
    }

    // // [zq_new] 实时调试显示
    // void OnGUI()
    // {
    //     GUIStyle style = new GUIStyle();
    //     style.fontSize = 20;
    //     style.normal.textColor = Color.white;
    //     string status = $"MoB Status ({name})\n" +
    //                     $"T1: {currentGait.T1:F1} / {targetGait.T1:F1}\n" + 
    //                     $"dh: {currentGait.dh:F1} / {targetGait.dh:F1}\n" + 
    //                     $"d0: {currentGait.d0:F1} / {targetGait.d0:F1}";
    //     GUI.Label(new Rect(10, 10, 300, 200), status, style);
    // }
}