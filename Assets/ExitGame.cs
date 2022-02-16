using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    // exits the game


    // Update is called once per frame
    void Update()
    {
        void exitGame()
        {
            Application.Quit();
            Debug.Log("Game is exiting");

        }
    }

}
