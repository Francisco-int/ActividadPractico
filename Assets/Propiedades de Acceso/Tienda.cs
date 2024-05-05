using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tienda : MonoBehaviour
{
    public string Nombre { get; set; }
    public float valor { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Tienda(string nombre, float precio)
    {
        Nombre = nombre;
        valor = precio;
    }
}
