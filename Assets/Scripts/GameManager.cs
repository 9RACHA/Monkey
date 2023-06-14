using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Programa principal que ejecuta varias instrucciones en las que jugamos con los
objetos de las clases que hemos definido.
Para poder ejecutar el código dentro de Unity debemos crear una clase que descienda
de MonoBehaviour.
*/
public class GameManager : MonoBehaviour {
    // Creamos dos variables del tipo AnimalGranja
    //(es más correcto decir que son dos propiedades de la clase GameManager,
    //pero nuestra intención es simplemente disponer de esas variables)
    AnimalGranja vaca;
    AnimalGranja oveja;
 

    //Creamos otra variable, esta vez del tipo AveCorral, que es una clase
    //que hereda de AnimalGranja
    AveCorral gallina;

    // Start is called before the first frame update
    void Start() {
        //Creamos un objeto de la clase AnimalGranja y guardamos su referencia en vaca
        vaca = new AnimalGranja(1, "vaca", "Muuuuu", 4, 0);
        //Mostramos por consola las cadenas que genera el objeto llamando a sus métodos
        Debug.Log(vaca.Info());
        Debug.Log(vaca.Vocear());
        Debug.Log(vaca.Patear());


        //Creamos un objeto de la clase AnimalGranja y guardamos su referencia en oveja
        oveja = new AnimalGranja(2, "oveja", "Beeeee", 4, 0, false);
        //Mostramos por consola las cadenas que genera el objeto llamando a sus métodos
        Debug.Log(oveja.Info());
        Debug.Log(oveja.Vocear());
        Debug.Log(oveja.Patear());

        //Creamos un objeto de la clase AveCorral y guardamos su referencia en gallina
        gallina = new AveCorral(11, "Gallina", "Cocorocó");
        Debug.Log(gallina.Info());
        Debug.Log(gallina.Vocear());
        Debug.Log(((AnimalGranja)gallina).Patear());
        
    }

    //El método OnGUI() es llamado por Unity para generar objetos de interfaz de usuario.
    //Esta técnica es conocida como IMGUI (Inmediate Mode GUI) y es la primera que estuvo
    //disponible en Unity. Hoy se suele usar otra técnica más flexible, que veremos más
    //adelante en el curso, por lo que usar IMGUI está un tanto pasado de moda,
    //pero su sencillez la hace útil para ayudar en el aprendizaje y como ayuda en el debug.
    void OnGUI() {
        //Mostramos en la pantalla de juego los mensajes generados por los animales de los que disponemos
        //esencialmente, es lo mismo que mostramos por consola, pero más cómodo para leer.
        ExpresateAnimalGranja(0, vaca);
        ExpresateAnimalGranja(4, oveja);

        ExpresateAnimalGranja(8, gallina);
        ExpresateAveCorral(8, gallina);

    }

    //Método que genera todas los mensajes del animal, mostrando cada uno de ellos en una etiqueta del GUI.
    void ExpresateAnimalGranja(int row, AnimalGranja animalGranja) {
        ShowLabel(row, 0, animalGranja.Info());
        ShowLabel(row+1, 0, animalGranja.Vocear());
        ShowLabel(row+2, 0, animalGranja.Patear());
    }

    //Método que genera todas los mensajes para las aves de corral
    void ExpresateAveCorral(int row, AveCorral aveCorral) {
        ShowLabel(row, 1, aveCorral.Info());
        ShowLabel(row+1, 1, aveCorral.Vocear());
        ShowLabel(row+2, 1, aveCorral.Patear());
    }

    //Método que genera una etiqueta con un texto, con un tamaño fijo, situándola verticalmente
    //según un parámetro que indica que linea le corresponde.
    void ShowLabel(int row, int column, string text) {
        GUI.Label(new Rect(10 + column*210, 10 + row*25, 200, 25), text);
    }
    
}
