﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("LevelOne");
    }

    public void GoToSettingsMenu()
    {
        SceneManager.LoadScene("SettingsMenu");
    }

    public void GoToInstructionMenu()
    {
        SceneManager.LoadScene("InstructionsMenu");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoToLevelOne()
    {
        SceneManager.LoadScene("LevelOne");
    }

    public void FinishGame()
    {
        Application.Quit();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
