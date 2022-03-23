using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class VisorRotation : MonoBehaviour
{
    float cur_tilt;
    float multiplier = 45;
    public TextMeshPro txt;
    void Start(){
        cur_tilt = 0;
        txt.SetText("0");
    }

    void FixedUpdate()
    {
        if(cur_tilt < Math.Abs(gasRotation.tilt)){
            transform.Rotate(Vector3.left * (Math.Abs(gasRotation.tilt) - cur_tilt) * multiplier * Time.deltaTime);
        }
        else if(cur_tilt > Math.Abs(gasRotation.tilt)){
            transform.Rotate(Vector3.left * (Math.Abs(gasRotation.tilt) - cur_tilt) * multiplier * Time.deltaTime);
        }
        cur_tilt = Math.Abs(gasRotation.tilt);
        txt.SetText(cur_tilt.ToString());
    }
}
