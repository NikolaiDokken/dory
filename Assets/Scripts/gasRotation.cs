using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gasRotation : MonoBehaviour
{
   
    public float maxDown = 0.5f;
    public float maxUp = -0.5f;
    public float speed = 50;

    float currentTilt;
    
    void Update()
    {
        currentTilt = gameObject.transform.rotation.z;
        float delta = Time.deltaTime;
        if (Input.GetKey(KeyCode.W) && currentTilt > maxUp)
            transform.Rotate(-Vector3.forward * speed * Time.deltaTime);
      
        if (Input.GetKey(KeyCode.S) && currentTilt < maxDown)
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
