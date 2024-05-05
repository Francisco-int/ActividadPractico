using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circulo : MonoBehaviour
{
    public CanvasManager canvas;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Cubo>())
        {
            Cubo cubo = collision.gameObject.GetComponent<Cubo>();
            if(cubo.Nombre == "Cubito")
            {
                canvas.circuloText.enabled = true;
                canvas.circuloText.text = "Tu nombre ahora es Circulo";
                cubo.Nombre = "Circulo";
                anim.SetBool("HiCircle", true);
            }
            else
            {
                anim.SetBool("HiCircle", false);
                canvas.circuloText.enabled = true;
                canvas.circuloText.text = "Hola "+ cubo.Nombre;
                anim.SetBool("HiCircle", true);
            }
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        canvas.circuloText.enabled = false;
        anim.SetBool("HiCircle", false);
    }
}
