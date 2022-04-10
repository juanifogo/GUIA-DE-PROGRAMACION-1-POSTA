//15. Existen dos reglas que identifican dos conjuntos de valores:
//- El número es de un solo dígito.
//- El número es impar.
//A partir de estas reglas, creá un algoritmo que asigne a las variables booleanas estaEnA,
//estaEnB, estaEnAmbos y noEstaEnNinguno el valor verdadero o falso, según corresponda,
//para indicar si el valor ingresado pertenece al primer conjunto, al segundo, a ambos o a
//ninguno, respectivamente.Definí un lote de prueba de varios números y probá el algoritmo,
//escribiendo los resultados.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio15 : MonoBehaviour
{
    bool EstaEnA, EstaEnB, EstaEnAmbos, NoEstaEnNinguno;
    public  int[] nums;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < nums.Length; i++)
        {
            EstaEnA = nums[i] < 10 && nums[i] > -10;
            EstaEnB = nums[i] % 2 == 1 || nums[i] % 2 == -1;
            EstaEnAmbos = EstaEnA && EstaEnB;
            NoEstaEnNinguno = !EstaEnA && !EstaEnB;
            Debug.Log("Las propiedades del numero " + nums[i] + " son:\nEsta en A: " + EstaEnA + "\nEsta en B: " + EstaEnB + "\nEsta en ambos: " + EstaEnAmbos + "\nNo esta en ninguno: " + NoEstaEnNinguno);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}