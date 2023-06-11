using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BGDrop : MonoBehaviour, IDropHandler
{
    private Vector2 positionDown;
    private Vector2 positionUp;
    private Vector2 positionRight;
    private Vector2 positionLeft;

    //public RectTransform defaultAnchoredPos;
    //

    private void Start()
    {
        positionDown = GameObject.FindGameObjectWithTag("Down").GetComponent<RectTransform>().anchoredPosition;
        positionUp = GameObject.FindGameObjectWithTag("Up").GetComponent<RectTransform>().anchoredPosition;
        positionRight = GameObject.FindGameObjectWithTag("Right").GetComponent<RectTransform>().anchoredPosition;
        positionLeft = GameObject.FindGameObjectWithTag("Left").GetComponent<RectTransform>().anchoredPosition;
    }

    private void Awake()
    {
        //defaultAnchoredPos = defaultAnchoredPos.GetComponent<RectTransform>();
        //Debug.Log("On drop");
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerDrag);

        // if (eventData.pointerDrag != null)
        // {
        //     eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = defaultAnchoredPos.anchoredPosition;
        // }
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.CompareTag("Down"))
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = positionDown;
            }
            else if (eventData.pointerDrag.CompareTag("Up"))
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = positionUp;
            }
            else if (eventData.pointerDrag.CompareTag("Right"))
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = positionRight;
            }
            else if (eventData.pointerDrag.CompareTag("Left"))
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = positionLeft;
            }
        }
        
    }
}
