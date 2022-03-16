using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {
    public static bool isPaused = false;
    public GameObject pauseMenu;

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (isPaused) {
                ResumeGame();
            } else {
                PauseGame();
            }
        }

    }
    public void ResumeGame() {
        pauseMenu.SetActive(false);
        isPaused = false;
        Time.timeScale = 1;
        Camera.main.GetComponent<FirstPersonCamera>().paused = false;


    }

    public void PauseGame() {
        pauseMenu.SetActive(true);
        isPaused = true;
        Time.timeScale = 0;
        Camera.main.GetComponent<FirstPersonCamera>().paused = true;

    }
}
