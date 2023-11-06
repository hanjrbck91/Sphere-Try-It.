using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlignObjects : MonoBehaviour
{
    public GameObject[] objectAlign;
    [SerializeField] private float spacing = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < objectAlign.Length; i++)
        {
            objectAlign[i].transform.position = new Vector3 (i * spacing, 0f, 0f);
        }
    }
}
