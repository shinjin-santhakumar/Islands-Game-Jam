using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public GameObject Door;

    SpriteRenderer sr;
    BoxCollider2D bc;
    public AudioClip key_Pickup;
    private void Start()
    {

        sr = GetComponent<SpriteRenderer>();
        bc = GetComponent<BoxCollider2D>();
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = key_Pickup;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerChild"))
        {
            GetComponent<AudioSource>().Play();
            Door.GetComponent<Animator>().SetTrigger("door_open");
            Door.GetComponent<BoxCollider2D>().enabled = false;
            sr.enabled = false;
            bc.enabled = false;
        }
      
    }
    
}
