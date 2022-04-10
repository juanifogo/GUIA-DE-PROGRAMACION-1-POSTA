//13. Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente
//manera:
//• Si trabaja 40 horas o menos se le paga $16 por hora(crear una constante para almacenar
//el 16)
//• Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20
//por cada hora extra. (crear una constante para almacenar el 20)
//Ingresar por Inspector la cantidad de horas trabajadas en la semana, y mostrar por pantalla
//el salario correspondiente.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio13 : MonoBehaviour
{
    const int SalarioHasta40 = 16;
    const int SalarioMasDe40 = 20;
    public int horas;
    // Start is called before the first frame update
    void Start()
    {
        int salario = 0;
        if (horas<41)
        {
            salario = horas*SalarioHasta40;
        }
        else
        {
            salario = 40 * SalarioHasta40 + (horas - 40) * SalarioMasDe40;
        }
        Debug.Log("El salario de esa semana es " + salario);
        /*  
        for (int i = 1; i <= horas && i<41; i++)
        {
            salario += SalarioHasta40;
        }
        if(horas>40)
        {
            horas -= 40;
        }
        for(int p = 1; p <= horas; p++)
        {
            salario += SalarioMasDe40;
        }
        Debug.Log("El salario de esa semana es " + salario);
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
