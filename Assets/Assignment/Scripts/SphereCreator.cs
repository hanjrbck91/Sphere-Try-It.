using System.Collections;
using UnityEngine;

public class SphereCreator : MonoBehaviour
{
    public int numberOfSpheres;
    public GameObject spherePrefab;

    private void Start()
    {
        for (int i = 0; i < numberOfSpheres; i++)
        {
            CreateSphere();
        }

        InvokeRepeating("CreateSphere", 7f, .5f); // Create a new sphere every 10 seconds after the initial spheres are created
    }

    void CreateSphere()
    {
        // Generate random positions within a range
        Vector3 spherePosition = new Vector3(Random.Range(-8f, 8f), Random.Range(5f, 10f), 0f);

        // Generate random color
        Color sphereColor;
        int randomColorIndex = Random.Range(0, 3);
        switch (randomColorIndex)
        {
            case 0:
                sphereColor = Color.red;
                break;

            case 1:
                sphereColor = Color.green;
                break;

            case 2:
                sphereColor = Color.blue;
                break;

            default:
                sphereColor = Color.white;
                break;
        }

        GameObject newSphere = Instantiate(spherePrefab, spherePosition, Quaternion.identity);
        Renderer sphereRenderer = newSphere.GetComponent<Renderer>();
        sphereRenderer.material.color = sphereColor;

        // Schedule the destruction of the new sphere after 7 seconds
        Destroy(newSphere, 9);
    }
}
