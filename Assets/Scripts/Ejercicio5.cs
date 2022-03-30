using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            Debug.Log(num1 + "/" + num2 + " = " + (num1 / num2));
        }
        catch { Debug.Log("No se puede dividir por cero"); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
