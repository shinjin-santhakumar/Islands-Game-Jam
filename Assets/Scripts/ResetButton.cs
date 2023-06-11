using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{

    public Button _ResetButton;
    public Button _GoButton;
    public GameObject player;
    public GameObject Shadow;
    public GameObject Door;
    public GameObject Key;
    public GameObject Spring;
    Vector3 position;
    Vector3 position_shadow;
    // Start is called before the first frame update
    void Start()
    {
        _ResetButton.onClick.AddListener(TaskOnClick);
        position = GameObject.FindGameObjectWithTag("Player").transform.position;
        position_shadow = GameObject.FindGameObjectWithTag("shadow").transform.position;
    }

   
    void TaskOnClick()
    {
        player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        Shadow.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        player.GetComponent<BoxCollider2D>().enabled = false;
        player.transform.position = position;
        player.GetComponent<Animator>().SetTrigger("reset");
        _GoButton.GetComponent<Button>().enabled = true;
        _ResetButton.GetComponent<Button>().enabled = true;
        _GoButton.GetComponent<Image>().color = Color.green;
        Door.GetComponent<SpriteRenderer>().enabled = true;
        Door.GetComponent<BoxCollider2D>().enabled = true;
        Door.GetComponent<Animator>().SetTrigger("door_idle");
        Spring.GetComponent<SpriteRenderer>().enabled = true;
        Spring.GetComponent<BoxCollider2D>().enabled = true;
        Spring.GetComponent<Animator>().SetTrigger("ramp_idle");
        Key.GetComponent<SpriteRenderer>().enabled = true;
        Key.GetComponent<BoxCollider2D>().enabled = true;
        Shadow.transform.position = position_shadow;

    }

}
