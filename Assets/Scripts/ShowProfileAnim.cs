using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowProfileAnim : MonoBehaviour
{
    public float amp;
    public float freq;
    Vector3 initPos;

    void OnEnable()
    {
        initPos = transform.position;
    }

    void Update()
    {
        //transform.position = new Vector3(initPos.x, Mathf.Sin(Time.time * freq) * amp + initPos.y, 0);
        transform.position = new Vector3(Mathf.Sin(Time.time * freq) * amp + initPos.x,  initPos.y, 0);
    }
}
