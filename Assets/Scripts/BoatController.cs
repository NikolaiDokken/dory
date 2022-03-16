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

    float verticalInput;
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
        angle = - wheelRotation.angle * Mathf.PI/900;
        Movement();
    }

    void Movement()
    {
        verticalInput = Input.GetAxis("Vertical");
        float Fx = verticalInput * drivingSpeed * Mathf.Cos(angle);
        float Fz = -verticalInput * drivingSpeed * Mathf.Sin(angle);
        rigidBody.AddRelativeForce(new Vector3(Fx, 0.0f, 0.0f), ForceMode.Acceleration);

        rigidBody.AddTorque(new Vector3(0f, -lx * Fz * rotationSpeed, 0.0f));

    }


}
