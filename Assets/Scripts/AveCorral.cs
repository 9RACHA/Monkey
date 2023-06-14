using System.Collections;
using System.Collections.Generic;


public class AveCorral : AnimalGranja {

    public AveCorral(int numeroCrotal, string especie, string voz) : base(numeroCrotal, especie, voz, 2, 2 , true) {}

    //En este método no declaramos que sobreescribe al método de la clase padre, que
    //a su vez tampoco está declarado como virtual.
    //Esto hace que el método se vea sobreescrito si llamamos a un objeto de la clase AveCorral
    //pero se llame al método de la clase padre si la referencia se hace con una variable del tipo
    //AnimalGranja.

    public string Vocear() {
        return $"{voz},ME LO METO X CULO!";
    }

    /*Indica que un método, propiedad o evento en una clase derivada está sobrescribiendo o reemplazando un miembro con el mismo nombre de la clase base.*/
    public override string Patear() {
        return "Te doy picotazos";
    }
}
