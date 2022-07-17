using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScene : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ExitScene()
    {
        Application.Quit();
    }
    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene(0);
    }
}
