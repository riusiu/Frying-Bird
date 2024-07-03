using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hoge : MonoBehaviour
{
    public void Start()
    {
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        float width = 190;
        float height = 20;

        rectTransform.sizeDelta = new Vector2(width, height);

        Debug.Log("Width: " + rectTransform.sizeDelta.x);    //10
        Debug.Log("Height: " + rectTransform.sizeDelta.y);   //20
    }
    
    
}