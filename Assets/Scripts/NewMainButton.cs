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

    // *** ----- Player Stats
    int playerExperiencePoints = 0;

    int playerPreTestScore = 0;
    int playerPreTestDone = 0;

    int playerPostTestScore = 0;
    int playerPostTestDone = 0;

    int pointsMultiplier = 15;

    private void Awake()
    {
        playerPrefStats = playerPrefS.GetComponent<PlayerStats>();
        gameManager = gameM.GetComponent<GameManager>();
        requiredPointsForLevels = requiredPointsS.GetComponent<RequiredPointsForLevels>();
    }

    private void OnEnable()
    {
        playerPrefStats = playerPrefS.GetComponent<PlayerStats>();
        gameManager = gameM.GetComponent<GameManager>();
        requiredPointsForLevels = requiredPointsS.GetComponent<RequiredPointsForLevels>();

        lockScreen.SetActive(false);
        ribbonIcon.SetActive(false);
        handPointIcon.SetActive(false);

        if(playerPrefStats.playerPrefID == 1)
        {
            playerExperiencePoints = PlayerPrefs.GetInt("playerPrefUserExperiencePoints1");

            playerPreTestScore = PlayerPrefs.GetInt("playerPrefUserPreTestScore1");
            playerPreTestDone = PlayerPrefs.GetInt("playerPrefUserPreTestDone1");

            playerPostTestScore = PlayerPrefs.GetInt("playerPrefUserPostTestScore1");
            playerPostTestDone = PlayerPrefs.GetInt("playerPrefUserPostTestDone1");
        }
        else if (playerPrefStats.playerPrefID == 2)
        {
            playerExperiencePoints = PlayerPrefs.GetInt("playerPrefUserExperiencePoints2");

            playerPreTestScore = PlayerPrefs.GetInt("playerPrefUserPreTestScore2");
            playerPreTestDone = PlayerPrefs.GetInt("playerPrefUserPreTestDone2");

            playerPostTestScore = PlayerPrefs.GetInt("playerPrefUserPostTestScore2");
            playerPostTestDone = PlayerPrefs.GetInt("playerPrefUserPostTestDone2");
        }
        else if (playerPrefStats.playerPrefID == 3)
        {
            playerExperiencePoints = PlayerPrefs.GetInt("playerPrefUserExperiencePoints3");

            playerPreTestScore = PlayerPrefs.GetInt("playerPrefUserPreTestScore3");
            playerPreTestDone = PlayerPrefs.GetInt("playerPrefUserPreTestDone3");

            playerPostTestScore = PlayerPrefs.GetInt("playerPrefUserPostTestScore3");
            playerPostTestDone = PlayerPrefs.GetInt("playerPrefUserPostTestDone3");
        }

        // *** For Lock & Point & Ribbon Icon ---------------------------------

        // * For Test Button ---------------------------------
        if (buttonType == "test" && playerPreTestDone == 0)
        {
            handPointIcon.SetActive(true);
        }

        if (buttonType == "test" && playerExperiencePoints >= requiredPointsForLevels.forPostTest * pointsMultiplier && playerPostTestScore == 0)
        {
            handPointIcon.SetActive(true);
        }

        if (playerPreTestDone == 1 && playerPostTestDone == 1)
        {
            ribbonIcon.SetActive(true);
        }

        // * For Pre Test Button ---------------------------------
        if (buttonType == "pretest" && playerPreTestDone == 0)
        {
            handPointIcon.SetActive(true);
        }

        if (buttonType == "pretest" && playerPreTestDone == 1)
        {
            ribbonIcon.SetActive(true);
        }

        // * For Post Test Button ---------------------------------
        if (buttonType == "posttest" && playerExperiencePoints >= requiredPointsForLevels.forPostTest * pointsMultiplier && playerPostTestDone == 0)
        {
            handPointIcon.SetActive(true);
        }

        if(buttonType == "posttest" && playerExperiencePoints < requiredPointsForLevels.forPostTest * pointsMultiplier)
        {
            lockScreen.SetActive(true);
        }

        if (buttonType == "posttest" && playerPostTestDone == 1)
        {
            ribbonIcon.SetActive(true);
        }

        // * * * For Write Button ------------------------------------------------------------------
        if (buttonType == "write" && playerPreTestDone == 1 && playerExperiencePoints < requiredPointsForLevels.forPL1 * pointsMultiplier)
        {
            handPointIcon.SetActive(true);
        }

        if (buttonType == "write" && playerPreTestDone == 0)
        {
            lockScreen.SetActive(true);
        }

        if (buttonType == "write" && playerExperiencePoints >= requiredPointsForLevels.forPL1 * pointsMultiplier)
        {
            ribbonIcon.SetActive(true);
        }

        // * For Write Letters Button ---------------------------------
        if (buttonType == "write letters" && playerPreTestDone == 1 && playerExperiencePoints < requiredPointsForLevels.forWN1 * pointsMultiplier)
        {
            handPointIcon.SetActive(true);
        }

        if (buttonType == "write letters" && playerExperiencePoints >= requiredPointsForLevels.forWN1 * pointsMultiplier)
        {
            ribbonIcon.SetActive(true);
        }

        // * For Write Numbers Button ---------------------------------
        if (buttonType == "write numbers" && playerExperiencePoints >= requiredPointsForLevels.forWN1 * pointsMultiplier && playerExperiencePoints < requiredPointsForLevels.forPL1 * pointsMultiplier)
        {
            handPointIcon.SetActive(true);
        }

        if (buttonType == "write numbers" && playerExperiencePoints < requiredPointsForLevels.forWN1 * pointsMultiplier)
        {
            lockScreen.SetActive(true);
        }

        if (buttonType == "write numbers" && playerExperiencePoints >= requiredPointsForLevels.forPL1 * pointsMultiplier)
        {
            ribbonIcon.SetActive(true);
        }

        // * * * For Pronounce Button ------------------------------------------------------------------
        if (buttonType == "pronounce" && playerExperiencePoints >= requiredPointsForLevels.forPL1 * pointsMultiplier && playerExperiencePoints < requiredPointsForLevels.forARR1 * pointsMultiplier)
        {
            handPointIcon.SetActive(true);
        }

        if (buttonType == "pronounce" && playerExperiencePoints < requiredPointsForLevels.forPL1 * pointsMultiplier)
        {
            lockScreen.SetActive(true);
        }

        if (buttonType == "pronounce" && playerExperiencePoints >= requiredPointsForLevels.forARR1 * pointsMultiplier)
        {
            ribbonIcon.SetActive(true);
        }

        // * For Pronounce Letters Button ---------------------------------
        if (buttonType == "pronounce letters" && playerExperiencePoints >= requiredPointsForLevels.forPL1 * pointsMultiplier && playerExperiencePoints < requiredPointsForLevels.forPN1 * pointsMultiplier)
        {
            handPointIcon.SetActive(true);
        }

        if (buttonType == "pronounce letters" && playerExperiencePoints >= requiredPointsForLevels.forPN1 * pointsMultiplier)
        {
            ribbonIcon.SetActive(true);
        }

        // * For Pronounce Numbers Button ---------------------------------
        if (buttonType == "pronounce numbers" && playerExperiencePoints >= requiredPointsForLevels.forPN1 * pointsMultiplier && playerExperiencePoints < requiredPointsForLevels.forARR1 * pointsMultiplier)
        {
            handPointIcon.SetActive(true);
        }

        if (buttonType == "pronounce numbers" && playerExperiencePoints < requiredPointsForLevels.forPN1 * pointsMultiplier)
        {
            lockScreen.SetActive(true);
        }

        if (buttonType == "pronounce numbers" && playerExperiencePoints >= requiredPointsForLevels.forARR1 * pointsMultiplier)
        {
            ribbonIcon.SetActive(true);
        }

        // * * * For Arrange Button ------------------------------------------------------------------
        if (buttonType == "arrange" && playerExperiencePoints >= requiredPointsForLevels.forARR1 * pointsMultiplier && playerExperiencePoints < requiredPointsForLevels.forPostTest * pointsMultiplier)
        {
            handPointIcon.SetActive(true);
        }

        if (buttonType == "arrange" && playerExperiencePoints < requiredPointsForLevels.forARR1 * pointsMultiplier)
        {
            lockScreen.SetActive(true);
        }

        if (buttonType == "arrange" && playerExperiencePoints >= requiredPointsForLevels.forPostTest * pointsMultiplier)
        {
            ribbonIcon.SetActive(true);
        }



    }

    public void ShowPage()
    {

        // For Test --------------------------------------------------
        if (buttonType == "test")
        {
            gameManager.buttonSoundEffect.Play();
            gameManager.mainPageNumber = 8;

        }

        if (buttonType == "pretest")
        {
            gameManager.buttonSoundEffect.Play();
            gameManager.pageNumber = 6;
        }

        if (buttonType == "posttest")
        {
            if (buttonType == "posttest" && playerExperiencePoints < requiredPointsForLevels.forPostTest * pointsMultiplier)
            {
                gameManager.lockSoundEffect.Play();
                Debug.Log("Lock");
            }
            else
            {
                gameManager.buttonSoundEffect.Play();
                gameManager.pageNumber = 7;
            }
            //gameManager.buttonSoundEffect.Play();
            //gameManager.pageNumber = 7;
        }

        // For Write --------------------------------------------------
        if (buttonType == "write")
        {
            if (buttonType == "write" && playerPreTestDone == 0)
            {
                gameManager.lockSoundEffect.Play();
                Debug.Log("Lock");
            }
            else
            {
                gameManager.buttonSoundEffect.Play();
                gameManager.mainPageNumber = 2;
            }
            //gameManager.buttonSoundEffect.Play();
            //gameManager.mainPageNumber = 2;
        }

        if (buttonType == "write letters")
        {
            gameManager.buttonSoundEffect.Play();
            gameManager.mainPageNumber = 4;
        }

        if (buttonType == "write numbers")
        {
            if (buttonType == "write numbers" && playerExperiencePoints < requiredPointsForLevels.forWN1 * pointsMultiplier)
            {
                gameManager.lockSoundEffect.Play();
                Debug.Log("Lock");
            }
            else
            {
                gameManager.buttonSoundEffect.Play();
                gameManager.mainPageNumber = 5;
            }
            //gameManager.buttonSoundEffect.Play();
            //gameManager.mainPageNumber = 5;
        }

        // For Pronounce --------------------------------------------------
        if (buttonType == "pronounce")
        {
            if (buttonType == "pronounce" && playerExperiencePoints < requiredPointsForLevels.forPL1 * pointsMultiplier)
            {
                gameManager.lockSoundEffect.Play();
                Debug.Log("Lock");
            }
            else
            {
                gameManager.buttonSoundEffect.Play();
                gameManager.mainPageNumber = 3;
            }
            //gameManager.buttonSoundEffect.Play();
            //gameManager.mainPageNumber = 3;
        }

        if (buttonType == "pronounce letters")
        {
            gameManager.buttonSoundEffect.Play();
            gameManager.mainPageNumber = 6;
        }

        if (buttonType == "pronounce numbers")
        {
            if (buttonType == "pronounce numbers" && playerExperiencePoints < requiredPointsForLevels.forPN1 * pointsMultiplier)
            {
                gameManager.lockSoundEffect.Play();
                Debug.Log("Lock");
            }
            else
            {
                gameManager.buttonSoundEffect.Play();
                gameManager.mainPageNumber = 7;
            }
            //gameManager.buttonSoundEffect.Play();
            //gameManager.mainPageNumber = 7;
        }

        // For Arrange --------------------------------------------------
        if (buttonType == "arrange")
        {
            if (buttonType == "arrange" && playerExperiencePoints < requiredPointsForLevels.forARR1 * pointsMultiplier)
            {
                gameManager.lockSoundEffect.Play();
                Debug.Log("Lock");
            }
            else
            {
                gameManager.buttonSoundEffect.Play();
                gameManager.mainPageNumber = 9;
            }
            //gameManager.buttonSoundEffect.Play();
            //gameManager.mainPageNumber = 9;
        }


    }

}
