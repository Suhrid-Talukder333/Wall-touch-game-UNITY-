using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RightBtnHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        PlayerController.right = true;
        PlayerController.left = false;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        PlayerController.right = false;
    }
}
