using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public float movimientoSpeed;
   PuntajeManager manager;

    private void Update()
    {
        MovePlayer();
        manager = GameObject.Find("Punto").GetComponent<PuntajeManager>();
    }

    private void MovePlayer()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalMove, 0f, verticalMove) * movimientoSpeed * Time.deltaTime;
        transform.Translate(movement);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Punto"))
        {
            manager.ActualizarPuntaje();
        }
        
    }
}