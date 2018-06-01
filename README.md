# Unity for Reinforcement Learning Agents

## Installation
* [Tensorflow Installation](https://www.tensorflow.org/install/)
* Download and install Unity if you don't already have it.
* Unity TensorFlow Plugin ([Download here](https://github.com/Unity-Technologies/ml-agents/blob/master/docs/Using-TensorFlow-Sharp-in-Unity.md))

## Create a new Environment for an External Agent

1. Create new Unity project.
2. Import ML Agent Repo into project.
3. Create an Unity scene for the agent.
4. Implement an Academy subclass and add it to a GameObject in the Unity scene. This GameObject will serve as the parent for any Brain objects in the scene.
5. Add a Brain object to the scene as children of the Academy.
6. Implement an Agent subclasses. An Agent subclass defines the code an agent uses to observe its environment, to carry out assigned actions, and to calculate the rewards used for reinforcement training. You can also implement optional methods to reset the agent when it has finished or failed its task.
7. Add your Agent subclasses to appropriate GameObjects, typically, the object in the scene that represents the agent in the simulation. Set the Brain type to External and run the training process.

Reference: https://github.com/Unity-Technologies/ml-agents/blob/master/docs/Learning-Environment-Create-New.md

## Information
### Unity Machine Learning Agents (Beta)
* Website: https://unity3d.com/machine-learning
* Docs: [Unity-Technologies/ml-agents](https://github.com/Unity-Technologies/ml-agents/tree/master/docs)
* Repo: [Unity-Technologies/ml-agents](https://github.com/Unity-Technologies/ml-agents)
* Blog: [Machine Learning](https://blogs.unity3d.com/category/machine-learning/)

### Examples
####  Multi Armed Bandit
* Blog Post: [Unity AI-themed Blog Entries](https://blogs.unity3d.com/2017/06/26/unity-ai-themed-blog-entries/)
* Repo: [Unity-Technologies/BanditDungeon](https://github.com/Unity-Technologies/BanditDungeon)

#### Q Learning - Grid World
Using Internal Agent ****
* Blog Post: [Unity AI – Reinforcement Learning with Q-Learning](https://blogs.unity3d.com/2017/08/22/unity-ai-reinforcement-learning-with-q-learning/)
* Repo: [Unity-Technologies/Q-GridWorld](https://github.com/Unity-Technologies/Q-GridWorld)
* WebGL version: http://awjuliani.github.io/GridGL/

