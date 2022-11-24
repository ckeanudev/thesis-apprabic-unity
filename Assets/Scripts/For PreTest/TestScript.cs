using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TestScript : MonoBehaviour
{
    PreTestScript preTestScript;
    public GameObject preTestS;

    public string testCategory;

    public string option1;
    public string option2;
    public string option3;

    public TextMeshProUGUI optionText1;
    public TextMeshProUGUI optionText2;
    public TextMeshProUGUI optionText3;

    public AudioSource firstAudio;
    public AudioSource secondAudio;
    public AudioSource thirdAudio;

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

    public GameObject nextButton;

    private void Start()
    {
        preTestScript = preTestS.GetComponent<PreTestScript>();

        if (option1 != "" || option1 != null)
        {
            optionText1.text = option1;
        }

        if(testCategory != "C")
        {
            if (option2 != "" || option2 != null)
            {
                optionText2.text = option2;
            }

            if (option3 != "" || option3 != null)
            {
                optionText3.text = option3;
            }
        }
    }

    public void PlayAudio(int audio)
    {
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

    public void ArrangeContinueBtn()
    {
        preTestScript.testNumber += 1;

        if (firstPosition && secondPosition && thirdPosition && fourthPosition && fifthPosition)
        {
            preTestScript.testScore += 1;
        }

        Debug.Log("Test Number: " + preTestScript.testNumber.ToString());
        Debug.Log("Test Score: " + preTestScript.testScore.ToString());

        Debug.Log("1st POS: " + firstPosition + ", 2nd POS: " + secondPosition + ", 3rd POS: " + thirdPosition + ", 4th POS: " + fourthPosition + ", 5th POS: " + fifthPosition);
    }
}
