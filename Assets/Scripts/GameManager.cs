using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private int indiceInsulto;
    private int indiceRespuesta;
    private string strRespuestas;
    private string strMensajeUsuario;
    private string strGanador;

    private bool esperandoRespuesta;

    private int contadorVictorias;
    private int contadorDerrotas;

    // Start is called before the first frame update
    void Start() {
        LanzarJugada();
        
        contadorDerrotas = 0;
        contadorVictorias = 0;
        strGanador = "";
        strRespuestas = "";

        /*Repite una secuencia de instrucciones un número determinado de veces, o para recorrer una colección de elementos*/
        for(int i=0; i<respuestas.Length; i++) {    
            strRespuestas += (char)(i+'A');             
            strRespuestas += ". " + respuestas[i];
            strRespuestas += "\n";
        }
        /*for (int i = 1; i <= 5; i++){
            Console.WriteLine(i);
        }*/
    }

    // Update is called once per frame
    void Update() {               //OR
        if(contadorDerrotas == 3 || contadorVictorias == 3) {
            if(Input.GetKeyDown(KeyCode.R)) {
                LanzarJugada();
                Debug.Log("Reinicio el juego");
                contadorDerrotas = 0;
                contadorVictorias = 0;
                strGanador = "";
            } else if(strGanador.Equals("")) {
                strGanador = contadorDerrotas>contadorVictorias?"Ordenador":"Guybrush";
                Debug.Log($"Ganador: {strGanador}");
            }
            return;
        } 

        if(esperandoRespuesta) {
            string userInput = Input.inputString.ToUpper();
            if(userInput != "") {
                indiceRespuesta = userInput[0] - 'A';

                if(indiceRespuesta <0 || indiceRespuesta >= respuestas.Length) {
                    indiceRespuesta = -1;
                    strMensajeUsuario = "";
                } else if(indiceInsulto == indiceRespuesta) {
                    strMensajeUsuario = "Ganaste";
                    contadorVictorias ++;
                    Debug.Log($"Marcador {contadorVictorias} - {contadorDerrotas}");
                    esperandoRespuesta = false;
                    if(contadorVictorias < 3) {
                        Invoke("LanzarJugada", 3);
                    }
                } else {
                    strMensajeUsuario = "Perdiste";
                    contadorDerrotas++;
                    Debug.Log($"Marcador {contadorVictorias} - {contadorDerrotas}");
                    esperandoRespuesta = false;
                    if(contadorDerrotas < 3) {
                        Invoke("LanzarJugada", 3);
                    }
                }
            }
        }
        
    }
    /*Length: se utiliza para obtener la longitud o tamaño de una matriz (array), una cadena (string) o una colección*/
    void LanzarJugada() {
        indiceInsulto = Random.Range(0, insultos.Length); //Hacer un numero aleatorio entre 0 y los insultos 
        indiceRespuesta = -1;
        esperandoRespuesta = true;
        
        strMensajeUsuario = "";
    }


    void OnGUI() {
        string estrellas = " ***";
        
        GUI.Label(new Rect(10, 10, 200, 25), "Ordenador" + estrellas.Substring(0, contadorDerrotas+1));
        GUI.Label(new Rect(310, 10, 200, 25), "Guybrush" + estrellas.Substring(0, contadorVictorias+1));


        GUI.Label(new Rect(10, 40, 400, 25), insultos[indiceInsulto]);

        GUI.Label(new Rect(10, 80, 400, 500), strRespuestas);

        


        if(indiceRespuesta >= 0 && ! esperandoRespuesta) {
            GUI.Label(new Rect(10, 350, 400, 25), respuestas[indiceRespuesta]);
            GUI.Label(new Rect(10, 375, 400, 25), strMensajeUsuario);
        }
    }
    
    /* Un array es una estructura de datos que permite almacenar una colección de elementos del mismo tipo en memoria contigua
   Ejemplo: int[] miArray = new int[5];
   Esto crea un array llamado miArray que puede almacenar 5 enteros. Los elementos del array se numeran desde 0 hasta 4.*/
       private string[] insultos = {"¿Has dejado ya de usar pañales?",
                                 "¡No hay palabras para describir lo asqueroso que eres!", 
                                 "¡He hablado con simios más educados que tu!", 
                                 "¡Llevarás mi espada como si fueras un pincho moruno!",
                                 "¡Luchas como un ganadero!", 
                                 "¡No pienso aguantar tu insolencia aquí sentado!",
                                 "¡Mi pañuelo limpiará tu sangre!",
                                 "¡Ha llegado tu HORA, palurdo de ocho patas!",
                                 "¡Una vez tuve un perro más listo que tu!",
                                 "¡Nadie me ha sacado sangre jamás, y nadie lo hará!",
                                 "¡Me das ganas de vomitar!",
                                 "¡Tienes los modales de un mendigo!",
                                 "¡He oído que eres un soplón despreciable!",
                                 "¡La gente cae a mis pies al verme llegar!",
                                 "¡Demasiado bobo para mi nivel de inteligencia!",
                                 "Obtuve esta cicatriz en una batalla a muerte!",
    };
    private string[] respuestas = { "¿Por qué? ¿Acaso querías pedir uno prestado?",
                                    "Sí que las hay, sólo que nunca las has aprendido.",
                                    "Me alegra que asistieras a tu reunión familiar diaria.",
                                    "Primero deberías dejar de usarla como un plumero.",
                                    "Qué apropiado, tú peleas como una vaca.",
                                    "Ya te están fastidiando otra vez las almorranas, ¿Eh?",
                                    "Ah, ¿Ya has obtenido ese trabajo de barrendero?",
                                    "Y yo tengo un SALUDO para ti, ¿Te enteras?",
                                    "Te habrá enseñado todo lo que sabes.",
                                    "¿TAN rápido corres?",
                                    "Me haces pensar que alguien ya lo ha hecho.",
                                    "Quería asegurarme de que estuvieras a gusto conmigo.",
                                    "Qué pena me da que nadie haya oído hablar de ti",
                                    "¿Incluso antes de que huelan tu aliento?",
                                    "Estaría acabado si la usases alguna vez.",
                                    "Espero que ya hayas aprendido a no tocarte la nariz.",
    };
}
