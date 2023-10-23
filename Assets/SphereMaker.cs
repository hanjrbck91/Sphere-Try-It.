using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMaker : MonoBehaviour
{
    public GameObject sphere;
    public int numberofSpheres;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberofSpheres; i++)
        {
        var duplicateSphere = GameObject.Instantiate(sphere);    
        duplicateSphere.transform.position = new Vector3(i,0,0);

        }
    }

}
