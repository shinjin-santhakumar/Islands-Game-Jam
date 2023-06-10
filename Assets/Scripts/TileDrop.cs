using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TileDrop : MonoBehaviour, IDropHandler
{



    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("On drop");

        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition; 
        }
    }
}
