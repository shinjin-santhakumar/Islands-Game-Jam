using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
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
        _GoButton.GetComponent<Button>().enabled = true;
        _ResetButton.GetComponent<Button>().enabled = true;
        _GoButton.GetComponent<Image>().color = Color.green;
        Door.GetComponent<SpriteRenderer>().enabled = true;
        Door.GetComponent<BoxCollider2D>().enabled = true;
        Key.GetComponent<SpriteRenderer>().enabled = true;
        Key.GetComponent<BoxCollider2D>().enabled = true;
        Shadow.transform.position = position_shadow;

    }

}
