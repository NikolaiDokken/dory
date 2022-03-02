using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motorRotation : MonoBehaviour
{
    public float speed, maxLeft, maxRight, delta, lerp, tilt, angle;
    void Start()
    {
        lerp = 0.0f;
        maxLeft = 450.0f;
        maxRight = -450.0f;
        speed = 200;
        //center = gameObject.transform.GetComponent<Renderer>().bounds.center;
    }

    void Update()
    {
        tilt = gameObject.transform.rotation.x;
        delta = Time.deltaTime;
        if (Input.GetKey(KeyCode.A) && angle < maxLeft){
            if(lerp < 0) lerp = 0;
            lerp += delta;
            angle += speed * delta;
            transform.Rotate(Vector3.forward, (speed/10) * delta, Space.Self);
        }
        else if (Input.GetKey(KeyCode.D) && angle > maxRight){
            if(lerp > 0) lerp = 0;
            lerp -= delta;
            angle -= speed * delta;
            transform.Rotate(-Vector3.forward, (speed/10) * delta, Space.Self);
        }
        else{
            if (lerp != 0 && angle > maxRight && angle < maxLeft){
                if(lerp > 1) lerp = 1;
                else if(lerp < -1) lerp = -1;
                
                angle += speed * delta * lerp;
                transform.Rotate(Vector3.forward, (speed/10) * delta * lerp, Space.Self);

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
