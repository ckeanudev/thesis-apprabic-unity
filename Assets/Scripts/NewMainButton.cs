using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMainButton : MonoBehaviour
{
    public string buttonType;
    public int requiredPoints;
    public GameObject lockScreen;
    public GameObject ribbonIcon;
    public GameObject handPointIcon;

    PlayerStats playerPrefStats;
    public GameObject playerPrefS;

    GameManager gameManager;
    public GameObject gameM;

    RequiredPointsForLevels requiredPointsForLevels;
    public GameObject requiredPointsS;

    // Player Stats
    int playerExperiencePoints = 0;

    int playerPreTestScore = 0;
    int playerPostTestScore = 0;

    int playerArrangeProgress = 0;

    private void Awake()
    {
        playerPrefStats = playerPrefS.GetComponent<PlayerStats>();
        gameManager = gameM.GetComponent<GameManager>();
        requiredPointsForLevels = requiredPointsS.GetComponent<RequiredPointsForLevels>();
    }

    private void OnEnable()
    {
        lockScreen.SetActive(false);
        ribbonIcon.SetActive(false);
        handPointIcon.SetActive(false);

        if(playerPrefStats.playerPrefID == 1)
        {
            playerExperiencePoints = PlayerPrefs.GetInt("playerPrefUserExperiencePoints1");

            playerPreTestScore = PlayerPrefs.GetInt("playerPrefUserPreTestScore1");
            playerPostTestScore = PlayerPrefs.GetInt("playerPrefUserPostTestScore1");
        }
        else if (playerPrefStats.playerPrefID == 2)
        {
            playerExperiencePoints = PlayerPrefs.GetInt("playerPrefUserExperiencePoints2");

            playerPreTestScore = PlayerPrefs.GetInt("playerPrefUserPreTestScore2");
            playerPostTestScore = PlayerPrefs.GetInt("playerPrefUserPostTestScore2");
        }
        else if (playerPrefStats.playerPrefID == 3)
        {
            playerExperiencePoints = PlayerPrefs.GetInt("playerPrefUserExperiencePoints3");

            playerPreTestScore = PlayerPrefs.GetInt("playerPrefUserPreTestScore3");
            playerPostTestScore = PlayerPrefs.GetInt("playerPrefUserPostTestScore3");
        }

        // *** For Lock & Point & Ribbon Icon ---------------------------------

        // * For Test Button ---------------------------------
        if (buttonType == "test" && playerPreTestScore == 0)
        {
            handPointIcon.SetActive(true);
        }

        // * For Pre Test Button ---------------------------------
        if (buttonType == "pretest" && playerPreTestScore == 0)
        {
            handPointIcon.SetActive(true);
        }

        if (buttonType == "pretest" && playerPreTestScore > 0)
        {
            ribbonIcon.SetActive(true);
        }

        // * For Post Test Button ---------------------------------
        if (buttonType == "posttest" && playerPreTestScore > 0)
        {
            //handPointIcon.SetActive(true);
        }

        if (buttonType == "posttest" && playerPostTestScore > 0)
        {
            ribbonIcon.SetActive(true);
        }

        // * For Write Button ---------------------------------
        if (buttonType == "write" && playerPreTestScore > 0)
        {
            handPointIcon.SetActive(true);
        }

        if(buttonType == "write" && playerPreTestScore == 0)
        {
            lockScreen.SetActive(true);
        }

        if (buttonType == "write letters" && playerPreTestScore > 0)
        {
            handPointIcon.SetActive(true);
        }

        // * For Pronounce Button ---------------------------------


    }

    public void ShowPage()
    {
        // For Test --------------------------------------------------
        if (buttonType == "test")
        {
            gameManager.mainPageNumber = 8;
        }

        if (buttonType == "pretest")
        {
            gameManager.pageNumber = 6;
        }

        if (buttonType == "posttest")
        {
            gameManager.pageNumber = 7;
        }

        // For Write --------------------------------------------------
        if (buttonType == "write")
        {
            gameManager.mainPageNumber = 2;
        }

        if (buttonType == "write letters")
        {
            gameManager.mainPageNumber = 4;
        }

        if (buttonType == "write numbers")
        {
            gameManager.mainPageNumber = 5;
        }

        // For Pronounce --------------------------------------------------
        if (buttonType == "pronounce")
        {
            gameManager.mainPageNumber = 3;
        }

        if (buttonType == "pronounce letters")
        {
            gameManager.mainPageNumber = 6;
        }

        if (buttonType == "pronounce numbers")
        {
            gameManager.mainPageNumber = 7;
        }

        // For Arrange --------------------------------------------------
        if (buttonType == "arrange")
        {
            gameManager.mainPageNumber = 9;
        }


    }

}
