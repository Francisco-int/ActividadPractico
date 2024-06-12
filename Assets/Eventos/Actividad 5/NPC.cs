using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Action onInteraction;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            onInteraction?.Invoke();
        }
    }
    
}
   
