﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private GameManager game;
    private void Start()
    {
        game = GameManager.GetInstance();
    }
    public void PlayLevel()
    {
        if(game.Loss)
        {
            game.Loss = false;
        }
        else
        {
            game.AdvanceLevel();
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + game.GetLevel());
    }

    public void QuitGame()
    {
        Debug.Log("Quit game");
        Application.Quit();
    }
}
