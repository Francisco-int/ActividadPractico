using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
   public PlayerInventario player;
    public GameObject objecto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AgregarObjeto()
    {
        player.inventario.Add(objecto);
    }
    public void QuitarObjeto()
    {
        player.inventario.Remove(objecto);
    }
}
