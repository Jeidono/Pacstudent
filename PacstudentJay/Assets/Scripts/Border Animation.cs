using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderAnimation : MonoBehaviour
{
    public GameObject pelletPrefab;
    public Transform titleTransform;

    public int numberOfPellets = 20;
    public float radius = 2f;
    public float rotationSpeed = 50f;

    void Start()
    {
        for (int i = 0; i < numberOfPellets; i++)
        {
            float angle = i * 2 * Mathf.PI / numberOfPellets;
            Vector3 offset = new Vector3(Mathf.Cos(angle) * radius, Mathf.Sin(angle) * radius, 0);
            GameObject pellet = Instantiate(pelletPrefab, titleTransform.position + offset, Quaternion.identity);
            pellet.transform.parent = transform;
        }
    }

    void Update()
    {
       
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
