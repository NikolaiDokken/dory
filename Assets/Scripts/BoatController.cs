using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoatController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject propeler;
    public GameObject balloonBoat;
    public float turningSpeed;
    public float drivingSpeed;
    public float rotationSpeed;
    public Rigidbody rigidBody;

    float horizontalInput;
    float verticalInput;
    float angleMax = 1.57f;
    float angleMin = -1.57f;
    [SerializeField]
    float angle = 0.0f;
    float lx = 0.0f;


    void Start()
    {
        lx = Mathf.Abs(propeler.transform.position.x - balloonBoat.transform.position.x);        
    }

    // Update is called once per frame
    void Update()
    {
        Steer();
        Movement();
    }

    void Steer()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        angle += horizontalInput * turningSpeed * Time.deltaTime;
        angle = Mathf.Clamp(angle,angleMin, angleMax);
    }

    void Movement()
    {
        verticalInput = verticalInput = Input.GetAxis("Vertical");
        float Fx = verticalInput * drivingSpeed * Mathf.Cos(angle);
        float Fz = -verticalInput * drivingSpeed * Mathf.Sin(angle);
        rigidBody.AddRelativeForce(new Vector3(Fx, 0.0f, 0.0f), ForceMode.Acceleration);

        rigidBody.AddTorque(new Vector3(0f, - lx * Fz*rotationSpeed, 0.0f));

    }


}
