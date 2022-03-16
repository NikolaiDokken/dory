using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerCollision : MonoBehaviour {
    bool hasFailed = false;

    void OnTriggerEnter(Collider collisionObject) {
        if (collisionObject.tag == "IncorrectPath") {
            hasFailed = true;
        }
        if (collisionObject.tag == "Finish") {
            // OPEN game over menu
            if (hasFailed) {
                PlayerPrefs.SetInt("prevSceneIndex", SceneManager.GetActiveScene().buildIndex);
                SceneManager.LoadScene("LevelFailedScene");
                return;
            }
                SceneManager.LoadScene("LevelCompleteScene");

        }
    }
}
