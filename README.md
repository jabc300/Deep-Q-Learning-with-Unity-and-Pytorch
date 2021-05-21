# Creación de agentes inteligentes en videojuegos con Deep Q-Learning utilizando Unity y ML-Agents.
### Introducción
**Unity** fue diseñado como un motor de juegos, es decir, un software especializado en la creación de videojuegos, pero con el tiempo Unity se fue actualizando y actualmente es el segundo motor de juegos más utilizado solo superado por el UnrealEngine de EpicGames. Sin embargo el objetivo inicial de ser un motor de videojuegos a cambiado bastante hasta convertirse más en un entorno de simulación.

Unity tiene características que le permiten resaltar sobre los demás como un motor de físicas avanzado, capacidad para manejar gráficos en 2D y 3D, compatibilidad con la mayoría de plataformas tecnológicas que van desde sistemas de dispositivos mobiles (Android, IOS), hasta dispositivos de realidad aumentada y realidad virtual (Oculus Rift, Microsoft HoloLens, etc.), en total es compatible con 25 plataformas. También cuenta con una interfaz sencilla de utilizar y el lenguaje de programación principal es C# aunque recientemente liberaron una forma de programación visual para usuarios menos experimentados y la capacidad de usar Python.

**The Unity Machine Learning Agents Toolkit** (ML-Agents) es un proyecto open-source que le permite a juegos y simulaciones dentro de Unity servir como environments para el entrenamiento de agentes inteligentes. ML-Agents permite a los desarrolladores utilizar los últimos algoritmos (basados en Pytorch) para el entrenamiento de agentes inteligentes, para 2D, 3D y VR/AR. 

ML-Agents también cuenta con una API de Python para que los investigadores puedan usar Reinforcement Learning, Imitation Learning, Neuroevolution o cualquier otro método que quieran. Esto es beneficioso tanto para los desarrolladores de juegos que pueden crear mejor IA de una manera más sencilla, así como para los investigadores que tienen en sus manos un motor de simulación bastante avanzado y genérico.

### Objetivo
En este proyecto se revisará como conectar Python y Unity para entrenar a una agente cuya tarea será moverse a través de un circuito de carreras como lo haría una IA de un juego real mediante Deep Q-Learning mostrando el potencial de crear agentes inteligentes que puedan competir con jugadores en entornos de simulación 3D.

### Tecnologías
| Tecnología         | Versión         |
|--------------------|-----------------|
| Unity              | 2019.3.1f1      |
| ML-Agents (Plugin) | 1.9.1 (Preview) |
| ml-agents (python) | 0.25.1          |
| ml-agents-envs     | 0.25.1          |
| Python             | 3.9             |
| Pytorch            | 1.8.1 + CPU     |

### Equipo
1. Aguilera Luzania José Luis.
2. Baez Camacho Jesús Armando.
3. Castro Marquez Francisco Javier.
