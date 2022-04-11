using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej_1 : MonoBehaviour
{
    // Start is called before the first frame update
    public float monto;
    public string moneda;
    void Start()
    {
        float calculo;

        if (monto < 1000){
            Debug.Log("El monto mínimo es 1000");
        }
        else if (monto >= 1000)
        {

        
        if (moneda == "D")
        {
                calculo = monto / 112;
                Debug.Log("Su monto de " + monto + " pesos equivale a "+calculo+" en dolares");
        }
        else if (moneda == "R")
        {
                calculo = monto / 23;
                Debug.Log("Su monto de " + monto + " pesos equivale a " + calculo + " en reales");
            }
        else if (moneda == "E")
        {
                calculo = monto / 122;
                Debug.Log("Su monto de " + monto + " pesos equivale a " + calculo + " en euros");
            }
        else
        {
            Debug.Log("Opción de moneda extranjera no válida");
        }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
