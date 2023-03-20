using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Pronounce : MonoBehaviour
{
    // *** ---- This script is for the Pronounce Level where it has a function to use the audios and to check if the user gets the correct answer ---- *** //

    PronouneUIScript pronouneUIScript;
    public GameObject PronouneUIS;

    public GameObject firstPage;
    public GameObject secondPage;

    public AudioSource origAudio;

    public AudioSource firstAudio;
    public AudioSource secondAudio;
    public AudioSource thirdAudio;

    public GameObject audioContainer1;
    public GameObject audioContainer2;
    public GameObject audioContainer3;

    public GameObject choiceContainer1;
    public GameObject choiceContainer2;
    public GameObject choiceContainer3;

    public AudioSource buttonSoundEffect;

    public int averageCountTime;
    float currentTime = 0;
    float currentTimeStop = 0;
    bool isTimerStart = false;
    bool isTimerStop = false;

    void OnEnable()
    {
        // *** ---- the OnEnable function will be call when the page loads and it will get the components and objects that are necessary for the pronounce module ---- *** //

        int num = Random.Range(1, 4);

        pronouneUIScript = PronouneUIS.GetComponent<PronouneUIScript>();

        currentTime = 0;

        audioContainer1.SetActive(false);
        audioContainer2.SetActive(false);
        audioContainer3.SetActive(false);

        choiceContainer1.SetActive(false);
        choiceContainer2.SetActive(false);
        choiceContainer3.SetActive(false);

        if(num == 1)
        {
            audioContainer1.SetActive(true);
            choiceContainer1.SetActive(true);
        }
        else if (num == 2)
        {
            audioContainer2.SetActive(true);
            choiceContainer2.SetActive(true);
        }
        else if (num == 3)
        {
            audioContainer3.SetActive(true);
            choiceContainer3.SetActive(true);
        }

        firstPage.SetActive(true);
        secondPage.SetActive(false);
    }

    public void NextPage()
    {
        // *** ---- the NextPage function will be call when the user is ready to play the pronounce level and it will start the timer ---- *** //

        buttonSoundEffect.Play();
        firstPage.SetActive(false);
        secondPage.SetActive(true); 
        timerStartFunction();
    }

    public void OrigAudio()
    {
        origAudio.Play();
    }

    public void PlayAudio(int audio)
    {
        // *** ---- the PlayAudio function will be call when the user click the buttons to listen for the correct audio or pronunciation ---- *** //

        if (audio == 1)
        {
            firstAudio.Play();
        }
        else if (audio == 2)
        {
            secondAudio.Play();
        }
        else if (audio == 3)
        {
            thirdAudio.Play();
        }
    }

    public void OptionButtons(int num)
    {
        // *** ---- the OptionButtons function will be call when the user chose the audio and it will stop the timer to check if the user gets the correct pronunciation for the given letter or number ---- *** //

        audioContainer1.SetActive(false);
        choiceContainer1.SetActive(false);
        audioContainer2.SetActive(false);
        choiceContainer2.SetActive(false);
        audioContainer3.SetActive(false);
        choiceContainer3.SetActive(false);

        buttonSoundEffect.Play();
        timerStopFunction();
        if (num == 1)
        {
            //Debug.Log("NICE NICE NICE");
            pronouneUIScript.showWinDialog = true;
            pronouneUIScript.delayOnce = true;
            pronouneUIScript.userAnswer = true;
        }
        else
        {
            //Debug.Log("NICE NICE NICE");
            pronouneUIScript.showWinDialog = true;
            pronouneUIScript.delayOnce = true;
            pronouneUIScript.userAnswer = false;
        }
    }

    public void timerStartFunction()
    {
        // *** ---- the timerStartFunction function will be call when the user start to play and it will start the timer ---- *** //

        currentTime = 0;
        //Debug.Log("Count Start!");
        //Debug.Log(currentTime.ToString());
        isTimerStart = true;
        isTimerStop = false;
    }

    public void timerStopFunction()
    {
        // *** ---- the timerStopFunction function will be call when the user finished and it will stop the timer ---- *** //

        //Debug.Log("Count Stop!");
        isTimerStart = false;
        isTimerStop = true;
    }

    void Update()
    {
        // *** ---- the Update function will be call every second when the page render and it will check the timer and it will display the score of the user ---- *** //

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
                pronouneUIScript.userScore = 3;
            }
            else if (currentTimeStop > 8 && currentTimeStop <= 10)
            {
                //Debug.Log("2 Stars");
                pronouneUIScript.userScore = 2;
            }
            else if (currentTimeStop > 10)
            {
                //Debug.Log("1 Stars");
                pronouneUIScript.userScore = 1;
            }
        }
    }


}
