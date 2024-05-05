using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    public float velocidad;
    [SerializeField] string nombre;
    public string Nombre { get { return nombre; } set { nombre = value; } }

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        Movimiento();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void Movimiento()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontal,0) * Time.deltaTime * velocidad);
    }
}
