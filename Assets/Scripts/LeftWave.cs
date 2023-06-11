using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWave : MonoBehaviour
{
    public GameObject player;
    public GameObject playerchild;
    public AudioClip waveSound;
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = waveSound;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerChild") )
        {
            GetComponent<AudioSource>().Play();
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(-3, 0);
            playerchild.transform.eulerAngles = new Vector3(0, 0, 180);
            
        }
    }

}