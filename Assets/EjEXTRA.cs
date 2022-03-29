//12. En un casino de juegos se desea mostrar los mensajes respectivos por el puntaje  obtenido en el lanzamiento de tres dados de un cliente, de acuerdo a los siguientes  resultados:  
//• Si los tres dados son seis, mostrar el mensaje “Excelente” 
//• Si dos dados son seis, mostrar el mensaje “Muy bien”  
//• Si un dado es seis, mostrar el mensaje “Regular”  
//• Si ningún dado se obtiene seis, mostrar el mensaje “Insuficiente” 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjEXTRA : MonoBehaviour
{
    public int Dado1;
    public int Dado2;
    public int Dado3;

    int cantSeis = 0;


    // Start is called before the first frame update
    void Start()
    {
        if (Dado1 ==6 )
        {
            cantSeis++;             
        }
        if (Dado2 ==6 )
        {
            cantSeis++;
        }
        if (Dado3 == 6)
        {
            cantSeis++;
        }
        switch (cantSeis)
        {
            case 1:
                Debug.Log("Regular");
                break;

            case 2:
                Debug.Log("Muy bien");
                break;
            case 3:
                Debug.Log("Excelente");
                break;
            case 0:
                Debug.Log("Insuficiente");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
