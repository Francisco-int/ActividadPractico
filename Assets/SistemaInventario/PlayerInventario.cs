using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventario : MonoBehaviour
{
    public List<GameObject> inventario;
    public Inventario inventarioManager;
    public Text inventarioUi;
    public float movimientoSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

        if (Input.GetKeyDown(KeyCode.E))
        {
            inventarioManager.QuitarObjeto();
            inventarioUi.text = "Inventario: " + inventario.Count();
        }
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
        if (collision.gameObject.CompareTag("AgregarObjeto"))
        {
            inventarioManager.AgregarObjeto();
            inventarioUi.text = "Inventario: " + inventario.Count();
        }
    }
}
