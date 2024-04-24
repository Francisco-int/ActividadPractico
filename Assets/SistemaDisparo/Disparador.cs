using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    Disparo disparo;
    Vector3 posicionDisparado;
     void Start()
    {
        disparo = GameObject.Find("Bala").GetComponent<Disparo>();
        posicionDisparado = transform.position;
    }

     void Update()
    {

        if(Input.GetKeyUp(KeyCode.Space))
        {
            disparo.DispararProyectil(posicionDisparado);
        }
    }
}