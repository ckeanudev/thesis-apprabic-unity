using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowUserScript : MonoBehaviour
{
    public TextMeshProUGUI playerNameText;
    public TextMeshProUGUI expPointsText;

    public TextMeshProUGUI preTestScoreText;
    public TextMeshProUGUI postTestScoreText;

    public GameObject preTestRibbonObject;
    public GameObject postTestRibbonObject;

    public GameObject writeCheckObject;
    public GameObject pronounceCheckObject;
    public GameObject arrangeCheckObject;

    PlayerStats playerPrefStats;
    public GameObject playerPrefS;

    RequiredPointsForLevels requiredPointsForLevels;
    public GameObject requiredPointsS;

    GameManager gameManager;
    public GameObject gameM;

    MainPageScript mainPageScript;
    public GameObject mainPageS;


    string playerName;
    int playerExpPoints;

    int playerPreTestScore;
    int playerPreTestDone = 0;

    int playerPostTestScore;
    int playerPostTestDone = 0;

    int pointsMultiplier = 15;

    private void Awake()
    {
        playerPrefStats = playerPrefS.GetComponent<PlayerStats>();
        requiredPointsForLevels = requiredPointsS.GetComponent<RequiredPointsForLevels>();
        gameManager = gameM.GetComponent<GameManager>();
        mainPageScript = mainPageS.GetComponent<MainPageScript>();
    }

    private void OnEnable()
    {
        playerPrefStats = playerPrefS.GetComponent<PlayerStats>();
        requiredPointsForLevels = requiredPointsS.GetComponent<RequiredPointsForLevels>();
        gameManager = gameM.GetComponent<GameManager>();
        mainPageScript = mainPageS.GetComponent<MainPageScript>();

        preTestRibbonObject.SetActive(false);
        postTestRibbonObject.SetActive(false);

        writeCheckObject.SetActive(false);
        pronounceCheckObject.SetActive(false);
        arrangeCheckObject.SetActive(false);

        if (playerPrefStats.playerPrefID == 1)
        {
            playerName = PlayerPrefs.GetString("playerPrefUser1");
            playerExpPoints = PlayerPrefs.GetInt("playerPrefUserExperiencePoints1");

            playerPreTestScore = PlayerPrefs.GetInt("playerPrefUserPreTestScore1");
            playerPreTestDone = PlayerPrefs.GetInt("playerPrefUserPreTestDone1");

            playerPostTestScore = PlayerPrefs.GetInt("playerPrefUserPostTestScore1");
            playerPostTestDone = PlayerPrefs.GetInt("playerPrefUserPostTestDone1");
        }
        else if (playerPrefStats.playerPrefID == 2)
        {
            playerName = PlayerPrefs.GetString("playerPrefUser2");
            playerExpPoints = PlayerPrefs.GetInt("playerPrefUserExperiencePoints2");

            playerPreTestScore = PlayerPrefs.GetInt("playerPrefUserPreTestScore2");
            playerPreTestDone = PlayerPrefs.GetInt("playerPrefUserPreTestDone2");

            playerPostTestScore = PlayerPrefs.GetInt("playerPrefUserPostTestScore2");
            playerPostTestDone = PlayerPrefs.GetInt("playerPrefUserPostTestDone2");
        }
        else if (playerPrefStats.playerPrefID == 3)
        {
            playerName = PlayerPrefs.GetString("playerPrefUser3");
            playerExpPoints = PlayerPrefs.GetInt("playerPrefUserExperiencePoints3");

            playerPreTestScore = PlayerPrefs.GetInt("playerPrefUserPreTestScore3");
            playerPreTestDone = PlayerPrefs.GetInt("playerPrefUserPreTestDone3");

            playerPostTestScore = PlayerPrefs.GetInt("playerPrefUserPostTestScore3");
            playerPostTestDone = PlayerPrefs.GetInt("playerPrefUserPostTestDone3");
        }

        // *** ------------------------------------ *** ------------------------------------
        Debug.Log("Player Name: " + playerName);
        Debug.Log("Player Points: " + playerExpPoints.ToString());
        
        Debug.Log("Player Pre Test Score: " + playerPreTestScore.ToString());
        Debug.Log("Player Pre Test Done: " + playerPreTestDone.ToString());


        playerNameText.text = playerName;
        expPointsText.text = playerExpPoints.ToString() + " Points";

        // --- For Pre Test ------------------------------------
        if (playerPreTestDone == 1)
        {
            preTestRibbonObject.SetActive(true);
            if (playerPreTestScore < 10)
                preTestScoreText.text = "0" + playerPreTestScore.ToString() + "/15";
            else
                preTestScoreText.text = playerPreTestScore.ToString() + "/15";
        } 
        else if (playerPreTestDone == 0)
        {
            preTestScoreText.text = "Take Now";
        }

        // --- For Post Test ------------------------------------
        if (playerExpPoints >= requiredPointsForLevels.forPostTest * pointsMultiplier)
        {
            if (playerPostTestDone == 1)
            {
                postTestRibbonObject.SetActive(true);
                if (playerPostTestScore < 10)
                    postTestScoreText.text = "0" + playerPostTestScore.ToString() + "/15";
                else
                    postTestScoreText.text = playerPostTestScore.ToString() + "/15";
            }
            else if (playerPostTestDone == 0)
            {
                postTestScoreText.text = "Take Now";
            }
        }
        else
        {
            postTestScoreText.text = "Locked";
        }

        // --- For Write Modules ------------------------------------
        if (playerExpPoints >= requiredPointsForLevels.forPL1 * pointsMultiplier)
        {
            writeCheckObject.SetActive(true);
        }

        // --- For Pronounce Modules ------------------------------------
        if (playerExpPoints >= requiredPointsForLevels.forARR1 * pointsMultiplier)
        {
            pronounceCheckObject.SetActive(true);
        }

        // --- For Arrange Modules ------------------------------------
        if (playerExpPoints >= requiredPointsForLevels.forPostTest * pointsMultiplier)
        {
            arrangeCheckObject.SetActive(true);
        }

    }

    public void ShowPageButton (string type)
    {
        if (type == "pretest")
        {
            mainPageScript.showUser.SetActive(false);
            gameManager.pageNumber = 6;
        }
        else if (type == "posttest")
        {
            if (playerExpPoints >= requiredPointsForLevels.forPostTest * pointsMultiplier)
            {
                mainPageScript.showUser.SetActive(false);
                gameManager.pageNumber = 7;
            }
        }
        else if (type == "write")
        {
            if (playerPreTestScore > 0)
            {
                mainPageScript.showUser.SetActive(false);
                gameManager.mainPageNumber = 2;
            }
        }
        else if (type == "pronounce")
        {
            if (playerExpPoints >= requiredPointsForLevels.forPL1 * pointsMultiplier)
            {
                mainPageScript.showUser.SetActive(false);
                gameManager.mainPageNumber = 3;
            }
        }
        else if (type == "arrange")
        {
            if (playerExpPoints >= requiredPointsForLevels.forARR1 * pointsMultiplier)
            {
                mainPageScript.showUser.SetActive(false);
                gameManager.mainPageNumber = 9;
            }
        }
    }


}