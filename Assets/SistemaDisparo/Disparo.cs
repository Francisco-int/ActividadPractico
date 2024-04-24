using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{

    public Vector3 posicion;
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DispararProyectil(Vector3 posicionSalida)
    {
       posicion = posicionSalida;
       GameObject newBala = Instantiate(this.gameObject, posicion, Quaternion.identity);
       Rigidbody rb = newBala.GetComponent<Rigidbody>();
       rb.AddForce(newBala.transform.forward * velocidad, ForceMode.Impulse);
    }
}
