using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWin : MonoBehaviour
{
    private Animator anim;
    public GameObject youwin;
    public Button resetButton;

    public Button nextLevel;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ship"))
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            GetComponent<Rigidbody2D>().velocity = new Vector2(0 , 0);
            anim.SetTrigger("win");
            youwin.SetActive(true);
            resetButton.GetComponent<Button>().enabled = false;
            resetButton.GetComponent<Image>().color = Color.gray;
            nextLevel.GetComponent<Button>().enabled = true;
        }
    }
}
