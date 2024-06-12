using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Action onLevelChanged;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ChangeLevel();
        }
    }
    public void ChangeLevel()
    {
        onLevelChanged?.Invoke();
    }
}
