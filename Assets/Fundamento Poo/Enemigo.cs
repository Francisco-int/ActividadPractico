using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Enemigo : Personaje
{

    // Update is called once per frame
    void Update()
    {
        
    }
   public override void Atacar()
    {
        Debug.Log("Adios" + nombre);
    }
}
