using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostTitleScreenAnimation : MonoBehaviour
{
    public float amplitude = 0.5f; 
    public float speed = 1f; 

    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
       
        float verticalOffset = Mathf.Sin(Time.time * speed) * amplitude;
        Vector3 newPosition = initialPosition + new Vector3(0f, verticalOffset, 0f);
        transform.position = newPosition;
    }
}
