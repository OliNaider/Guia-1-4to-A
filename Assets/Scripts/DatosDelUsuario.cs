﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{

    public string nombreUsuario;
    [SerializeField] int edadUsuario;
    [SerializeField] float estaturaUsuario;
    [SerializeField] bool esDonante; 
    mbox,mc

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es " + nombreUsuario "tengo " + String(edadUsuario) );
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
