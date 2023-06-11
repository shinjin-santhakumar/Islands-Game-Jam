using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upwavetext : MonoBehaviour
{
    // Start is called before the first frame update

    private Text txt;

    void Start()
    {
        txt = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "x " + GameObject.FindGameObjectsWithTag("Down").Length.ToString();
    }
}
