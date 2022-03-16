using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderScript : MonoBehaviour
{
    bool correct = true;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "IncorrectPath")
        {
            Debug.Log("Too close to boat");
            correct = false;
        }
        else if (other.tag == "Finish")
        {
            if(correct) Debug.Log("Congratulations!");
            else Debug.Log("Too bad!");
        }
    }
}
