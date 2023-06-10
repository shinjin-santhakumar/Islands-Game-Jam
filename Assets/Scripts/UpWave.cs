using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpWave : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Do something else here");
        if (other.CompareTag("Player") )
        {
            StartCoroutine(WaitCo(other));
            
        }
    }

    IEnumerator WaitCo(Collider2D other)
    {
        yield return new WaitForSeconds(0.33f);
        other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 3);

    }

}
