//12. En un casino de juegos se desea mostrar los mensajes respectivos por el puntaje
//obtenido en el lanzamiento de tres dados de un cliente, de acuerdo a los siguientes
//resultados:
//• Si los tres dados son seis, mostrar el mensaje “Excelente”
//• Si dos dados son seis, mostrar el mensaje “Muy bien”
//• Si un dado es seis, mostrar el mensaje “Regular”
//• Si ningún dado se obtiene seis, mostrar el mensaje “Insuficiente”
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio12 : MonoBehaviour
{
    byte CantDe6;
    string resultado;
    public int dado1, dado2, dado3;
    // Start is called before the first frame update
    void Start()
    {

        if (dado1 < 1 || dado1 > 6 || dado2 < 1 || dado2 > 6 || dado3 < 1 || dado3 > 6)
        {
            Debug.Log("Valores de dados no validos");
            return;
        }
        else if (dado1 + dado2 + dado3 == 18)
        {
            CantDe6 = 3;
        }
        else if(dado1+dado2==12 || dado1+dado3==012 || dado2+dado3==12)
        {
            CantDe6 = 2;
        }
        else if(dado1+dado2+dado3<16)
        {
            CantDe6 = 0;
        }
        else
        {
            CantDe6 = 1;
        }
        switch(CantDe6)
        {
            case 0: resultado = "Insuficiente"; break;
            case 1: resultado = "Regular"; break;
            case 2: resultado = "Muy bien"; break;
            case 3: resultado = "Excelente"; break;
        }
            Debug.Log(resultado);     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}