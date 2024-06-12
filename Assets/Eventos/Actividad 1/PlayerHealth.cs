using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public Action onHealthChanged;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            TakeDamage(1);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Heal(1);
        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (onHealthChanged != null)
        {
            onHealthChanged.Invoke();
        }
    }

    public void Heal(int amount)
    {
        health += amount;
        if (onHealthChanged != null)
        {
            onHealthChanged.Invoke();
        }
    }
}
