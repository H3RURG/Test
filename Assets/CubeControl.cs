using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{

    public Color[] cubeColors;

    private MeshRenderer meshRenderer;
    private int randomColor;
    private float speed;

    private void Awake()
    {
        meshRenderer = gameObject.GetComponent<MeshRenderer>();
        meshRenderer.material.color = cubeColors[Random.Range (0, cubeColors.Length)];

        randomColor = Random.Range(0, cubeColors.Length);
        speed = Random.Range(2, 5);
    }

    private void Update()
    {
        ChangeColor();
    }

    private void ChangeColor ()
    {
        meshRenderer.material.color = Color.Lerp(meshRenderer.material.color, cubeColors[randomColor], Time.deltaTime * speed);

        if (meshRenderer.material.color == cubeColors[randomColor])
            randomColor = Random.Range(0, cubeColors.Length);
    }
}
