# Unity for Reinforcement Learning Agents

## Dependencies
* Download and install [Unity](https://unity3d.com/get-unity/download)
* Install [Tensorflow](https://www.tensorflow.org/install/)
* Install [gym_unity](https://github.com/Unity-Technologies/ml-agents/blob/master/gym-unity/README.md)
* Unity TensorFlow Plugin (for internal agent) ([Download here](https://github.com/Unity-Technologies/ml-agents/blob/master/docs/Using-TensorFlow-Sharp-in-Unity.md))

## Create a new Environment for an External Agent

1. Create an environment for your agents to live in. An environment can range from a simple physical simulation containing a few objects to an entire game or ecosystem.
2. Implement an Academy subclass and add it to a GameObject in the Unity scene containing the environment. Your Academy class can implement a few optional methods to update the scene independently of any agents. For example, you can add, move, or delete agents and other entities in the environment.
3. Create one or more Brain assets by clicking Assets > Create > ML-Agents > Brain, and naming them appropriately.
4. Implement your Agent subclasses. An Agent subclass defines the code an Agent uses to observe its environment, to carry out assigned actions, and to calculate the rewards used for reinforcement training. You can also implement optional methods to reset the Agent when it has finished or failed its task.
5. Add your Agent subclasses to appropriate GameObjects, typically, the object in the scene that represents the Agent in the simulation. Each Agent object must be assigned a Brain object.
6. If training, check the Control checkbox in the BroadcastHub of the Academy. run the training process.

Reference: https://github.com/Unity-Technologies/ml-agents/blob/master/docs/Learning-Environment-Create-New.md

## Information
### Unity Machine Learning Agents (Beta)
* Website: [Unity - Machine learning](https://unity3d.com/machine-learning)
* Docs: [ML-agents](https://github.com/Unity-Technologies/ml-agents/tree/master/docs)
* Repo: [Unity-Technologies/ml-agents](https://github.com/Unity-Technologies/ml-agents)
* Blog: [Machine Learning](https://blogs.unity3d.com/category/machine-learning/)
* Gym Wrapper: [Unity ML-Agents Gym Wrapper](https://github.com/Unity-Technologies/ml-agents/blob/master/gym-unity/README.md)

### Unity tutorial
* 3D Tutorial: [Roll-a-ball](https://unity3d.com/learn/tutorials/s/roll-ball-tutorial)
* 2D Tutorial: [Roguelike](https://unity3d.com/learn/tutorials/s/2d-roguelike-tutorial)

## Examples
####  Dungeon - Multi Armed Bandit
* Blog Post: [Unity AI-themed Blog Entries](https://blogs.unity3d.com/2017/06/26/unity-ai-themed-blog-entries/)
* Repo: [Unity-Technologies/BanditDungeon](https://github.com/Unity-Technologies/BanditDungeon)

#### Grid World - Q Learning (Internal Agent)

* Blog Post: [Unity AI – Reinforcement Learning with Q-Learning](https://blogs.unity3d.com/2017/08/22/unity-ai-reinforcement-learning-with-q-learning/)
* Repo: [Unity-Technologies/Q-GridWorld](https://github.com/Unity-Technologies/Q-GridWorld)
* WebGL version: http://awjuliani.github.io/GridGL/

#### 3D Balance Ball
* Docs: [Getting-Started-with-Balance-Ball](https://github.com/Unity-Technologies/ml-agents/blob/master/docs/Getting-Started-with-Balance-Ball.md)


