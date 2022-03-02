using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class wheelRotation : MonoBehaviour
{
    public float maxLeft = 450f;
    public float maxRight = -450f;
    public float speed = 200;
    
    float delta; 
    float lerp = 0f;
    float tilt;
    float angle;

    void Update()
    {
        tilt = gameObject.transform.rotation.x;
        delta = Time.deltaTime;
        if (Input.GetKey(KeyCode.A) && angle < maxLeft){
            if(lerp < 0) lerp = 0;
            lerp += delta;
            transform.Rotate(Vector3.up, speed * delta, Space.Self);
            angle += speed * delta;
        }
        else if (Input.GetKey(KeyCode.D) && angle > maxRight){
            if(lerp > 0) lerp = 0;
            lerp -= delta;
            transform.Rotate(Vector3.down, speed * delta, Space.Self);
            angle -= speed * delta;
        }
        else{
            if (lerp != 0 && angle > maxRight && angle < maxLeft){
                if(lerp > 1) lerp = 1;
                else if(lerp < -1) lerp = -1;
                
                angle += speed * delta * lerp;
                transform.Rotate(Vector3.up, speed * delta * lerp, Space.Self);

                if(lerp > 0){
                    lerp -= delta;
                    if(lerp < 0) lerp = 0;
                }
                else if(lerp < 0){
                    lerp += delta;
                    if(lerp > 0) lerp = 0;
                }
            }
            else if(angle < maxRight) angle = maxRight;
            else if(angle > maxLeft) angle = maxLeft;
            else{
                lerp = 0;
            }
        }
    }
}
