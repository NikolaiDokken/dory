using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject propeler;
    public GameObject balloonBoat;
    public float drivingSpeed;
    public float rotationSpeed;
    public Rigidbody rigidBody;

    [SerializeField]
    float angle = 0.0f;
    float lx = 0.0f;


    void Start()
    {
        lx = Mathf.Abs(propeler.transform.position.x - balloonBoat.transform.position.x);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        angle = wheelRotation.angle * Mathf.PI/900;
        Movement();
    }

    void Movement()
    {
        float Fx = gasRotation.tilt * drivingSpeed * Mathf.Cos(angle);
        float Fz = gasRotation.tilt * drivingSpeed * Mathf.Sin(angle);
        rigidBody.AddRelativeForce(new Vector3(Fx, 0.0f, Fz), ForceMode.Acceleration);

        rigidBody.AddTorque(new Vector3(0f, -lx * Fz * rotationSpeed, 0.0f));

    }


}
