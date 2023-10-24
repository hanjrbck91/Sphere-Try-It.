using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMaker : MonoBehaviour
{
    public GameObject sphere;
    public int numberofSpheres;
    // Start is called before the first frame update
    void Update()
    {
        for (int i = 0; i < numberofSpheres; i++)
        {
            if (Input.GetMouseButtonDown(1))
            {
                var duplicateSphere = GameObject.Instantiate(sphere);
                duplicateSphere.transform.position = new Vector3(Random.Range(-4, 4), Random.Range(-4, 4), 0);
                Camera.main.transform.LookAt(duplicateSphere.transform);
            }

        }
    }

}
