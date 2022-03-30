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

    public static float current_speed;
    Vector3 location;

    void Start()
    {
        location = transform.position;
    }

    void FixedUpdate()
    {
        angle = wheelRotation.angle * Mathf.PI/900;
        Movement();
    }

    void Movement()
    {
        float Fx = gasRotation.tilt * drivingSpeed * Mathf.Cos(angle);
        float Fz = gasRotation.tilt * drivingSpeed * Mathf.Sin(angle);
        rigidBody.AddRelativeForce(new Vector3(Fx, 0.0f, 0.0f), ForceMode.Acceleration);

        rigidBody.AddTorque(new Vector3(0f, - Fz * rotationSpeed, 0.0f));
        current_speed = Vector3.Distance(location, transform.position);
        location = transform.position;
    }


}
