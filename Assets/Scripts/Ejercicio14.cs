//14. Construir un programa que simule el funcionamiento de una calculadora que puede
//realizar las cuatro operaciones aritméticas básicas(suma, resta, producto y división) con
//valores numéricos enteros.
//Se debe especificar la operación que se desea realizar ingresando una letra por Inspector (s
//para la suma, r para la resta, p para el producto y d para la división) y luego, deberán
//ingresarse dos números enteros para así realizar la operación.Informar el resultado por
//pantalla.Nota: Se recomienda el empleo de una sentencia switch.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio14 : MonoBehaviour
{
    public int num1, num2;
    public string operacion;
    int resultado;
    // Start is called before the first frame update
    void Start()
    {
        if (operacion == "d" || operacion == "p" || operacion == "s" || operacion == "r")
        {
            switch (operacion)
            {
                case "d": resultado = num1 / num2; break;
                case "p": resultado = num1 * num2; break;
                case "s": resultado = num1 + num2; break;
                case "r": resultado = num1 - num2; break;
            }
            Debug.Log(resultado);
        }
        else
        {
            Debug.Log("El operador ingresado no es valido");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}