using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftBtnHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        PlayerController.left = true;
        PlayerController.right = false;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        PlayerController.left = false;
    }
}
