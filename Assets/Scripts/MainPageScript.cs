using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainPageScript : MonoBehaviour
{
    public GameObject mainMenu; //--1
    public GameObject writingMenu; //--2
    public GameObject pronunciationMenu; //--3

    public GameObject writingAlphabets; //--4
    public GameObject writingNumbers; //--5

    public GameObject pronunciationAlphabets; //--6
    public GameObject pronunciationNumbers; //--7

    public GameObject testMenu; //--8
    public GameObject arrangePage; //--9

    public GameObject backButton;
    public TextMeshProUGUI topTitleText;
    public GameObject showUser;
    public GameObject showSetting;

    GameManager gameManager;
    public GameObject gameM;

    PlayerStats playerPrefStats;
    public GameObject playerPrefS;

    RequiredPointsForLevels requiredPointsForLevels;
    public GameObject requiredPointsS;

    // *** ----- Player Stats
    int playerExperiencePoints = 0;

    int playerPreTestScore = 0;
    int playerPreTestDone = 0;

    int playerPostTestScore = 0;
    int playerPostTestDone = 0;

    //int pointsMultiplier = 15;

    private void Awake()
    {
        gameManager = gameM.GetComponent<GameManager>();
        playerPrefStats = playerPrefS.GetComponent<PlayerStats>();
        requiredPointsForLevels = requiredPointsS.GetComponent<RequiredPointsForLevels>();
    }

    private void OnEnable()
    {
        mainMenu.SetActive(false);
        writingMenu.SetActive(false);
        pronunciationMenu.SetActive(false);
        writingAlphabets.SetActive(false);
        writingNumbers.SetActive(false);
        pronunciationAlphabets.SetActive(false);
        pronunciationNumbers.SetActive(false);
        testMenu.SetActive(false);
        arrangePage.SetActive(false);
        showSetting.SetActive(false);
        showUser.SetActive(false);

        backButton.SetActive(false);

        if (playerPrefStats.playerPrefID == 1)
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

        MainPageRender();

        Debug.Log("Current User ID: " + playerPrefStats.playerPrefID.ToString());
    }

    public void ShowPage(int page)
    {
        gameManager.buttonSoundEffect.Play();
        gameManager.mainPageNumber = page;
    }

    public void ShowUser(int show)
    {
        gameManager.buttonSoundEffect.Play();
        if (show == 1)
        {
            showUser.SetActive(true);
        }
        else if (show == 0)
        {
            showUser.SetActive(false);
        }
    }

    public void ShowSetting(int show)
    {
        gameManager.buttonSoundEffect.Play();
        if (show == 1)
        {
            gameManager.mainPageNumber = 10;
        }
        else if (show == 0)
        {
            gameManager.mainPageNumber = 1;
        }
    }

    public void BackPage()
    {
        gameManager.buttonSoundEffect.Play();
        if (gameManager.mainPageNumber == 1)
        {
            return;
        }
        else if (gameManager.mainPageNumber == 2)
        {
            gameManager.mainPageNumber = 1;
        }
        else if (gameManager.mainPageNumber == 3)
        {
            gameManager.mainPageNumber = 1;
        }
        else if (gameManager.mainPageNumber == 4)
        {
            gameManager.mainPageNumber = 2;
        }
        else if (gameManager.mainPageNumber == 5)
        {
            gameManager.mainPageNumber = 2;
        }
        else if (gameManager.mainPageNumber == 6)
        {
            gameManager.mainPageNumber = 3;
        }
        else if (gameManager.mainPageNumber == 7)
        {
            gameManager.mainPageNumber = 3;
        }
        else if (gameManager.mainPageNumber == 8)
        {
            gameManager.mainPageNumber = 1;
        }
        else if (gameManager.mainPageNumber == 9)
        {
            gameManager.mainPageNumber = 1;
        }
    }



    private void Update()
    {
        MainPageRender();


    }

    public void MainPageRender()
    {
        if (gameManager.mainPageNumber == 1)
        {
            mainMenu.SetActive(true);
            writingMenu.SetActive(false);
            pronunciationMenu.SetActive(false);
            writingAlphabets.SetActive(false);
            writingNumbers.SetActive(false);
            pronunciationAlphabets.SetActive(false);
            pronunciationNumbers.SetActive(false);

            showSetting.SetActive(false);

            testMenu.SetActive(false);
            arrangePage.SetActive(false);

            topTitleText.text = "";
            backButton.SetActive(false);
        }
        else if (gameManager.mainPageNumber == 2)
        {
            mainMenu.SetActive(false);
            writingMenu.SetActive(true);
            pronunciationMenu.SetActive(false);
            writingAlphabets.SetActive(false);
            writingNumbers.SetActive(false);
            pronunciationAlphabets.SetActive(false);
            pronunciationNumbers.SetActive(false);

            showSetting.SetActive(false);

            testMenu.SetActive(false);
            arrangePage.SetActive(false);

            topTitleText.text = "Write";
            backButton.SetActive(true);
        }
        else if (gameManager.mainPageNumber == 3)
        {
            mainMenu.SetActive(false);
            writingMenu.SetActive(false);
            pronunciationMenu.SetActive(true);
            writingAlphabets.SetActive(false);
            writingNumbers.SetActive(false);
            pronunciationAlphabets.SetActive(false);
            pronunciationNumbers.SetActive(false);

            showSetting.SetActive(false);

            testMenu.SetActive(false);
            arrangePage.SetActive(false);

            topTitleText.text = "Pronounce";
            backButton.SetActive(true);
        }
        else if (gameManager.mainPageNumber == 4)
        {
            mainMenu.SetActive(false);
            writingMenu.SetActive(false);
            pronunciationMenu.SetActive(false);
            writingAlphabets.SetActive(true);
            writingNumbers.SetActive(false);
            pronunciationAlphabets.SetActive(false);
            pronunciationNumbers.SetActive(false);

            testMenu.SetActive(false);
            arrangePage.SetActive(false);

            topTitleText.text = "Write: Letters";
            backButton.SetActive(true);
        }
        else if (gameManager.mainPageNumber == 5)
        {
            mainMenu.SetActive(false);
            writingMenu.SetActive(false);
            pronunciationMenu.SetActive(false);
            writingAlphabets.SetActive(false);
            writingNumbers.SetActive(true);
            pronunciationAlphabets.SetActive(false);
            pronunciationNumbers.SetActive(false);

            showSetting.SetActive(false);

            testMenu.SetActive(false);
            arrangePage.SetActive(false);

            topTitleText.text = "Write: Numbers";
            backButton.SetActive(true);
        }
        else if (gameManager.mainPageNumber == 6)
        {
            mainMenu.SetActive(false);
            writingMenu.SetActive(false);
            pronunciationMenu.SetActive(false);
            writingAlphabets.SetActive(false);
            writingNumbers.SetActive(false);
            pronunciationAlphabets.SetActive(true);
            pronunciationNumbers.SetActive(false);

            showSetting.SetActive(false);

            testMenu.SetActive(false);
            arrangePage.SetActive(false);

            topTitleText.text = "Pronounce: Letters";
            backButton.SetActive(true);
        }
        else if (gameManager.mainPageNumber == 7)
        {
            mainMenu.SetActive(false);
            writingMenu.SetActive(false);
            pronunciationMenu.SetActive(false);
            writingAlphabets.SetActive(false);
            writingNumbers.SetActive(false);
            pronunciationAlphabets.SetActive(false);
            pronunciationNumbers.SetActive(true);

            showSetting.SetActive(false);

            testMenu.SetActive(false);
            arrangePage.SetActive(false);

            topTitleText.text = "Pronounce: Numbers";
            backButton.SetActive(true);
        }
        else if (gameManager.mainPageNumber == 8)
        {
            mainMenu.SetActive(false);
            writingMenu.SetActive(false);
            pronunciationMenu.SetActive(false);
            writingAlphabets.SetActive(false);
            writingNumbers.SetActive(false);
            pronunciationAlphabets.SetActive(false);
            pronunciationNumbers.SetActive(false);

            showSetting.SetActive(false);

            testMenu.SetActive(true);
            arrangePage.SetActive(false);

            topTitleText.text = "Pre-Test & Post-Test";
            backButton.SetActive(true);
        }
        else if (gameManager.mainPageNumber == 9)
        {
            mainMenu.SetActive(false);
            writingMenu.SetActive(false);
            pronunciationMenu.SetActive(false);
            writingAlphabets.SetActive(false);
            writingNumbers.SetActive(false);
            pronunciationAlphabets.SetActive(false);
            pronunciationNumbers.SetActive(false);

            showSetting.SetActive(false);

            testMenu.SetActive(false);
            arrangePage.SetActive(true);

            topTitleText.text = "Arrange";
            backButton.SetActive(true);
        }
        else if (gameManager.mainPageNumber == 10)
        {
            mainMenu.SetActive(false);
            writingMenu.SetActive(false);
            pronunciationMenu.SetActive(false);
            writingAlphabets.SetActive(false);
            writingNumbers.SetActive(false);
            pronunciationAlphabets.SetActive(false);
            pronunciationNumbers.SetActive(false);

            showSetting.SetActive(true);

            testMenu.SetActive(false);
            arrangePage.SetActive(false);

            topTitleText.text = "Setting";
            backButton.SetActive(true);
        }
    }

}
