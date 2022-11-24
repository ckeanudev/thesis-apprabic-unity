using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WinPanelScript : MonoBehaviour
{
    public TextMeshProUGUI winText; 
    public TextMeshProUGUI pointsOblong;

    public string typeMode;
    public string winType;

    WritingUIScript writingUIScript;
    public GameObject writingUIS;

    PronouneUIScript pronouneUIScript;
    public GameObject pronouneUIS;

    ArrangeUIScript arrangeUIScript;
    public GameObject arrangeUIS;

    public GameObject banner1Star;
    public GameObject banner2Star;
    public GameObject banner3Star;
    
    string[] winDialog = new string[4];

    void OnEnable()
    {
        if (typeMode == "writing")
        {
            writingUIScript = writingUIS.GetComponent<WritingUIScript>();
        }
        else if (typeMode == "pronunciation")
        {
            pronouneUIScript = pronouneUIS.GetComponent<PronouneUIScript>();
        }
        else if (typeMode == "arrange")
        {
            arrangeUIScript = arrangeUIS.GetComponent<ArrangeUIScript>();
        }

        int num = Random.Range(0, 4);

        if (winType == "win")
        {

            winDialog[0] = "Great Job!";
            winDialog[1] = "Well Done!";
            winDialog[2] = "Nice One!";
            winDialog[3] = "Nice Work!";

            Debug.Log(winDialog[num]);

            winText.text = winDialog[num];

            if (typeMode == "writing")
            {
                if (writingUIScript.userScore == 3)
                {
                    pointsOblong.text = "+10 points";
                    banner3Star.SetActive(true);
                    banner2Star.SetActive(false);
                    banner1Star.SetActive(false);
                }
                else if (writingUIScript.userScore == 2)
                {
                    pointsOblong.text = "+7 points";
                    banner3Star.SetActive(false);
                    banner2Star.SetActive(true);
                    banner1Star.SetActive(false);
                }
                else if (writingUIScript.userScore == 1)
                {
                    pointsOblong.text = "+3 points";
                    banner3Star.SetActive(false);
                    banner2Star.SetActive(false);
                    banner1Star.SetActive(true);
                }
            }
            else if (typeMode == "pronunciation")
            {
                Debug.Log("Your Score: " + pronouneUIScript.userScore.ToString());
                if (pronouneUIScript.userScore == 3)
                {
                    pointsOblong.text = "+10 points";
                    banner3Star.SetActive(true);
                    banner2Star.SetActive(false);
                    banner1Star.SetActive(false);
                }
                else if (pronouneUIScript.userScore == 2)
                {
                    pointsOblong.text = "+7 points";
                    banner3Star.SetActive(false);
                    banner2Star.SetActive(true);
                    banner1Star.SetActive(false);
                }
                else if (pronouneUIScript.userScore == 1)
                {
                    pointsOblong.text = "+3 points";
                    banner3Star.SetActive(false);
                    banner2Star.SetActive(false);
                    banner1Star.SetActive(true);
                }
            }
            else if (typeMode == "arrange")
            {
                if (arrangeUIScript.userScore == 3)
                {
                    pointsOblong.text = "+10 points";
                    banner3Star.SetActive(true);
                    banner2Star.SetActive(false);
                    banner1Star.SetActive(false);
                }
                else if (arrangeUIScript.userScore == 2)
                {
                    pointsOblong.text = "+7 points";
                    banner3Star.SetActive(false);
                    banner2Star.SetActive(true);
                    banner1Star.SetActive(false);
                }
                else if (arrangeUIScript.userScore == 1)
                {
                    pointsOblong.text = "+3 points";
                    banner3Star.SetActive(false);
                    banner2Star.SetActive(false);
                    banner1Star.SetActive(true);
                }
            }
        }
        else if (winType == "unwin")
        {

            winDialog[0] = "Try Again";
            winDialog[1] = "Almost";
            winDialog[2] = "Nice One!";
            winDialog[3] = "Nice Work!";

            //Debug.Log("Try Again");

            winText.text = "Try Again";
        }

    }
}
