using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propRotation : MonoBehaviour
{
    public float speed, maxUp, maxDown, currentTilt;
    public GameObject gas;
    void Start()
    {
        maxDown = 0.5f;
        maxUp = -0.5f;
        gas = GameObject.Find("/BallonBoat/GasParent");
    }

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
