# Creación de agentes inteligentes en videojuegos con Deep Q-Learning utilizando Unity y ML-Agents.
---

## 1. Introducción.
Aprender interactuando con el entorno es probablemente lo primero que se nos viene a la mente cuando pensamos acerca de la naturaleza del aprendizaje. Por ejemplo, los niños tienden a tener comportamientos erráticos que van desapareciendo a medida que crecen, pero son por medio de estos que los niños interactuan con el entorno, aprenden que comportamiento puede ser beneficioso, acerca de las consecuencias de las acciones y que deben hacer para conseguir ciertas metas. Este paradigma en *Machine Learning* es conocido como aprendizaje por refuerzo (*Reinforcement Learning* o *RL*) y es el tema central de este trabajo, en el que utilizaremos un motor de videojuegos para crear una IA que aprenda por medio de algoritmos de *Reinforcement Learning* a moverse en un circuito de carrera.

##### ¿Qué vamos a hacer?
Como el título sugiere, vamos a utilizar Unity y ML-Agents para crear una IA de videojuegos, inspirados en los juegos de carreras 3D, decidimos que el objetivo de este proyecto es crear una IA que pueda manejar por un circuito de carreras sin ser explicitamente programada para ello, solo se programaran sus acciones y recompensas. Por ejemplo, seguir en el camino aumentará las recompensas obtenidas, mientras que salir del circuito terminará inmediatamente con la simulación, pero es la IA quien tendrá que descubrir esto.

Entraremos en más detalles en las siguientes secciones.

##### Tecnologías utilizadas
| Tecnología         | Versión         |
|--------------------|-----------------|
| Unity              | 2019.3.1f1      |
| ML-Agents (Plugin) | 1.9.1 (Preview) |
| ml-agents (python) | 0.25.1          |
| ml-agents-envs     | 0.25.1          |
| Python             | 3.9             |
| Pytorch            | 1.8.1 + CPU     |

##### Equipo
1. Aguilera Luzania José Luis.
2. Baez Camacho Jesús Armando.
3. Castro Marquez Francisco Javier.

---
# Contenido de nuestro proyecto
Puedes encontrar un pdf con toda la información aquí: ![PDF](https://github.com/jabc300/Deep-Q-Learning-with-Unity-and-Pytorch/blob/main/Contenido%20del%20proyecto.pdf)

Puedes encontrar la libreta de jupyter con toda la información aquí: [Libreta](https://github.com/jabc300/Deep-Q-Learning-with-Unity-and-Pytorch/tree/main/Jupyter-NoteBook)


### 1. Introducción
 - ¿Qué es Reinforcement Lerning? y ¿Porqué usarlo?
 - ¿Qué es Deep Q-Learning?
 - ¿Qué es Unity?
 - ¿Qué es ML-Agents?
 - ¿Qué vamos a hacer?
 - Tecnologías utilizadas.
 - Equipo.
 - Indice.

### 2. Primeros pasos con Unity
- Assets utilizados.
- Plugins utilizados de Unity.
- Estructura del proyecto en Unity.
- Estructura del environment.
	- Componentes.
- Estructura del Agente.
	- Componentes.
	- Comportamiento.

### 3. Dependencias de Python
- Librerias a utilizar.
- Importar las librerías.

### 4. Primeros pasos con ML-Agents
- ¿Cómo conectar ML-Agents con Unity a través de Python?
- ¿Cómo obtener información de los Agentes?
- La primera observación visual del Agente.
- Probar el seguimiento de un Agente.

### 5. Definiciones de VisualQNetwork, Experiencia y Entrenamiento.
- Definición de la clase ```VisualQNetwork```.
	- Definición y explicación.
- Definición de la clase ``Experience``.
	- Definición y explicación.
- Definición de la clase ``Trainer``.
	- Definición y explicación.

### 6. Entrenamiento.
- Código en Python del entrenamiento.

### Referencias.
1. Technologies, U. (2020, 5 junio). Unity - Manual: Unity User Manual (2019.3). Unity 2019 - Documentation. https://docs.unity3d.com/2019.3/Documentation/Manual/index.html
2. U. (2020). Unity-Technologies/ml-agents. GitHub ML-Agents Toolkit. https://github.com/Unity-Technologies/ml-agents
3. U. (2020). Unity-Technologies/ml-agents. GitHub ML-Agents Python API. https://github.com/Unity-Technologies/ml-agents/blob/main/docs/Python-API-Documentation.md
4. Juliani, A., Berges, V., Teng, E., Cohen, A., Harper, J., Elion, C., Goy, C., Gao, Y., Henry, H., Mattar, M., Lange, D. (2020). Unity: A General Platform for Intelligent Agents. arXiv preprint arXiv:1809.02627. https://github.com/Unity-Technologies/ml-agents.
5. Kenney • Racing Kit. (2010). Kenney Racing Kit. https://www.kenney.nl/assets/racing-kit
6. Reinforcement Learning Series Intro - Syllabus Overview. (2018). Deeplizard. https://deeplizard.com/learn/video/nyjbcRQ-uQ8
7. Sutton, R. S., & Barto, A. G. (2018). Reinforcement Learning, Second Edition: An Introduction (2nd ed.) [Libro electrónico]. Bradford Book. http://incompleteideas.net/book/RLbook2020.pdf
