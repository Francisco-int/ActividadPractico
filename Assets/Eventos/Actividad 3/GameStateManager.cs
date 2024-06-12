using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public Action onGameStart;
    public Action onGamePause;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            StartGame();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            PauseGame();
        }
    }
    public void StartGame()
    {
        onGameStart?.Invoke();
    }

    public void PauseGame()
    {
        onGamePause?.Invoke();
    }
}
