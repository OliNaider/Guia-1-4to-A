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

    float dolar = 1204.32f;
    float euro = 1541.11f;
    float reales = 201.24f;
    float minimoAConvertir = 1000;

    // Start is called before the first frame update
    void Start()
    {
        //2 ingreso y validacion de datos
        if (montoAConvertir < minimoAConvertir)
        {
            Debug.Log("El monto mínimo es $1000");
            return; 
        } 

        if(codigoMoneda == "D")
        {
            cotizacionMoneda = dolar;
        } else if (codigoMoneda == "E")
        {
            cotizacionMoneda = euro;
        } else if(codigoMoneda == "R")
        {
            cotizacionMoneda = reales;
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
