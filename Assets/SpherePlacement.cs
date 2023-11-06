using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpherePlacement : MonoBehaviour
{
    public Transform sphereTransform;
    public Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        sphereTransform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
