using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorVisibility : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        Cursor.lockState = CursorLockMode.None;

    }

    // Update is called once per frame
    void Update() {
        Cursor.lockState = CursorLockMode.None;

    }
}
