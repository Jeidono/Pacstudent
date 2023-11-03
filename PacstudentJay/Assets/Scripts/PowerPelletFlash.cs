using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPelletFlash : MonoBehaviour
{
    public float flashInterval = 0.5f; 
    private bool isFlashing = false;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer component not found on the power pellet GameObject.");
            enabled = false; 
        }
        else
        {
            
            InvokeRepeating("ToggleVisibility", 0f, flashInterval);
        }
    }

    private void ToggleVisibility()
    {
        
        spriteRenderer.enabled = !spriteRenderer.enabled;
    }

    
    public void StopFlashing()
    {
        CancelInvoke("ToggleVisibility");
        spriteRenderer.enabled = true; 
    }
}
