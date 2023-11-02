using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPellet : MonoBehaviour
{
    public float flashInterval = 0.5f; 

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(Flash());
    }

    private IEnumerator Flash()
    {
        while (true)
        {
            spriteRenderer.enabled = !spriteRenderer.enabled; 
            yield return new WaitForSeconds(flashInterval);
        }
    }
}
