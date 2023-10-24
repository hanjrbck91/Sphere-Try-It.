using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RendererEnabler : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
        Renderer renderer = GetComponent<Renderer>();
        renderer.enabled = !renderer.enabled;
        }
    }
}
