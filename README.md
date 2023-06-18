# Monkey

## Array, For, Equals, Invoke:

### Array:
Es una estructura de datos que permite almacenar una colección de elementos del mismo tipo en una secuencia contigua en memoria. Puedes acceder a los elementos del array utilizando un índice numérico.Tienen un tamaño fijo una vez que se crean, por lo que no puedes agregar o eliminar elementos una vez definido el tamaño inicial.

### For:
Es una estructura de control que permite repetir un bloque de código un número específico de veces. Se compone de tres partes principales: la inicialización, la condición de continuación y la actualización. Es útil cuando sabes de antemano la cantidad exacta de veces que deseas repetir una determinada acción.

### Equals
Es un método en C# que se utiliza para comparar si dos objetos son iguales en cuanto a su contenido. Puede ser sobrescrito por las clases derivadas para proporcionar una implementación personalizada de la comparación de igualdad.

### Invoke:
Se utiliza para invocar (llamar) a un método o delegado en tiempo de ejecución. Puedes usarlo para llamar a un método de manera dinámica, especialmente cuando no conoces el método en tiempo de compilación o cuando deseas ejecutar un método de forma genérica. 

------

Realizar un programa en Unity que reproduzca el mítico duelo de insultos de Monkey Island. El
programa no utilizará elementos gráficos de Unity, tan sólo la entrada y salida de texto, tanto por
consola como en el interfaz de usuario mediante la utilización de Immediate Mode GUI (IMGUI) y
la función OnGUI().

El programa dispondrá en sendos arrays de los retos que podrá lanzar al jugador y las posibles
respuestas. La respuesta “correcta” que permite vencer al insulto de la posición i del array de
insultos será la que ocupe la posición i en el array de respuestas.

En cada envite, el programa seleccionará al azar un insulto de entre los que dispone y se lo
presentará al usuario, imprimiéndolo por consola y en el GUI, en la parte izquierda de la pantalla,
debiendo cada sucesivo insulto aparecer bajo el anterior.

También se mostrarán en la parte derecha las posibles respuestas, identificada cada una de ellas por
una letra de la A a la P.

El usuario podrá entonces teclear la letra correspondiente a la respuesta que quiera dar.

El programa mostrará si la respuesta es correcta o no y el balance de envites ganados y perdidos por
el usuario. Esto último se mostrará en una etiqueta en la parte central superior en la que se indicará
el tanteo como si fuera un partido de fútbol, por ejemplo Jugador 1 – Ordenador 2. El programa
terminará cuando se alcancen 3 envites ganados o perdidos.
