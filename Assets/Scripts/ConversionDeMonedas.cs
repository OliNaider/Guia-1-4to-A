using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMonedas : MonoBehaviour
{
    // 1 declaracion de variables
    public float montoAConvertir;
    public string codigoMoneda;

    float cotizacionMoneda;
    float montoConvertido;

    // Start is called before the first frame update
    void Start()
    {
        //2 ingreso y validacion de datos
        if (montoAConvertir < 1000)
        {
            Debug.Log("El monto mínimo es $1000");
            return; 
        } 

        if(codigoMoneda == "D")
        {
            cotizacionMoneda = 1204.32f;
        } else if (codigoMoneda == "E")
        {
            cotizacionMoneda = 1541.11f;
        } else if(codigoMoneda == "R")
        {
            cotizacionMoneda = 201.24f;
        } else
        {
            Debug.Log("Opción de moneda extranjera no válida");
            return;
        }

        //3 procesamiento de los datos

        montoConvertido = montoAConvertir / cotizacionMoneda;
        Debug.Log("Monto convertido: " + montoConvertido);


        //4 salida datos
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
