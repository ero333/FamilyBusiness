using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

    public static bool onhover = false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        onhover = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        onhover = false;
    }

}
