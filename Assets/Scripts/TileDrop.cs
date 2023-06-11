using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TileDrop : MonoBehaviour, IDropHandler
{

    private Camera cam;
    private Transform objectTransform;
    private Canvas canvas;


    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("On drop");

        cam = Camera.main;

        canvas = GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<Canvas>();

        if (eventData.pointerDrag != null) {

            print(GetComponent<Transform>().position);

            objectTransform = GetComponent<Transform>();

            Vector3 canvasOffset = canvas.transform.position - objectTransform.position;
            RectTransform rectTransform = objectTransform.GetComponent<RectTransform>();

            // Step 3: Convert the offset to local space
            Vector2 anchoredPosition;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, objectTransform.position + canvasOffset, canvas.worldCamera, out anchoredPosition);


            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = anchoredPosition;
        }
    }

}
