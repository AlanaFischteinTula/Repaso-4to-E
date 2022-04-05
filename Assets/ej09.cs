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

public class ej09 : MonoBehaviour
{
    public string nombre1;
    public string nombre2;
    public string nombre3;

    public float capitalAportado1;
    public float capitalAportado2;
    public float capitalAportado3;

    float porcentaje1;
    float porcentaje2;
    float porcentaje3;

    public float capitalAportadoT;

    // Start is called before the first frame update
    void Start()
    {

        porcentaje1 = (capitalAportado1 / capitalAportadoT) * 100;

        Debug.Log("Nombre: " + nombre1 + ", porcentaje del capital: %" + porcentaje1 + ", monto total aportado: $" + capitalAportado1);
        Debug.Log("Nombre: " + nombre2 + ", porcentaje del capital: %" + porcentaje2 + ", monto total aportado: $" + capitalAportado2);
        Debug.Log("Nombre: " + nombre3 + ", porcentaje del capital: %" + porcentaje3 + ", monto total aportado: $" + capitalAportado3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
