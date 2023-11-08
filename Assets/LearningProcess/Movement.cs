using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed;

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= 1 * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += 1 * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.z -= 1 * Time.deltaTime * speed; ;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.z += 1 * Time.deltaTime * speed;
        }

        transform.position = pos;
    }
}
