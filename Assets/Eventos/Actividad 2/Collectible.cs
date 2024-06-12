using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public delegate void OnCollected();
    public static OnCollected onCollected;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Collect();
        }
    }

    void Collect()
    {
       
            onCollected?.Invoke();
            Destroy(gameObject);
        
    }
}