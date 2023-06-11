using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource sound;
    public AudioClip clip;

    public void PlayClick()
    {
        sound.Play();
    }
}
