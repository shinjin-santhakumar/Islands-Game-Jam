using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoButton : MonoBehaviour
{

    public Button _GoButton;
    public GameObject player;
    public GameObject playerchild;

    public GameObject bigblocker;
    // Start is called before the first frame update
    void Start()
    {
        _GoButton.onClick.AddListener(TaskOnClick);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {

        player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        player.GetComponent<Rigidbody2D>().velocity = new Vector2(3 , 0);
        player.GetComponent<BoxCollider2D>().enabled = true;
        playerchild.GetComponent<BoxCollider2D>().enabled = true;
        playerchild.transform.Rotate(0, 0, 0);

        _GoButton.GetComponent<Button>().enabled = false;
        _GoButton.GetComponent<Image>().color = Color.gray;

        bigblocker.SetActive(true);
    }

}
