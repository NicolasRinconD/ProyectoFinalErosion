# Erosion - Computación Visual
Proyecto Final
Integrantes:

- Nicolás Rincón 
- Nicolás Díaz

Para correr este proyecto se necesita el engine de unity: https://unity3d.com/

Instrucciones:
1. Abrir la carpeta raiz en unity (Preferiblemente la versión 2020.3.8).
2. Ir a File -> Open Scene y escoger en la carpeta `Scenes` el archivo `Small Terrain`.
3. Presionar play y entrar a la pestaña de juego.

Alternativamente después de escoger la escena se puede ir a File -> Build and Run, y al guardarla en una carpeta afuera del proyecto el engine creara y ejecutara la escena automáticamente.

---
## Descripción del Proyecto

La generación de terreno por procedimientos abarca un amplio rango de técnicas, con el objetivo de crear de manera eficiente un entorno simulado realista. Algunas de las aplicaciones más famosas de la generación de terrenos procedimentales se encuetran en Minecraft, que genera biomas de forma procedimental, y No Man's Sky, que utiliza técnicas procedimentales para generar planetas y sistemas únicos.

Si bien los videojuegos son la aplicación más conocida de generación de terrenos procedimentales, no son la única aplicación. OpenAI ha demostrado la utilidad de entrenar robots en una simulación antes de implementarlos en el mundo real, utilizando el aprendizaje por refuerzo profundo. Hasta ahora, la atención se ha centrado principalmente en enseñar a los manipuladores robóticos tareas complejas, pero los mismos algoritmos también podrían usarse para entrenar automóviles autónomos y otras formas de robots móviles. El desafío con este enfoque es se quiere construir cientos de kilómetros de carreteras fotorrealistas para que los autos conduzcan. Se va a demostrar en lo siguiente como, a través de heightmaps personalizables y una simulación de erosión se puede lograr una aproximación de este tipo de terreno.

![a2](https://user-images.githubusercontent.com/44012421/120425405-be657280-c333-11eb-8716-947097aa52a0.PNG)
![a1](https://user-images.githubusercontent.com/44012421/120425409-c2919000-c333-11eb-80c1-c7e374392649.PNG)
