using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangulo : MonoBehaviour
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
            canvas.rectanguloText.enabled = true;
            canvas.rectanguloText.text = "Hola " + cubo.Nombre + " ¿Como estas?";
            anim.SetBool("Hi", true);
          
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        canvas.rectanguloText.enabled = false;
        anim.SetBool("Hi", false);
    }
}
