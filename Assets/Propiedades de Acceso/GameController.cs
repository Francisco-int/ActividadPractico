using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Espada();
        Escudo();
        Pistola();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Espada()
    {
        Tienda espadaHierro = new Tienda("Espada de Hierro", 1.5f);
        Debug.Log("Producto: " + espadaHierro.Nombre + ", Precio: " + espadaHierro.valor);
    }
    void Escudo()
    {
        Tienda escudoMadera = new Tienda("Escudo de Madera", 0.5f);
        Debug.Log("Producto: " + escudoMadera.Nombre + ", Precio: " + escudoMadera.valor);
    }
    void Pistola()
    {
        Tienda pistolaPewPew = new Tienda("Pistola:Pew-Pew", 9999f);

        Debug.Log("Producto: " + pistolaPewPew.Nombre + ", Precio: " + pistolaPewPew.valor);
    }
}
