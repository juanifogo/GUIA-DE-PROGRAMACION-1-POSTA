//9. Realizá un programa que resuelva el siguiente problema:
//Tres personas aportan diferente capital a una sociedad.Se desea saber qué porcentaje del
//total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
//por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
//mostrar lo pedido en el siguiente formato:
//Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ ….
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{
    public float cant1, cant2, cant3;
    public string nom1, nom2, nom3;
    // Start is called before the first frame update
    void Start()
    {
        float prcnt1, prcnt2, prcnt3, total;
        total = cant1 + cant2 + cant3;
        prcnt1 = 100 * cant1 / total;
        prcnt2 = 100 * cant2 / total;
        prcnt3 = 100 * cant3 / total;
        Debug.Log("Nombre: " + nom1 + " // Capital aportado: $" + cant1 + " // Porcentaje del capital: %" + prcnt1 + " // Monto total aportado: " + total);
        Debug.Log("Nombre: " + nom2 + " // Capital aportado: $" + cant2 + " // Porcentaje del capital: %" + prcnt2 + " // Monto total aportado: " + total);
        Debug.Log("Nombre: " + nom3 + " // Capital aportado: $" + cant3 + " // Porcentaje del capital: %" + prcnt3 + " // Monto total aportado: " + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
