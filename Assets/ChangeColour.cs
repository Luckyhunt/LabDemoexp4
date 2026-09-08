using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    // Cube
    public Renderer cubeRenderer;

    // Sphere
    public Renderer sphereRenderer;

    // Plane
    public Renderer planeRenderer;

    // Button Type
    public bool isCubeButton;
    public bool isSphereButton;
    public bool isPlaneButton;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(ChangeObjectColor);
    }

    void ChangeObjectColor()
    {
        Color randomColor = new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            1f);

        if (isCubeButton)
        {
            cubeRenderer.material.color = randomColor;
        }
        else if (isSphereButton)
        {
            sphereRenderer.material.color = randomColor;
        }
        else if (isPlaneButton)
        {
            planeRenderer.material.color = randomColor;
        }
    }
}
