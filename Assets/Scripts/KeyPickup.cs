using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public GameObject Door;

    SpriteRenderer sr;
    BoxCollider2D bc;
    
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        bc = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Door.GetComponent<SpriteRenderer>().enabled = false;
            Door.GetComponent<BoxCollider2D>().enabled = false;
            sr.enabled = false;
            bc.enabled = false;
        }
    }
    
}
