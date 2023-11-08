using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public float torque;
    public float velocity;
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
       // float turn = Input.GetAxis("Horizontal");
       /// rb.AddTorque(Vector3.up * torque  * turn);
        
       // rb.AddForce(Vector3.forward * velocity * vertical);

        var vertical = Input.GetAxis("Vertical");
        rb.AddForce(Camera.main.transform.forward * velocity * vertical);
        rb.AddForce(Camera.main.transform.up * velocity * vertical);

        rb.AddForce(Camera.main.transform.up * velocity * vertical);
   // rb.AddForce(Camera.main.transform.forward * velocity * vertical);
    }
}
