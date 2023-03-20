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

    public AudioSource buttonSoundEffect;

    float currentTime = 0;
    float currentTimeStop = 0;
    bool isTimerStart = false;
    bool isTimerStop = false;

    void OnEnable()
    {
        // *** ---- the OnEnable function will be call when the page load ---- *** //

        arrangeUIScript = arrangeUIS.GetComponent<ArrangeUIScript>();

        currentTime = 0;

        firstPage.SetActive(true);
        secondPage.SetActive(false);

        doneButton.SetActive(true);
        StartCoroutine(ShowSecondPage());
    }

    public IEnumerator ShowSecondPage()
    {
        // *** ---- the ShowSecondPage function will be call when the OnEnable function was called and it will display the correct arrangement of the given letters or numbers for 3 seconds ---- *** //

        yield return new WaitForSeconds(3f);
        firstPage.SetActive(false);
        secondPage.SetActive(true);
        timerStartFunction();
    }

    public void ArrangeDoneButton()
    {
        // *** ---- This ArrangeDoneButton function will be call if the user is done arranging the given letters or number ---- *** //

        buttonSoundEffect.Play();
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
        // *** ---- the timerStartFunction function will be call when the chosen level starts ---- *** //

        isTimerStart = true;
        isTimerStop = false;
    }

    public void timerStopFunction()
    {
        // *** ---- the timerStopFunction function will be call when the chosen level has ended ---- *** //

        isTimerStart = false;
        isTimerStop = true;
    }

    void Update()
    {
        // *** ---- the Update function will be call when the current page loads for every seconds ---- *** //

        // *** ---- the function below were checking if the timer is running or stopped and it will give the score to the user depends on how fast the user finish the level ---- *** //

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
