﻿//10. Realizá un programa que resuelva el siguiente problema: Nos piden desarrollar un
//programa que informe si un estacionamiento se encuentra o no abierto según la hora
//ingresada por el usuario.
//Nosotros sabemos que el estacionamiento se encuentra abierto entre las 10 y las 18hs.
//(Crear constante HORA_APERTURA = 10, y HORA_CIERRE = 18).
//Al iniciar el programa, se tomará como hora actual el valor de una variable expuesta en el
//Inspector, y deberemos setear una variable booleana llamada estaAbierto en true o false,
//según corresponda, e informar por pantalla mediante la misma si el estacionamiento se
//encuentra abierto o no.Obs: En el caso de que el valor de la variable correspona a una hora
//menor a 0 o mayor a 24, mostrar el mensaje: “Ha ingresado una hora incorrecta”
//using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio10 : MonoBehaviour
{
    public const int HORA_APERTURA = 10;
    public const int HORA_CIERRE = 18;
    public bool estaAbierto;
    public int hora = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (hora >= 18 && hora <= 24)
        {
            estaAbierto = false;
            Debug.Log(estaAbierto);
        }
        else if (hora < 10 && hora >= 0)
        {
            estaAbierto = false;
            Debug.Log(estaAbierto);
        }
        else if (hora > 24 || hora < 0)
        {
            Debug.Log("Ha ingresado una hora incorrecta");
        }
        else if (hora >= 10 && hora < 18)
        {
            estaAbierto = true;
            Debug.Log(estaAbierto);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
