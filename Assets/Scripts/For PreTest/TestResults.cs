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

    PlayerStats playerPrefStats;
    public GameObject playerPrefS;

    private void OnEnable()
    {
        preTestScript = preTestS.GetComponent<PreTestScript>();
        playerPrefStats = playerPrefS.GetComponent<PlayerStats>();

        loadingPage.SetActive(true);
        testResultPage.SetActive(false);
        StartCoroutine(ShowResult());
    }

    public IEnumerator ShowResult()
    {
        Debug.Log(preTestScript.testScore);

        string tempString = "";

        if (playerPrefStats.playerPrefID == 1)
        {
            Debug.Log("Inside 1!");
            if (preTestScript.testType == "pretest")
                PlayerPrefs.SetInt("playerPrefUserPreTestScore1", preTestScript.testScore);
            else if (preTestScript.testType == "posttest")
                PlayerPrefs.SetInt("playerPrefUserPostTestScore1", preTestScript.testScore);
        }
        else if (playerPrefStats.playerPrefID == 2)
        {
            Debug.Log("Inside 2!");
            if (preTestScript.testType == "pretest")
                PlayerPrefs.SetInt("playerPrefUserPreTestScore2", preTestScript.testScore);
            else if (preTestScript.testType == "posttest")
                PlayerPrefs.SetInt("playerPrefUserPostTestScore2", preTestScript.testScore);
        }
        else if (playerPrefStats.playerPrefID == 3)
        {
            Debug.Log("Inside 3!");
            if (preTestScript.testType == "pretest")
                PlayerPrefs.SetInt("playerPrefUserPreTestScore3", preTestScript.testScore);
            else if (preTestScript.testType == "posttest")
                PlayerPrefs.SetInt("playerPrefUserPostTestScore3", preTestScript.testScore);
        }

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
