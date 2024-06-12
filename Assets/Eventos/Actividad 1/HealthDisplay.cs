using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Text healthText;

    private void OnEnable()
    {
        playerHealth.onHealthChanged += UpdateHealthUI;
    }

    private void OnDisable()
    {
        playerHealth.onHealthChanged -= UpdateHealthUI;
    }

    private void UpdateHealthUI()
    {
        healthText.text = "Health: " + playerHealth.health;
    }
}