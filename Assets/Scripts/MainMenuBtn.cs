using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainMenuBtn : MonoBehaviour
{
    public int pageScene;
    public string modeType;
    public string categoryType;

    public TextMeshProUGUI modeText;
    public TextMeshProUGUI scoreText;

    public GameObject doneRibbon;
    public GameObject lockMode;

    private void Start()
    {
        modeText.text = modeType;

        if (modeType == "Pre-Test")
        {
            scoreText.text = "00/15";
        }
        else if (modeType == "Post-Test")
        {
            scoreText.text = "00/15";
        }
        else if (modeType == "Writing")
        {
            scoreText.text = "00/39";
        }
        else if (modeType == "Pronunciation")
        {
            scoreText.text = "00/39";
        }
        else if (categoryType == "writing alphabets")
        {
            scoreText.text = "00/28";
        }
        else if (categoryType == "writing numbers")
        {
            scoreText.text = "00/11";
        }
        else if (categoryType == "pronunciation alphabets")
        {
            scoreText.text = "00/28";
        }
        else if (categoryType == "pronunciation numbers")
        {
            scoreText.text = "00/11";
        }
    }
}
