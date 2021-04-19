using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("CryostasisChamber");
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

    public void GoToBack()
    {
        SceneManager.LoadScene("Hallway1");
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
