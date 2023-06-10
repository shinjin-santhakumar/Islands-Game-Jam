using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BGDrop : MonoBehaviour, IDropHandler
{

    public RectTransform defaultAnchoredPos;

    private void Awake()
    {
        defaultAnchoredPos = defaultAnchoredPos.GetComponent<RectTransform>();
        Debug.Log("On drop");
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("On drop");

        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = defaultAnchoredPos.anchoredPosition;
        }
        
    }
}
