郑群 23122932 SHU-人工智能微专业《具身智能前沿》微专业课程期末设计——基于[Gewu](https://github.com/loongOpen/Unity-RL-Playground)平台，设计具身智能小游戏：  

> 主要参考：
> 1. [Gewu-Playground](https://github.com/loongOpen/Unity-RL-Playground/tree/main/gewu/Assets/Playground)的总动员例程（主要参考`RobotRLAgent.cs`）  
> 2. [1] G. Margolis, _Walk These Ways: Tuning Robot Control for Generalization with Multiplicity of Behavior_, arXiv:2212.03238, 2022. [Walk These Ways](https://gmargo11.github.io/walk-these-ways/)

#### 1.1 游戏设计初衷

> 将基于RL训练的具身智能模型作为游戏NPC，在不断优化迭代玩家性能和具身智能模型性能的 **“对抗过程”** 中，即能增加了**游戏的趣味性**（物理交互的真实感以及不可预测性）；也能为**具身智能算法迭代**提供了很好的环境

#### 1.2 《人机追逐对抗》 (解谜/恐怖类游戏) 核心玩法设计

- 玩家是一个人类，被一群灵活的机器人追杀。（后续添加：解谜玩法；玩家&NPC技能设计）
- 后续设计由三个方向循环进行。但以 **“训练行动干脆，动作流畅，能够灵活应对玩家给的debuff的具身智能模型”** 为主
	1. **NPC-RL-具身智能OpenLoong模型**。能力：灵活越障；自主起身；可以控制速度；可以控制方向等等；
	2. **环境**。恐怖氛围设计；音效设计；障碍物设计等等；
	3. **玩家**。玩家技能设计等等。

### 更新日志（持续更新中）

> 由于我对控制算法更感兴趣，就先从设计基于OpenLoong大体型机器人NPC入手；后续关于环境-玩家的优化有时间或有好的idea的时候再更新

- 2026.1.1 **《人机追逐对抗 0.0》** 
	- **主要更新：**
		- **NPC-OpenLoong**：**实现双足机器人“连续步态切换”的能力，并可以通过控制步态超参数自由控制机器人的行走速度** [Doing]
		- **环境设计**：简单设计一个长廊 [ToDo]
		- **玩家设计**：简单设计一个可以”wasd方向控制+space跳跃+鼠标视角变化“人偶（不需要刻画细节）；摄像头装在人身上 [ToDo]
	- **技术报告**（“连续步态切换”能力-RL训练）
		1.  [Baseline架构解析](《人机追逐对抗%200.0》/report/Baseline架构解析.pdf): [Gewu-Playground](https://github.com/loongOpen/Unity-RL-Playground/tree/main/gewu/Assets/Playground)中`RobotRLAgent.cs`的架构解析（**已经可以实现双足机器人walk&run，但不能平滑过渡**）
		2.  [技术报告_Continuous Gait Transition (RL)](《人机追逐对抗%200.0》/report/技术报告_Continuous%20Gait%20Transition%20(RL).pdf):    **实现双足机器人“连续步态切换”的能力，并可以通过控制步态超参数自由控制机器人的行走速度**
		3.  [郑群23122932_汇报.pdf](《人机追逐对抗%200.0》/report/郑群23122932_汇报.pdf):   课程汇报PPT
	- **results**：[video_fixbody测试](《人机追逐对抗%200.0》/results/videos/z0.0_fixbody测试.mp4)   [video_Gait监控](《人机追逐对抗%200.0》/results/videos/z0.0_Gait监控.mp4)   [reward监控](《人机追逐对抗%200.0》/results/reward/z0.0_reward记录.md)  

- [ToDo] **《人机追逐对抗 1.0》** ideas
	- **NPC-OpenLoong-RL**：
		- **优化RL架构，使OpenLoong能够适应复杂多变环境（越障，不同步态行走）**。可以参考 **《Walk These Ways: Tuning Robot Control for Generalization with Multiplicity of Behavior》**。
			- 例如“以 1m/s 的速度前进”的任务。这个任务其实有无数种解法（可以趴着走、跳着走、高抬腿走、小碎步走）。而传统的 RL 通常只会收敛到**某一种**特定的步态（例如：最省力的那种）。作者不希望网络只学其中一种，而是通过**条件化（Conditioning）** 让网络学会**所有**可能的走法，并将选择权交给用户（或上层控制器）。
			- **Multiplicity of Behavior (MoB)**
			- 核心是将task解耦。分为底层策略（RL网络）和上层决策（人的指令或上层算法）
			- 设计一个**行为参数向量 $b_t$**  (包含：1. 步态时序 $(\theta_1, \theta_2, \theta_3)$：控制是 Trot（小跑）、Pace（侧对步）、Bound（跳跃）还是 Pronk（四脚跳）。  2. 频率 $(f)$：脚落地的快慢（Hz）。  3. 身体高度 $(h_z)$：底盘离地多高。  4. 抬腿高度 $(h_{fz})$：每一步脚抬多高。  5. 站立宽度 $(s_y)$：两脚分开多宽。  6. 俯仰角 $(\phi)$：身体前倾还是后仰。) ，作为 **Policy Input** 的一部分（Policy Input= $状态 o_t​,速度指令 c_t​,行为参数 b_t​$ ）
			- **只在平地上训练** (Flat Ground Only)。1. 在**训练时，随机采样各种 $b_t$ 组合**。  2. 利用 **Augmented Auxiliary Rewards（增强辅助奖励）强迫机器人**必须按照 $b_t$ 指定的姿态走路（比如：虽然平地上没必要高抬腿，但如果 $b_t$ 要求高抬腿，做不到就扣分）。  
		- 训练一个**自主起身网络**；当判断机器人摔倒时调用，因为摔倒时速度为0，其他动力学参数也都不变，因此，不会出现行为切换/神经网络切换时的冲突问题，可以单独训练一个神经网络。
		- **添加上肢/全身关节动作**
		- **优化RL神经网络输入**（`CollectObservations` 模块添加 `vr/wr/cr` 输入），实现能够通过  `vr/wr/cr` 控制OpenLoong
	- **NPC-OpenLoong-大脑**：
		- **自主寻路**。写一个简单的脚本，根据 NavMesh 计算路径，然后算出 vr/wr 给机器人，让它自动追玩家。  
	- **玩家强化**：
		- 技能设计，考验机器人NPC的RL能力训练。例如：“玩家技能-投放障碍物道具”
	- **环境强化**：
		- 布局优化，考验机器人NPC的RL能力训练。例如：老建筑内；有破坏的墙角可以爬出去，有的房间有不止一个出口；有点房间单出口，但是较大且障碍物多
		- 氛围优化：灯光调暗；给机器人加两只发红光的眼睛；走路音效（包含远近）



