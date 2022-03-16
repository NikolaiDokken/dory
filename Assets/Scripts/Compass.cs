using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour
{
    public GameObject target;
    void Start(){

    }
    void LateUpdate(){
        transform.rotation = target.transform.rotation;
    }
}
