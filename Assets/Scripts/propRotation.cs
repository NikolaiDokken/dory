using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propRotation : MonoBehaviour
{
    public float maxDown = 0.5f;
    public float maxUp = -0.5f;
    public GameObject gas;
    
    float speed, currentTilt;

    void Update()
    {
        currentTilt = gas.transform.rotation.z;
        float delta = Time.deltaTime;
        if (Input.GetKey(KeyCode.W)){
            if(currentTilt > maxUp)
                speed += 20;
            else speed = 2500;
        }
      
        if (Input.GetKey(KeyCode.S)){
            if(currentTilt < maxDown)
                speed -= 20;
            else speed = -2500;
        }

        transform.Rotate(Vector3.down * speed * Time.deltaTime);
    }
}
