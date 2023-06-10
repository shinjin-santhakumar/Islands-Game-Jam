using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnims : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.x > 0.001)
        {
            anim.SetTrigger("go_right");
        }
        else if (rb.velocity.x < -0.001)
        {
            anim.SetTrigger("go_left");
        }
        else if (rb.velocity.y < -0.001)
        {
            anim.SetTrigger("go_down");
        }
        else if (rb.velocity.y > 0.001)
        {
            anim.SetTrigger("go_up");
        }
    }
}
