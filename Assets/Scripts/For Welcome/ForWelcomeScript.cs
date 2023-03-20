using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForWelcomeScript : MonoBehaviour
{
    public string typeWelcome;

    public GameObject welcomeObject;

    public GameObject welcomeObject2;
    public GameObject welcomeObject3;

    public AudioSource buttonSoundEffect;

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

    int playerGraduate = 0;

    int pointsMultiplier = 15;

    private void Awake()
    {
        // *** ---- the Awake function will be call when the page wakes and it will get the components with a scripts ---- *** //

        playerPrefStats = playerPrefS.GetComponent<PlayerStats>();
        gameManager = gameM.GetComponent<GameManager>();
        requiredPointsForLevels = requiredPointsS.GetComponent<RequiredPointsForLevels>();
    }

    private void OnEnable()
    {
        // *** ---- the OnEnable function will be call when the page loads and it will check if the user is new or not and it will display an object to welcome the user to the newest level or page ---- *** //

        if (welcomeObject != null)
            welcomeObject.SetActive(false);

        if (welcomeObject2 != null)
            welcomeObject2.SetActive(false);

        if (welcomeObject3 != null)
            welcomeObject3.SetActive(false);

        if (playerPrefStats.playerPrefID == 1)
        {
            playerExperiencePoints = PlayerPrefs.GetInt("playerPrefUserExperiencePoints1");

            playerPreTestScore = PlayerPrefs.GetInt("playerPrefUserPreTestScore1");
            playerPreTestDone = PlayerPrefs.GetInt("playerPrefUserPreTestDone1");

            playerPostTestScore = PlayerPrefs.GetInt("playerPrefUserPostTestScore1");
            playerPostTestDone = PlayerPrefs.GetInt("playerPrefUserPostTestDone1");

            playerGraduate = PlayerPrefs.GetInt("playerPrefUserGraduate1");
        }
        else if (playerPrefStats.playerPrefID == 2)
        {
            playerExperiencePoints = PlayerPrefs.GetInt("playerPrefUserExperiencePoints2");

            playerPreTestScore = PlayerPrefs.GetInt("playerPrefUserPreTestScore2");
            playerPreTestDone = PlayerPrefs.GetInt("playerPrefUserPreTestDone2");

            playerPostTestScore = PlayerPrefs.GetInt("playerPrefUserPostTestScore2");
            playerPostTestDone = PlayerPrefs.GetInt("playerPrefUserPostTestDone2");

            playerGraduate = PlayerPrefs.GetInt("playerPrefUserGraduate2");
        }
        else if (playerPrefStats.playerPrefID == 3)
        {
            playerExperiencePoints = PlayerPrefs.GetInt("playerPrefUserExperiencePoints3");

            playerPreTestScore = PlayerPrefs.GetInt("playerPrefUserPreTestScore3");
            playerPreTestDone = PlayerPrefs.GetInt("playerPrefUserPreTestDone3");

            playerPostTestScore = PlayerPrefs.GetInt("playerPrefUserPostTestScore3");
            playerPostTestDone = PlayerPrefs.GetInt("playerPrefUserPostTestDone3");

            playerGraduate = PlayerPrefs.GetInt("playerPrefUserGraduate3");
        }

        if (typeWelcome == "main menu")
        {
            if (playerPreTestDone == 0)
            {
                welcomeObject.SetActive(true);
            }

            if (playerExperiencePoints >= requiredPointsForLevels.forPostTest * pointsMultiplier && playerPostTestDone == 0)
            {
                welcomeObject2.SetActive(true);
            }

            if (playerPostTestDone == 1 && playerGraduate == 0)
            {
                welcomeObject3.SetActive(true);
            }
        }

        if (typeWelcome == "test")
        {
            if (playerPreTestDone == 0)
            {
                welcomeObject.SetActive(true);
            }

            if (playerExperiencePoints >= requiredPointsForLevels.forPostTest * pointsMultiplier && playerPostTestDone == 0)
            {
                welcomeObject2.SetActive(true);
            }

            if (playerPreTestDone == 1 && playerExperiencePoints == 0)
            {
                welcomeObject3.SetActive(true);
            }
        }


        if (typeWelcome == "write" && playerPreTestDone == 1 && playerExperiencePoints == 0)
        {
            if (welcomeObject != null) 
                welcomeObject.SetActive(true);
        }

        if (typeWelcome == "pronounce" && playerExperiencePoints >= requiredPointsForLevels.forPL1 * pointsMultiplier && playerExperiencePoints < requiredPointsForLevels.forPL2 * pointsMultiplier)
        {
            if (welcomeObject != null) 
                welcomeObject.SetActive(true);
        }

        if (typeWelcome == "arrange" && playerExperiencePoints >= requiredPointsForLevels.forARR1 * pointsMultiplier && playerExperiencePoints < requiredPointsForLevels.forARR2 * pointsMultiplier)
        {
            gameManager.stopBGMusicForTuts = true;
            if (welcomeObject != null) 
                welcomeObject.SetActive(true);
        }

        if (typeWelcome == "write play" && playerPreTestDone == 1 && playerExperiencePoints == 0)
        {
            gameManager.stopBGMusicForTuts = true;
            if (welcomeObject != null)
                welcomeObject.SetActive(true);
        }

        if (typeWelcome == "pronounce play" && playerExperiencePoints >= requiredPointsForLevels.forPL1 * pointsMultiplier && playerExperiencePoints < requiredPointsForLevels.forPL2 * pointsMultiplier)
        {
            gameManager.stopBGMusicForTuts = true;
            if (welcomeObject != null) 
                welcomeObject.SetActive(true);
        }

    }

    public void AfterPreTestButton()
    {
        // *** ---- the AfterPreTestButton function will be call when the user just finished the pretest ---- *** //

        buttonSoundEffect.Play();
        welcomeObject3.SetActive(false);
        gameManager.mainPageNumber = 1;
    }

    public void AfterPostTestButton ()
    {
        // *** ---- the AfterPostTestButton function will be call when the user just finished the posttest ---- *** //

        buttonSoundEffect.Play();
        welcomeObject3.SetActive(false);
        if (playerPrefStats.playerPrefID == 1)
            PlayerPrefs.SetInt("playerPrefUserGraduate1", 1);

        if (playerPrefStats.playerPrefID == 2)
            PlayerPrefs.SetInt("playerPrefUserGraduate2", 1);

        if (playerPrefStats.playerPrefID == 3)
            PlayerPrefs.SetInt("playerPrefUserGraduate3", 1);
    }

    public void CloseWelcomeObject ()
    {
        // *** ---- the CloseWelcomeObject function will be call when the user close the welcome object ---- *** //

        buttonSoundEffect.Play();
        welcomeObject.SetActive(false);
    }

    public void CloseWelcomeObject2()
    {
        // *** ---- the CloseWelcomeObject function will be call when the user close the welcome object 2 ---- *** //

        buttonSoundEffect.Play();
        welcomeObject2.SetActive(false);
    }

    public void CloseWelcomeObject3()
    {
        // *** ---- the CloseWelcomeObject function will be call when the user close the welcome object 3 ---- *** //

        buttonSoundEffect.Play();
        welcomeObject3.SetActive(false);
    }

    public void ShowVideoTuts ()
    {
        // *** ---- the ShowVideoTuts function will be call when the user watch the video tutorial ---- *** //

        buttonSoundEffect.Play();
        gameManager.stopBGMusicForTuts = true;
        if (typeWelcome == "write play" || typeWelcome == "arrange")
        {
            welcomeObject2.SetActive(true);
        }
        else 
        {
            welcomeObject.SetActive(true);
        }
    }

    public void GoBackToLvlBtn ()
    {
        // *** ---- the GoBackToLvlBtn function will be call when the user goes back to the choosing level page ---- *** //

        welcomeObject.SetActive(true);
        welcomeObject2.SetActive(false);
    }

    public void HideVideoTuts()
    {
        // *** ---- the HideVideoTuts function will be call when the user close the video tutorial ---- *** //

        buttonSoundEffect.Play();
        gameManager.stopBGMusicForTuts = false;
        if (typeWelcome == "write play" || typeWelcome == "arrange")
        {
            welcomeObject2.SetActive(false);
        }
        else
        {
            welcomeObject.SetActive(false);
        }
    }



    public void NextTutsBtn()
    {
        // *** ---- the NextTutsBtn function will be call when the user proceed to the next video tutorial ---- *** //

        buttonSoundEffect.Play();
        welcomeObject.SetActive(false);
        welcomeObject2.SetActive(true);
    }

}
