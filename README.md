郑群 23122932 SHU-人工智能微专业《具身智能前沿》微专业课程期末设计——基于[Gewu](https://github.com/loongOpen/Unity-RL-Playground)平台，设计具身智能小游戏：  

> 主要参考：
> 1. [Gewu-Playground](https://github.com/loongOpen/Unity-RL-Playground/tree/main/gewu/Assets/Playground)的总动员例程（主要参考`RobotRLAgent.cs`）  

#### 1.1 游戏设计初衷

> 将基于RL训练的具身智能模型作为游戏NPC，在不断优化迭代玩家性能和具身智能模型性能的 **“对抗过程”** 中，即能增加了**游戏的趣味性**（物理交互的真实感以及不可预测性）；也能为**具身智能算法迭代**提供了很好的环境

#### 1.2 《人机追逐对抗》 (解谜/恐怖类) 游戏设计初步想法

**核心玩法：**
- 玩家是一个人类，被一群“走路姿势诡异”的机器人追杀。   

### 更新日志（持续更新中）

> 由于我对控制算法更感兴趣，就先从设计基于OpenLoong大体型机器人NPC入手；后续关于环境-玩家的优化有时间或有好的idea的时候再更新

- 2026.1.1 **《人机追逐对抗 0.0》** 
	- **NPC-OpenLoong大体型机器人-基础能力**：**实现双足机器人从“离散步态切换”到“连续步态切换”的能力，并可以自由控制机器人的行走速度**
	- **环境设计**：简单设计一个长廊
	- **玩家设计**：简单设计一个可以”wasd方向控制+space跳跃+鼠标视角变化“人偶（不需要刻画细节）；摄像头装在人身上
	- **技术报告**（“连续步态切换”能力-RL训练）
		1.  [Baseline架构解析](《人机追逐对抗%200.0》/report/Baseline架构解析.pdf): [Gewu-Playground](https://github.com/loongOpen/Unity-RL-Playground/tree/main/gewu/Assets/Playground)中`RobotRLAgent.cs`的架构解析
		2.  [技术报告_Continuous Gait Transition (RL)](《人机追逐对抗%200.0》/report/技术报告_Continuous%20Gait%20Transition%20(RL).pdf):    **RL实现双足机器人Openloong从“离散步态切换”到“连续步态切换”的能力**
		3.  [郑群23122932_汇报.pdf](《人机追逐对抗%200.0》/report/郑群23122932_汇报.pdf):   课程汇报PPT
	- **results**：[video_fixbody测试](《人机追逐对抗%200.0》/results/videos/z0.0_fixbody测试.mp4)   [video_Gait监控](《人机追逐对抗%200.0》/results/videos/z0.0_Gait监控.mp4)   [reward监控](《人机追逐对抗%200.0》/results/reward/z0.0_reward记录.md)  


- [ToDo] **《人机追逐对抗 1.0》** 计划
	- **RL-NPC技能强化**：训练一个**自主起身网络**；**添加上肢/全身关节动作**；**优化RL神经网络输入**（`CollectObservations` 模块添加 `vr/wr/cr` 输入），实现能够通过  `vr/wr/cr` 控制OpenLoong
	- **NPC技能强化**：**自主寻路**。写一个简单的脚本，根据 NavMesh 计算路径，然后算出 vr/wr 给机器人，让它自动追玩家。  
	- **玩家强化**：技能设计，考验机器人NPC的RL能力训练。例如：“玩家技能-投放障碍物道具”
	- **环境强化**：布局优化，考验机器人NPC的RL能力训练。例如：老建筑内；有破坏的墙角可以爬出去，有的房间有不止一个出口；有点房间单出口，但是较大且障碍物多
	- **环境强化**-氛围：灯光调暗；给机器人加两只发红光的眼睛；走路音效（包含远近）