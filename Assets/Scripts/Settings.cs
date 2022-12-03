using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Settings : MonoBehaviour
{
    public TextMeshProUGUI expPointsText;

    GameManager gameManager;
    public GameObject gameM;

    PlayerStats playerPrefStats;
    public GameObject playerPrefS;

    RequiredPointsForLevels requiredPointsForLevels;
    public GameObject requiredPointsS;

    // *** ----- Player Stats
    int playerExperiencePoints = 0;

    //int playerPreTestScore = 0;
    //int playerPreTestDone = 0;

    //int playerPostTestScore = 0;
    //int playerPostTestDone = 0;

    int pointsMultiplier = 15;

    private void Awake()
    {
        gameManager = gameM.GetComponent<GameManager>();
        playerPrefStats = playerPrefS.GetComponent<PlayerStats>();
        requiredPointsForLevels = requiredPointsS.GetComponent<RequiredPointsForLevels>();
    }

    private void OnEnable ()
    {
        if (playerPrefStats.playerPrefID == 1)
        {
            playerExperiencePoints = PlayerPrefs.GetInt("playerPrefUserExperiencePoints1");

            //playerPreTestScore = PlayerPrefs.GetInt("playerPrefUserPreTestScore1");
            //playerPreTestDone = PlayerPrefs.GetInt("playerPrefUserPreTestDone1");

            //playerPostTestScore = PlayerPrefs.GetInt("playerPrefUserPostTestScore1");
            //playerPostTestDone = PlayerPrefs.GetInt("playerPrefUserPostTestDone1");
        }
        else if (playerPrefStats.playerPrefID == 2)
        {
            playerExperiencePoints = PlayerPrefs.GetInt("playerPrefUserExperiencePoints2");

            //playerPreTestScore = PlayerPrefs.GetInt("playerPrefUserPreTestScore2");
            //playerPreTestDone = PlayerPrefs.GetInt("playerPrefUserPreTestDone2");

            //playerPostTestScore = PlayerPrefs.GetInt("playerPrefUserPostTestScore2");
            //playerPostTestDone = PlayerPrefs.GetInt("playerPrefUserPostTestDone2");
        }
        else if (playerPrefStats.playerPrefID == 3)
        {
            playerExperiencePoints = PlayerPrefs.GetInt("playerPrefUserExperiencePoints3");

            //playerPreTestScore = PlayerPrefs.GetInt("playerPrefUserPreTestScore3");
            //playerPreTestDone = PlayerPrefs.GetInt("playerPrefUserPreTestDone3");

            //playerPostTestScore = PlayerPrefs.GetInt("playerPrefUserPostTestScore3");
            //playerPostTestDone = PlayerPrefs.GetInt("playerPrefUserPostTestDone3");
        }

        expPointsText.text = playerExperiencePoints.ToString() + " Points Earned";
    }

    public void StartZero ()
    {
        if (playerPrefStats.playerPrefID == 1)
        {
            PlayerPrefs.SetInt("playerPrefUserExperiencePoints1", 0);

            PlayerPrefs.SetInt("playerPrefUserPreTestScore1", 0);
            PlayerPrefs.SetInt("playerPrefUserPreTestDone1", 0);

            PlayerPrefs.SetInt("playerPrefUserPostTestScore1", 0);
            PlayerPrefs.SetInt("playerPrefUserPostTestDone1", 0);
        }
        else if (playerPrefStats.playerPrefID == 2)
        {
            PlayerPrefs.SetInt("playerPrefUserExperiencePoints2", 0);

            PlayerPrefs.SetInt("playerPrefUserPreTestScore2", 0);
            PlayerPrefs.SetInt("playerPrefUserPreTestDone2", 0);

            PlayerPrefs.SetInt("playerPrefUserPostTestScore2", 0);
            PlayerPrefs.SetInt("playerPrefUserPostTestDone2", 0);
        }
        else if (playerPrefStats.playerPrefID == 3)
        {
            PlayerPrefs.SetInt("playerPrefUserExperiencePoints3", 0);

            PlayerPrefs.SetInt("playerPrefUserPreTestScore3", 0);
            PlayerPrefs.SetInt("playerPrefUserPreTestDone3", 0);

            PlayerPrefs.SetInt("playerPrefUserPostTestScore3", 0);
            PlayerPrefs.SetInt("playerPrefUserPostTestDone3", 0);
        }
    }

    public void WriteFinished ()
    {
        int tempData = requiredPointsForLevels.forPL1 * pointsMultiplier;

        if (playerPrefStats.playerPrefID == 1)
        {
            PlayerPrefs.SetInt("playerPrefUserExperiencePoints1", tempData);
        }
        else if (playerPrefStats.playerPrefID == 2)
        {
            PlayerPrefs.SetInt("playerPrefUserExperiencePoints2", tempData);
        }
        else if (playerPrefStats.playerPrefID == 3)
        {
            PlayerPrefs.SetInt("playerPrefUserExperiencePoints3", tempData);
        }
    }

    public void PronounceFinished()
    {
        int tempData = requiredPointsForLevels.forARR1 * pointsMultiplier;

        if (playerPrefStats.playerPrefID == 1)
        {
            PlayerPrefs.SetInt("playerPrefUserExperiencePoints1", tempData);
        }
        else if (playerPrefStats.playerPrefID == 2)
        {
            PlayerPrefs.SetInt("playerPrefUserExperiencePoints2", tempData);
        }
        else if (playerPrefStats.playerPrefID == 3)
        {
            PlayerPrefs.SetInt("playerPrefUserExperiencePoints3", tempData);
        }
    }

    public void ArrangeFinished()
    {
        int tempData = requiredPointsForLevels.forPostTest * pointsMultiplier;

        if (playerPrefStats.playerPrefID == 1)
        {
            PlayerPrefs.SetInt("playerPrefUserExperiencePoints1", tempData);
        }
        else if (playerPrefStats.playerPrefID == 2)
        {
            PlayerPrefs.SetInt("playerPrefUserExperiencePoints2", tempData);
        }
        else if (playerPrefStats.playerPrefID == 3)
        {
            PlayerPrefs.SetInt("playerPrefUserExperiencePoints3", tempData);
        }
    }

    private void Update ()
    {
        if (playerPrefStats.playerPrefID == 1)
        {
            playerExperiencePoints = PlayerPrefs.GetInt("playerPrefUserExperiencePoints1");
        }
        else if (playerPrefStats.playerPrefID == 2)
        {
            playerExperiencePoints = PlayerPrefs.GetInt("playerPrefUserExperiencePoints2");
        }
        else if (playerPrefStats.playerPrefID == 3)
        {
            playerExperiencePoints = PlayerPrefs.GetInt("playerPrefUserExperiencePoints3");
        }

        expPointsText.text = playerExperiencePoints.ToString() + " Points Earned";
    }


}
