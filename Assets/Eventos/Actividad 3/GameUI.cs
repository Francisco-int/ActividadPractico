using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    public GameStateManager gameStateManager;
    public GameObject startUI;
    public GameObject pauseUI;
    private void Start()
    {
        startUI.SetActive(false);
        pauseUI.SetActive(false);
    }
    private void OnEnable()
    {
        gameStateManager.onGameStart += ShowStartUI;
        gameStateManager.onGamePause += ShowPauseUI;
    }

    private void OnDisable()
    {
        gameStateManager.onGameStart -= ShowStartUI;
        gameStateManager.onGamePause -= ShowPauseUI;
    }

    private void ShowStartUI()
    {
        startUI.SetActive(true);
        pauseUI.SetActive(false);
    }

    private void ShowPauseUI()
    {
        startUI.SetActive(false);
        pauseUI.SetActive(true);
    }
}
