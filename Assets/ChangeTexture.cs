using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTexture : MonoBehaviour
{
    // Renderers
    public Renderer cubeRenderer;
    public Renderer planeRenderer;
    public Renderer sphereRenderer;

    // Materials
    public Material woodMaterial;
    public Material brickMaterial;

    // Button Identification
    public bool isCubeButton;
    public bool isPlaneButton;
    public bool isSphereButton;

    // Object Status
    private bool cubeWood = true;
    private bool planeWood = true;
    private bool sphereWood = true;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(ChangeMaterial);
    }

    void ChangeMaterial()
    {
        // Cube
        if (isCubeButton)
        {
            if (cubeWood)
                cubeRenderer.material = brickMaterial;
            else
                cubeRenderer.material = woodMaterial;

            cubeWood = !cubeWood;
        }

        // Plane
        else if (isPlaneButton)
        {
            if (planeWood)
                planeRenderer.material = brickMaterial;
            else
                planeRenderer.material = woodMaterial;

            planeWood = !planeWood;
        }

        // Sphere
        else if (isSphereButton)
        {
            if (sphereWood)
                sphereRenderer.material = brickMaterial;
            else
                sphereRenderer.material = woodMaterial;

            sphereWood = !sphereWood;
        }
    }
}