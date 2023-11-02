using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreenAudio : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
       
        audioSource = GetComponent<AudioSource>();

        
        audioSource.Play();
    }
}
