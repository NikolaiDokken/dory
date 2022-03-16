using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gasRotation : MonoBehaviour
{
   
    public float maxDown = 50f;
    public float maxUp = -90;
    public float speed = 50;

    public static float tilt;
    KeyCode lastInput;

    void Start(){
        lastInput = KeyCode.Z;
    }
    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) && tilt > maxUp){
            if(!(lastInput == KeyCode.W && tilt > -1 && tilt < 1)){
                transform.Rotate(-Vector3.forward * speed * Time.deltaTime);
                tilt -= speed * Time.deltaTime;
            }
            else tilt = 0;
            lastInput = KeyCode.W;
        }
        else if (Input.GetKey(KeyCode.S) && tilt < maxDown){
            if(!(lastInput == KeyCode.S && tilt > -1 && tilt < 1)){
                transform.Rotate(Vector3.forward * speed * Time.deltaTime);
                tilt += speed * Time.deltaTime;
            }
            else tilt = 0;
            lastInput = KeyCode.S;
        }
        else{
            lastInput = KeyCode.Z; // reset, dummy key
        }
    }
}
