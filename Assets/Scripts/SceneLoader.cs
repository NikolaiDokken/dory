using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadGame()
    {
        PlayerPrefs.SetInt("prevSceneIndex", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadGameByName(string sceneName)
    {
        PlayerPrefs.SetInt("prevSceneIndex", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(sceneName);
    }

    public void LoadPreviousScene() {
        SceneManager.LoadScene(PlayerPrefs.GetInt("prevSceneIndex"));
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting!");
    }
}
