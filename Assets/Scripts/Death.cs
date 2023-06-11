using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{

    private Animator anim;

    public GameObject shadow;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //display game over/restart


        if (collision.CompareTag("Shark"))
        {

            Destroy(collision.gameObject);
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            GetComponent<Rigidbody2D>().velocity = new Vector2(0 , 0);
            anim.SetTrigger("sharked");

            shadow.GetComponent<SpriteRenderer>().enabled = false;
        }

        if (collision.CompareTag("Rock") || collision.CompareTag("Door"))
        {
            //stop player movement
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            GetComponent<Rigidbody2D>().velocity = new Vector2(0 , 0);

            bool rightBool = anim.GetBool("go_right");
            bool leftBool = anim.GetBool("go_left");
            bool upBool = anim.GetBool("go_up");
            bool downBool = anim.GetBool("go_down");

            if (leftBool)
            {
                anim.SetTrigger("fall_left");
            }
            else if (upBool)
            {
                anim.SetTrigger("fall_up");
            }
            else if (downBool)
            {
                anim.SetTrigger("fall_down");
            }
            else
            {
                anim.SetTrigger("fall_right");
            }

            shadow.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

}
