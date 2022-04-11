using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{

    public int MontoPesos;
    private int ConversiónDolares = 220;
    private int ConversiónEuros = 230;
    private int ConversiónReales = 24;
    public string Moneda;
    

    void Start()
        
    {
       
       
        if (MontoPesos < 1000)
        {
            Debug.Log("La cantidad de dinero ingresada es menor al monto minimo posible.");
        }

        else if (MontoPesos >= 1000)
        {
            

            if (Moneda == "E" || Moneda == "e")
            {
                Debug.Log(" la conversión te queda en " + MontoPesos / ConversiónEuros + " Euros ");
            }

            else if (Moneda == "D" || Moneda == "d")
            {
                Debug.Log(" la conversión te queda en " + MontoPesos / ConversiónDolares + " Dolares ");

            }

            else if (Moneda == "R" || Moneda == "r")
            {
                Debug.Log(" la conversión de " + MontoPesos + " pesos te queda en " + MontoPesos / ConversiónReales + " Reales ");

            }

            else
            {
                Debug.Log("Ingrese el valor de una moneda válida");

            }


        }






    }

    

    
}
