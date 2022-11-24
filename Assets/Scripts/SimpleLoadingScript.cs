using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleLoadingScript : MonoBehaviour
{
    public RectTransform _mainIcon;
    public float _timeStep;
    public float _oneStepAngle;

    float _startTime;

    void OnEnable()
    {
        _startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - _startTime >= _timeStep)
        {
            Vector3 iconAngle = _mainIcon.localEulerAngles;
            iconAngle.z += _oneStepAngle;

            _mainIcon.localEulerAngles = iconAngle;

            _startTime = Time.time;
        }
    }
}
