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

    public GameObject postTestLock;
    public GameObject writeLock;
    public GameObject pronounceLock;
    public GameObject arrangeLock;

    public GameObject bgMusicOn;
    public GameObject bgMusicOff;

    public GameObject deleteUserObject;

    public GameObject noDeleteBtn;
    public GameObject yesDeleteBtn;

    public GameObject deleteLoading;

    public GameObject signoutUserObject;

    public GameObject noSignOutBtn;
    public GameObject yesSignOutBtn;

    public GameObject signoutLoading;

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

        postTestLock.SetActive(false);
        writeLock.SetActive(false);
        pronounceLock.SetActive(false);
        arrangeLock.SetActive(false);

        deleteUserObject.SetActive(false);

        signoutUserObject.SetActive(false);

        //noDeleteBtn.SetActive(true);
        //yesDeleteBtn.SetActive(true);

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

        int tempBGMusic = PlayerPrefs.GetInt("backgroundMusicSetting");

        // 1 means OFF
        // 0 means ON
        if (tempBGMusic == 0)
        {
            bgMusicOff.SetActive(false);
            bgMusicOn.SetActive(true);
        }
        else if (tempBGMusic == 1)
        {
            bgMusicOff.SetActive(true);
            bgMusicOn.SetActive(false);
        }

        playerNameText.text = playerName;
        expPointsText.text = playerExpPoints.ToString() + " Points Earned";

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
            postTestLock.SetActive(true);
            postTestScoreText.text = "Locked";
        }

        // --- For Write Modules ------------------------------------
        if (playerExpPoints >= requiredPointsForLevels.forPL1 * pointsMultiplier)
        {
            writeCheckObject.SetActive(true);
        }

        if (playerPreTestDone == 0)
        {
            writeLock.SetActive(true);
        }

        // --- For Pronounce Modules ------------------------------------
        if (playerExpPoints >= requiredPointsForLevels.forARR1 * pointsMultiplier)
        {
            pronounceCheckObject.SetActive(true);
        }

        if (playerExpPoints < requiredPointsForLevels.forPL1 * pointsMultiplier)
        {
            pronounceLock.SetActive(true);
        }

        // --- For Arrange Modules ------------------------------------
        if (playerExpPoints >= requiredPointsForLevels.forPostTest * pointsMultiplier)
        {
            arrangeCheckObject.SetActive(true);
        }

        if (playerExpPoints < requiredPointsForLevels.forARR1 * pointsMultiplier)
        {
            arrangeLock.SetActive(true);
        }

    }

    public void ShowSignOutObject (int num)
    {
        gameManager.buttonSoundEffect.Play();
        if (num == 1)
        {
            signoutUserObject.SetActive(true);
            signoutLoading.SetActive(false);
            noSignOutBtn.SetActive(true);
            yesSignOutBtn.SetActive(true);
        }

        if (num == 0)
        {
            signoutUserObject.SetActive(false);
        }
    }

    public void SignOutConfirm ()
    {
        gameManager.buttonSoundEffect.Play();
        noSignOutBtn.SetActive(false);
        yesSignOutBtn.SetActive(false);

        signoutLoading.SetActive(true);


        StartCoroutine(SignoutDelayUser());
    }

    public IEnumerator SignoutDelayUser()
    {
        yield return new WaitForSeconds(2f);
        playerPrefStats.playerPrefID = 0;
        // * * * Go Back in the Opening Page
        gameManager.pageNumber = 0;
        gameManager.mainPageNumber = 1;
    }

    public void ShowDeleteUserObject (int num)
    {
        gameManager.buttonSoundEffect.Play();
        if (num == 1)
        {
            deleteUserObject.SetActive(true);
            deleteLoading.SetActive(false);
            noDeleteBtn.SetActive(true);
            yesDeleteBtn.SetActive(true);
        }

        if (num == 0)
        {
            deleteUserObject.SetActive(false);
        }
    }

    public void DeleteUserConfirm ()
    {
        gameManager.buttonSoundEffect.Play();
        noDeleteBtn.SetActive(false);
        yesDeleteBtn.SetActive(false);

        deleteLoading.SetActive(true);

        StartCoroutine(DeleteDelayUser());
    }

    public IEnumerator DeleteDelayUser ()
    {
        yield return new WaitForSeconds(2f);

        if (playerPrefStats.playerPrefID == 1)
        {
            PlayerPrefs.SetString("playerPrefUser1", "");

            PlayerPrefs.SetInt("playerPrefUserExperiencePoints1", 0);

            PlayerPrefs.SetInt("playerPrefUserPreTestScore1", 0);
            PlayerPrefs.SetInt("playerPrefUserPreTestDone1", 0);

            PlayerPrefs.SetInt("playerPrefUserPostTestScore1", 0);
            PlayerPrefs.SetInt("playerPrefUserPostTestDone1", 0);
        }
        else if (playerPrefStats.playerPrefID == 2)
        {
            PlayerPrefs.SetString("playerPrefUser2", "");

            PlayerPrefs.SetInt("playerPrefUserExperiencePoints2", 0);

            PlayerPrefs.SetInt("playerPrefUserPreTestScore2", 0);
            PlayerPrefs.SetInt("playerPrefUserPreTestDone2", 0);

            PlayerPrefs.SetInt("playerPrefUserPostTestScore2", 0);
            PlayerPrefs.SetInt("playerPrefUserPostTestDone2", 0);
        }
        else if (playerPrefStats.playerPrefID == 3)
        {
            PlayerPrefs.SetString("playerPrefUser3", "");

            PlayerPrefs.SetInt("playerPrefUserExperiencePoints3", 0);

            PlayerPrefs.SetInt("playerPrefUserPreTestScore3", 0);
            PlayerPrefs.SetInt("playerPrefUserPreTestDone3", 0);

            PlayerPrefs.SetInt("playerPrefUserPostTestScore3", 0);
            PlayerPrefs.SetInt("playerPrefUserPostTestDone3", 0);
        }

        playerPrefStats.playerPrefID = 0;
        // * * * Go Back in the Opening Page
        gameManager.pageNumber = 0;
        gameManager.mainPageNumber = 1;
    }

    public void SwitchBGMusic ()
    {
        gameManager.buttonSoundEffect.Play();
        int tempBGMusic = PlayerPrefs.GetInt("backgroundMusicSetting");

        // 1 means OFF
        // 0 means ON
        if (tempBGMusic == 0)
        {
            bgMusicOff.SetActive(true);
            bgMusicOn.SetActive(false);
            PlayerPrefs.SetInt("backgroundMusicSetting", 1);
        }
        else if (tempBGMusic == 1)
        {
            bgMusicOff.SetActive(false);
            bgMusicOn.SetActive(true);
            PlayerPrefs.SetInt("backgroundMusicSetting", 0);
        }
    }

    public void ShowPageButton (string type)
    {
        if (type == "pretest")
        {
            gameManager.buttonSoundEffect.Play();
            mainPageScript.showUser.SetActive(false);
            gameManager.pageNumber = 6;
        }
        else if (type == "posttest")
        {
            if (playerExpPoints >= requiredPointsForLevels.forPostTest * pointsMultiplier)
            {
                gameManager.buttonSoundEffect.Play();
                mainPageScript.showUser.SetActive(false);
                gameManager.pageNumber = 7;
            }
        }
        else if (type == "write")
        {
            if (playerPreTestDone == 1)
            {
                gameManager.buttonSoundEffect.Play();
                mainPageScript.showUser.SetActive(false);
                gameManager.mainPageNumber = 2;
            }
        }
        else if (type == "pronounce")
        {
            if (playerExpPoints >= requiredPointsForLevels.forPL1 * pointsMultiplier)
            {
                gameManager.buttonSoundEffect.Play();
                mainPageScript.showUser.SetActive(false);
                gameManager.mainPageNumber = 3;
            }
        }
        else if (type == "arrange")
        {
            if (playerExpPoints >= requiredPointsForLevels.forARR1 * pointsMultiplier)
            {
                gameManager.buttonSoundEffect.Play();
                mainPageScript.showUser.SetActive(false);
                gameManager.mainPageNumber = 9;
            }
        }
    }


}
