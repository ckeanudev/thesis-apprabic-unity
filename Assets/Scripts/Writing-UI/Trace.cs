using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trace : MonoBehaviour
{
    public int tracingLastPart;

    public GameObject untraceIMG1;
    public GameObject traceIMG1;

    public GameObject untraceIMG2;
    public GameObject traceIMG2;

    public GameObject untraceIMG3;
    public GameObject traceIMG3;

    public GameObject untraceIMG4;
    public GameObject traceIMG4;

    public GameObject tracingPart1;
    public GameObject tracingPart2;
    public GameObject tracingPart3;
    public GameObject tracingPart4;

    WritingUIScript writingUIScript;
    public GameObject writingUIS;

    public int averageCountTime;
    float currentTime = 0;
    float currentTimeStop = 0;
    bool isTimerStart = false;
    bool isTimerStop = false;

    void OnEnable()
    {
        writingUIScript = writingUIS.GetComponent<WritingUIScript>();
        currentTime = 0;
        tracingPart1.SetActive(true);
        untraceIMG1.SetActive(true);
        traceIMG1.SetActive(false);

        // -------------------------------------------------
        if (untraceIMG2 != null)
        {
            untraceIMG2.SetActive(true);
        }
        if (untraceIMG3 != null)
        {
            untraceIMG3.SetActive(true);
        }
        if (untraceIMG4 != null)
        {
            untraceIMG4.SetActive(true);
        }

        // -------------------------------------------------
        if (traceIMG2 != null)
        {
            traceIMG2.SetActive(false);
        }
        if (traceIMG3 != null)
        {
            traceIMG3.SetActive(false);
        }
        if (traceIMG4 != null)
        {
            traceIMG4.SetActive(false);
        }

        // -------------------------------------------------
        if (tracingPart2 != null)
        {
            tracingPart2.SetActive(false);
        }
        if (tracingPart3 != null)
        {
            tracingPart3.SetActive(false);
        }
        if (tracingPart4 != null)
        {
            tracingPart4.SetActive(false);
        }
    }

    public void timerStartFunction()
    {
        //Debug.Log("Count Start!");
        //Debug.Log(currentTime.ToString());
        isTimerStart = true;
        isTimerStop = false;
    }

    public void timerStopFunction()
    {
        //Debug.Log("Count Stop!");
        isTimerStart = false;
        isTimerStop = true;
    }

    void Update()
    {
        if (isTimerStart && !isTimerStop)
        {
            currentTime = currentTime += Time.deltaTime;
        }
        else if (isTimerStop && !isTimerStart)
        {
            currentTimeStop = currentTime;
            //Debug.Log(currentTimeStop.ToString());
            isTimerStop = false;
            isTimerStart = false;
            if (currentTimeStop <= averageCountTime)
            {
                //Debug.Log("3 Stars");
                writingUIScript.userScore = 3;
            }
            else if (currentTimeStop > averageCountTime && currentTimeStop <= averageCountTime + (averageCountTime * 0.8))
            {
                //Debug.Log("2 Stars");
                writingUIScript.userScore = 2;
            }
            else if (currentTimeStop > averageCountTime + (averageCountTime * 0.8))
            {
                //Debug.Log("1 Stars");
                writingUIScript.userScore = 1;
            }
        }
    }

    public void TracingCheck(int tracingPart)
    {
        if (tracingPart == 1)
        {
            untraceIMG1.SetActive(false);
            traceIMG1.SetActive(true);
            tracingPart1.SetActive(false);
            if (tracingPart != tracingLastPart)
            {
                tracingPart2.SetActive(true);
            }
            else
            {
                timerStopFunction();
                //Debug.Log("NICE NICE NICE");
                writingUIScript.showWinDialog = true;
                writingUIScript.delayOnce = true;
            }
        }
        else if (tracingPart == 2)
        {
            untraceIMG2.SetActive(false);
            traceIMG2.SetActive(true);
            tracingPart2.SetActive(false);
            if (tracingPart != tracingLastPart)
            {
                tracingPart3.SetActive(true);
            }
            else
            {
                timerStopFunction();
                //Debug.Log("NICE NICE NICE");
                writingUIScript.showWinDialog = true;
                writingUIScript.delayOnce = true;
            }
        }
        else if (tracingPart == 3)
        {
            untraceIMG3.SetActive(false);
            traceIMG3.SetActive(true);
            tracingPart3.SetActive(false);
            if (tracingPart != tracingLastPart)
            {
                tracingPart4.SetActive(true);
            }
            else
            {
                timerStopFunction();
                //Debug.Log("NICE NICE NICE");
                writingUIScript.showWinDialog = true;
                writingUIScript.delayOnce = true;
            }
        }
        else if (tracingPart == 4)
        {
            untraceIMG4.SetActive(false);
            traceIMG4.SetActive(true);
            tracingPart4.SetActive(false);
            if (tracingPart != tracingLastPart)
            {
                //tracingPart5.SetActive(true);
            }
            else
            {
                timerStopFunction();
                //Debug.Log("NICE NICE NICE");
                writingUIScript.showWinDialog = true;
                writingUIScript.delayOnce = true;
            }
        }
    }
}
