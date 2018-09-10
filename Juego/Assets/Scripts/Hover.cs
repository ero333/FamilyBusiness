using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

    public static bool onhover = false;
    public Text text;
   

    public void OnPointerEnter(PointerEventData eventData)
    {
        onhover = true;
        text.color = Color.cyan;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        onhover = false;
        text.color = Color.white;
    }

}
