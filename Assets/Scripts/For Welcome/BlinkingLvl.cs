using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingLvl : MonoBehaviour
{
    public Color startColor = Color.blue;
    public Color endColor = Color.white;
    [Range(0, 10)]
    public float speedBlink = 1;

    //Image imgBlink;

    //private void Awake()
    //{
    //    imgComp = GetComponent<Image>();
    //}

    //private void Update ()
    //{
    //    imgComp.color = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time * speed, 1));
    //}
}
