using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TestResults : MonoBehaviour
{
    public GameObject loadingPage;
    public GameObject testResultPage;

    PreTestScript preTestScript;
    public GameObject preTestS;

    public TextMeshProUGUI testScoreText;

    string scoreString = "";

    private void OnEnable()
    {
        preTestScript = preTestS.GetComponent<PreTestScript>();

        loadingPage.SetActive(true);
        testResultPage.SetActive(false);
        StartCoroutine(ShowResult());
    }

    public IEnumerator ShowResult()
    {
        Debug.Log(preTestScript.testScore);

        string tempString = "";

        if (preTestScript.testScore < 10)
        {
            tempString = preTestScript.testScore.ToString();
            scoreString = "0" + tempString + "/15";
        }
        else
        {
            tempString = preTestScript.testScore.ToString();
            scoreString = tempString + "/15";
        }

        yield return new WaitForSeconds(1f);
        loadingPage.SetActive(false);
        testResultPage.SetActive(true);
        testScoreText.text = scoreString;
    }

}
