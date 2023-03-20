using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PreTestScript : MonoBehaviour
{
    public string testType;

    public TextMeshProUGUI testOrderText;

    public GameObject showTutorial1;
    public GameObject showTutorial2;
    public GameObject showTutorial3;

    bool showAllTutorial = true;

    public GameObject test1;
    public GameObject test2;
    public GameObject test3;
    public GameObject test4;
    public GameObject test5;
    public GameObject test6;
    public GameObject test7;
    public GameObject test8;
    public GameObject test9;
    public GameObject test10;
    public GameObject test11;
    public GameObject test12;
    public GameObject test13;
    public GameObject test14;
    public GameObject test15;
    public GameObject testResult;

    public GameObject orderCircle;

    PlayerStats playerPrefStats;
    public GameObject playerPrefS;

    GameManager gameManager;
    public GameObject gameM;

    public int testNumber = 0;
    public int testScore = 0;

    int playerPreTestScore = 0;
    int playerPreTestDone = 0;

    int playerPostTestScore = 0;
    int playerPostTestDone = 0;

    private void Awake ()
    {
        // *** ---- the Awake function will be call when the page wakes and it will get the components with a scripts ---- *** //

        playerPrefStats = playerPrefS.GetComponent<PlayerStats>();
        gameManager = gameM.GetComponent<GameManager>();
    }

    private void OnEnable ()
    {
        // *** ---- the OnEnable function will be call when the page loads and it will check if the users has already did the test and if not it will display the tests ---- *** //

        playerPrefStats = playerPrefS.GetComponent<PlayerStats>();
        gameManager = gameM.GetComponent<GameManager>();

        test1.SetActive(false);
        test2.SetActive(false);
        test3.SetActive(false);
        test4.SetActive(false);
        test5.SetActive(false);
        test6.SetActive(false);
        test7.SetActive(false);
        test8.SetActive(false);
        test9.SetActive(false);
        test10.SetActive(false);
        test11.SetActive(false);
        test12.SetActive(false);
        test13.SetActive(false);
        test14.SetActive(false);
        test15.SetActive(false);
        testResult.SetActive(false);

        if (showTutorial1 != null)
            showTutorial1.SetActive(false);

        if (showTutorial2 != null)
            showTutorial2.SetActive(false);

        if (showTutorial3 != null)
            showTutorial3.SetActive(false);

        if (playerPrefStats.playerPrefID == 1)
        {
            playerPreTestScore = PlayerPrefs.GetInt("playerPrefUserPreTestScore1");
            playerPreTestDone = PlayerPrefs.GetInt("playerPrefUserPreTestDone1");

            playerPostTestScore = PlayerPrefs.GetInt("playerPrefUserPostTestScore1");
            playerPostTestDone = PlayerPrefs.GetInt("playerPrefUserPostTestDone1");
        }
        else if (playerPrefStats.playerPrefID == 2)
        {
            playerPreTestScore = PlayerPrefs.GetInt("playerPrefUserPreTestScore2");
            playerPreTestDone = PlayerPrefs.GetInt("playerPrefUserPreTestDone2");

            playerPostTestScore = PlayerPrefs.GetInt("playerPrefUserPostTestScore2");
            playerPostTestDone = PlayerPrefs.GetInt("playerPrefUserPostTestDone2");

        }
        else if (playerPrefStats.playerPrefID == 3)
        {
            playerPreTestScore = PlayerPrefs.GetInt("playerPrefUserPreTestScore3");
            playerPreTestDone = PlayerPrefs.GetInt("playerPrefUserPreTestDone3");

            playerPostTestScore = PlayerPrefs.GetInt("playerPrefUserPostTestScore3");
            playerPostTestDone = PlayerPrefs.GetInt("playerPrefUserPostTestDone3");
        }

        if (testType == "pretest")
        {
            if (playerPreTestDone == 1)
            {
                testScore = playerPreTestScore;
                testNumber = 16;
            }

            if (playerPreTestDone == 0)
            {
                testScore = 0;
                testNumber = 1;
            }
        }
        else if (testType == "posttest")
        {
            if (playerPostTestDone == 1)
            {
                testScore = playerPostTestScore;
                testNumber = 16;
            }

            if (playerPostTestDone == 0)
            {
                testScore = 0;
                testNumber = 1;
            }
        }
    }

    public void CloseTutorial1 ()
    {
        // *** ---- the CloseTutorial1 function will be call when the user close the tutorial video ---- *** //

        gameManager.buttonSoundEffect.Play();
        showAllTutorial = false;
        showTutorial1.SetActive(false);
    }

    public void CloseTutorial2()
    {
        // *** ---- the CloseTutorial2 function will be call when the user close the tutorial video ---- *** //

        gameManager.buttonSoundEffect.Play();
        showAllTutorial = false;
        showTutorial2.SetActive(false);
    }

    public void CloseTutorial3()
    {
        // *** ---- the CloseTutorial3 function will be call when the user close the tutorial video ---- *** //

        gameManager.buttonSoundEffect.Play();
        showAllTutorial = false;
        showTutorial3.SetActive(false);
    }

    public void NextTest(int score)
    {
        // *** ---- the NextTest function will be call when the user proceed to the next test and it will score if the user gets the correct answer ---- *** //

        gameManager.buttonSoundEffect.Play();

        testNumber += 1;
        testScore += score;

        if (playerPrefStats.playerPrefID == 1)
        {
            if (testType == "pretest")
                PlayerPrefs.SetInt("playerPrefUserPreTestScore1", testScore);
            else if (testType == "posttest")
                PlayerPrefs.SetInt("playerPrefUserPostTestScore1", testScore);
        }
        else if (playerPrefStats.playerPrefID == 2)
        {
            if (testType == "pretest")
                PlayerPrefs.SetInt("playerPrefUserPreTestScore2", testScore);
            else if (testType == "posttest")
                PlayerPrefs.SetInt("playerPrefUserPostTestScore2", testScore);
        }
        else if (playerPrefStats.playerPrefID == 3)
        {
            if (testType == "pretest")
                PlayerPrefs.SetInt("playerPrefUserPreTestScore3", testScore);
            else if (testType == "posttest")
                PlayerPrefs.SetInt("playerPrefUserPostTestScore3", testScore);
        }

        showAllTutorial = true;

        Debug.Log("Test Number: " + testNumber.ToString());
        Debug.Log("Test Score: " + testScore.ToString());
    }

    private void Update()
    {
        // *** ---- the Update function will be call every second to update the test everytime the user proceeds to next test ---- *** //

        if (testNumber < 16)
        {
            testOrderText.text = testNumber.ToString();
            orderCircle.SetActive(true);
        }
        else
        {
            orderCircle.SetActive(false);
        }

        if (testType == "pretest")
        {
            if (testNumber == 1 && showAllTutorial)
            {
                if (showTutorial1 != null)
                    showTutorial1.SetActive(true);
            }

            if (testNumber == 6 && showAllTutorial)
            {
                if (showTutorial2 != null)
                    showTutorial2.SetActive(true);
            }

            if (testNumber == 11 && showAllTutorial)
            {
                if (showTutorial3 != null)
                    showTutorial3.SetActive(true);
            }
        }

        if (testNumber == 1)
        {
            test1.SetActive(true);
            test2.SetActive(false);
            test3.SetActive(false);
            test4.SetActive(false);
            test5.SetActive(false);
            test6.SetActive(false);
            test7.SetActive(false);
            test8.SetActive(false);
            test9.SetActive(false);
            test10.SetActive(false);
            test11.SetActive(false);
            test12.SetActive(false);
            test13.SetActive(false);
            test14.SetActive(false);
            test15.SetActive(false);
            testResult.SetActive(false);
        }
        else if (testNumber == 2)
        {
            test1.SetActive(false);
            test2.SetActive(true);
        }
        else if (testNumber == 3)
        {
            test2.SetActive(false);
            test3.SetActive(true);
        }
        else if (testNumber == 4)
        {
            test3.SetActive(false);
            test4.SetActive(true);
        }
        else if (testNumber == 5)
        {
            test4.SetActive(false);
            test5.SetActive(true);
        }
        else if (testNumber == 6)
        {
            test5.SetActive(false);
            test6.SetActive(true);
        }
        else if (testNumber == 7)
        {
            test6.SetActive(false);
            test7.SetActive(true);
        }
        else if (testNumber == 8)
        {
            test7.SetActive(false);
            test8.SetActive(true);
        }
        else if (testNumber == 9)
        {
            test8.SetActive(false);
            test9.SetActive(true);
        }
        else if (testNumber == 10)
        {
            test9.SetActive(false);
            test10.SetActive(true);
        }
        else if (testNumber == 11)
        {
            test10.SetActive(false);
            test11.SetActive(true);
        }
        else if (testNumber == 12)
        {
            test11.SetActive(false);
            test12.SetActive(true);
        }
        else if (testNumber == 13)
        {
            test12.SetActive(false);
            test13.SetActive(true);
        }
        else if (testNumber == 14)
        {
            test13.SetActive(false);
            test14.SetActive(true);
        }
        else if (testNumber == 15)
        {
            test14.SetActive(false);
            test15.SetActive(true);
        }
        else if (testNumber == 16)
        {
            test15.SetActive(false);
            testResult.SetActive(true);

            if (playerPrefStats.playerPrefID == 1)
            {
                if (testType == "pretest")
                    PlayerPrefs.SetInt("playerPrefUserPreTestDone1", 1);
                else if (testType == "posttest")
                    PlayerPrefs.SetInt("playerPrefUserPostTestDone1", 1);
            }
            else if (playerPrefStats.playerPrefID == 2)
            {
                if (testType == "pretest")
                    PlayerPrefs.SetInt("playerPrefUserPreTestDone2", 1);
                else if (testType == "posttest")
                    PlayerPrefs.SetInt("playerPrefUserPostTestDone2", 1);
            }
            else if (playerPrefStats.playerPrefID == 3)
            {
                if (testType == "pretest")
                    PlayerPrefs.SetInt("playerPrefUserPreTestDone3", 1);
                else if (testType == "posttest")
                    PlayerPrefs.SetInt("playerPrefUserPostTestDone3", 1);
            }
            //Debug.Log(testScore);
        }
    }

}
