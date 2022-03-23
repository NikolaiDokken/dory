using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class VisorRotation : MonoBehaviour
{
    float speed;
    float multiplier = 12000;
    public TextMeshPro txt;
    void Start(){
        speed = 0;
        txt.SetText("0");
    }

    void FixedUpdate()
    {
        if(speed < Math.Abs(BoatController.current_speed)){
            transform.Rotate(Vector3.left * (Math.Abs(BoatController.current_speed) - speed) * multiplier * Time.deltaTime);
        }
        else if(speed > Math.Abs(BoatController.current_speed)){
            transform.Rotate(Vector3.left * (Math.Abs(BoatController.current_speed) - speed) * multiplier * Time.deltaTime);
        }
        speed = Math.Abs(BoatController.current_speed);
        txt.SetText(Math.Round(speed * multiplier / 100).ToString());
    }
}
