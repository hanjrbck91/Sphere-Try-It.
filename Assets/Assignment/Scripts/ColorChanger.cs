using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision object is a sphere
        if (collision.gameObject.CompareTag("Sphere"))
        {
            // Get the sphere's renderer component
            Renderer sphereRenderer = collision.collider.GetComponent<Renderer>();

            // Check if the sphereRenderer is not null to avoid potential errors
            if (sphereRenderer != null)
            {
                // Get the color of the colliding sphere
                Color sphereColor = sphereRenderer.material.color;

                // Get the cube's renderer component
                Renderer cubeRenderer = GetComponent<Renderer>();

                // Check if the cubeRenderer is not null to avoid potential errors
                if (cubeRenderer != null)
                {
                    // Change the cube's color to the color of the colliding sphere
                    cubeRenderer.material.color = sphereColor;
                }
            }
        }
    }
}
