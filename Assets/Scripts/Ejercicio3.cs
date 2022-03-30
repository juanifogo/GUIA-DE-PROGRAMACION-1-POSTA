using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    public string input;
    // Start is called before the first frame update
    void Start()
    {
        if (input.Length > 0)
        {
            Debug.Log("Hola " + input);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}