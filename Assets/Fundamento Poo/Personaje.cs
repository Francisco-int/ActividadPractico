using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Personaje : MonoBehaviour
{
    public string nombre;
    // Start is called before the first frame update
    void Start()
    {
        Atacar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public virtual void Atacar()
    {
        Debug.Log("Hola" + nombre);
    }
}
