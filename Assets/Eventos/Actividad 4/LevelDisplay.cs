using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelDisplay : MonoBehaviour
{
    public LevelManager levelManager;
    public Text levelText;
    private int currentLevel;

    private void OnEnable()
    {
        levelManager.onLevelChanged += UpdateLevelUI;
    }

    private void OnDisable()
    {
        levelManager.onLevelChanged -= UpdateLevelUI;
    }

    private void UpdateLevelUI()
    {
        currentLevel++;
        levelText.text = "Level: " + currentLevel;
    }
}
