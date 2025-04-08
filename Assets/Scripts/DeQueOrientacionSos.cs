using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeQueOrientacionSos : MonoBehaviour
{
    public string nombreAlumno;
    public int añoAlumno;
    public string orientacionAlumno;

    string tic = "T";
    string diseño = "D";
    string humanidades = "H";
    string gestion = "G";
    string medios = "M";

    // Start is called before the first frame update
    void Start()
    {
        if (nombreAlumno == "")
        {
            Debug.Log("Error. Ingresar nombre");
            return;
        }

        if (añoAlumno < 1 || añoAlumno > 5)
        {
            Debug.Log("El año ingresado no está en el rango apropiado");
            return;
        } else if(añoAlumno < 3 || añoAlumno > 5)
        {
            Debug.Log("Error.Aún estás en el ciclo básico");
            return;
        }

        if(orientacionAlumno != tic && orientacionAlumno != diseño && orientacionAlumno != humanidades && orientacionAlumno != gestion && orientacionAlumno != medios)
        {
            Debug.Log("valor no valido");
            return;
        }

        Debug.Log("Muchas gracias " + nombreAlumno + "!");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
