using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeIjector : MonoBehaviour
{
    public float ijecttionPower;
    public Rigidbody projectile;
    public Transform ijectPos;

    // Update is called once per frame
    void Update()
    {
        Rigidbody projectileInstance;

        projectileInstance =  Instantiate(projectile, ijectPos.position, ijectPos.rotation) as Rigidbody;
        projectileInstance.AddForce(ijecttionPower * ijectPos.up);
    }
}
