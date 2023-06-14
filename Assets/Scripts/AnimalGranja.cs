using System.Collections;
using System.Collections.Generic;

/*
Clase que representa animales de granja y imita algunos de sus comportamientos
generando strings que los describen.
*/

public class AnimalGranja {

    //propiedades del animal
    protected int numeroCrotal;
    protected string especie;
    protected string voz;
    protected int numeroPatas;
    protected int numeroAlas;
    protected bool pico;
    /* Una variable declarada como "protected" puede ser accedida desde la clase que la declara,
     y desde cualquiera que hereda de esta,
    sino no puede ser accedida desde fuera de la clase*/


    //Constructor de la clase. Genera objetos de la clase AnimalGranja
    //Rellenando sus propiedades con los valores que suministran como parámetros
    public AnimalGranja(int numeroCrotal, string especie, string voz, int numeroPatas, int numeroAlas, bool pico = false) {
        //Se utiliza la palabra reservada this para distinguir la referencia
        //a la propiedad el objeto del parámetro del constructor
        this.numeroCrotal = numeroCrotal;
        this.especie = especie;
        this.voz = voz;
        this.numeroPatas = numeroPatas;
        this.numeroAlas = numeroAlas;
        this.pico = pico;
        /*this se refiere a la referencia, al objeto actual en el que se está trabajando.
        Se utiliza para acceder y referirse a las variables miembro (atributos) y métodos de la instancia actual de una clase*/
    }

    /*Se utiliza para finalizar la ejecución de una función o método y devolver un valor (opcional)
     al punto desde donde se llamó a la función*/
    public string Vocear() {
        return $"{voz}, {voz}, {voz}";
    }

    //metodo Patear declarado para ser sobreescrito en las clases que deriven de AnimalGranja
    /*Indica que un método, propiedad o evento puede ser sobrescrito o reemplazado en una clase derivada.
    Declarar un miembro de clase que puede ser modificado en clases derivadas mediante la palabra clave "override".*/
    public virtual string Patear() {
        return $"Te doy {numeroPatas} coces";
    }
    
    public string Info() {
        return $"Soy una {especie} y tengo {numeroPatas} patas";
    }
        
}
