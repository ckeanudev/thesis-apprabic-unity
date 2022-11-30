using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrange : MonoBehaviour
{
    public GameObject firstPage;
    public GameObject secondPage;

    public bool firstPosition = false;
    public bool secondPosition = false;
    public bool thirdPosition = false;
    public bool fourthPosition = false;
    public bool fifthPosition = false;

    public bool firstPosFill = false;
    public bool secondPosFill = false;
    public bool thirdPosFill = false;
    public bool fourthPosFill = false;
    public bool fifthPosFill = false;

    ArrangeUIScript arrangeUIScript;
    public GameObject arrangeUIS;

    public GameObject doneButton;

    float currentTime = 0;
    float currentTimeStop = 0;
    bool isTimerStart = false;
    bool isTimerStop = false;

    void OnEnable()
    {
        arrangeUIScript = arrangeUIS.GetComponent<ArrangeUIScript>();

        currentTime = 0;

        firstPage.SetActive(true);
        secondPage.SetActive(false);

        doneButton.SetActive(true);
        StartCoroutine(ShowSecondPage());
    }

    public IEnumerator ShowSecondPage()
    {
        yield return new WaitForSeconds(3f);
        firstPage.SetActive(false);
        secondPage.SetActive(true);
        timerStartFunction();
    }

    public void ArrangeDoneButton()
    {
        timerStopFunction();
        doneButton.SetActive(false);

        if (firstPosition && secondPosition && thirdPosition && fourthPosition && fifthPosition)
        {
            //Debug.Log("All Position Fixed!!");
            arrangeUIScript.showWinDialog = true;
            arrangeUIScript.delayOnce = true;
            arrangeUIScript.userAnswer = true;
        }
        else
        {
            arrangeUIScript.showWinDialog = true;
            arrangeUIScript.delayOnce = true;
            arrangeUIScript.userAnswer = false;
        }

        firstPosFill = false;
        secondPosFill = false;
        thirdPosFill = false;
        fourthPosFill = false;
        fifthPosFill = false;

        firstPosition = false;
        secondPosition = false;
        thirdPosition = false;
        fourthPosition = false;
        fifthPosition = false;
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

            if (currentTimeStop <= 8)
            {
                //Debug.Log("3 Stars");
                arrangeUIScript.userScore = 3;
            }
            else if (currentTimeStop > 8 && currentTimeStop <= 13)
            {
                //Debug.Log("2 Stars");
                arrangeUIScript.userScore = 2;
            }
            else if (currentTimeStop > 13)
            {
                //Debug.Log("1 Stars");
                arrangeUIScript.userScore = 1;
            }
        }
    }

}
