using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WinPanelScript : MonoBehaviour
{
    public TextMeshProUGUI winText;
    public TextMeshProUGUI pointsOblong;

    public string typeMode;
    public string typeCategory;

    public string winType;

    WritingUIScript writingUIScript;
    public GameObject writingUIS;

    PronouneUIScript pronouneUIScript;
    public GameObject pronouneUIS;

    ArrangeUIScript arrangeUIScript;
    public GameObject arrangeUIS;

    public GameObject banner1Star;
    public GameObject banner2Star;
    public GameObject banner3Star;

    PlayerStats playerPrefStats;
    public GameObject playerPrefS;

    RequiredPointsForLevels requiredPointsForLevels;
    public GameObject requiredPointsS;

    GameManager gameManager;
    public GameObject gameM;

    string[] winDialog = new string[4];

    int playerExperiencePoints;

    void Awake()
    {
        playerPrefStats = playerPrefS.GetComponent<PlayerStats>();
        requiredPointsForLevels = requiredPointsS.GetComponent<RequiredPointsForLevels>();
        gameManager = gameM.GetComponent<GameManager>();

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
    }

    void OnEnable()
    {
        playerPrefStats = playerPrefS.GetComponent<PlayerStats>();
        requiredPointsForLevels = requiredPointsS.GetComponent<RequiredPointsForLevels>();
        gameManager = gameM.GetComponent<GameManager>();

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

        if (typeMode == "writing")
        {
            writingUIScript = writingUIS.GetComponent<WritingUIScript>();
        }
        else if (typeMode == "pronunciation")
        {
            pronouneUIScript = pronouneUIS.GetComponent<PronouneUIScript>();
        }
        else if (typeMode == "arrange")
        {
            arrangeUIScript = arrangeUIS.GetComponent<ArrangeUIScript>();
        }

        int num = Random.Range(0, 4);

        if (winType == "win")
        {

            winDialog[0] = "Great Job!";
            winDialog[1] = "Well Done!";
            winDialog[2] = "Nice One!";
            winDialog[3] = "Nice Work!";

            winText.text = winDialog[num];

            if (typeMode == "writing")
            {
                Debug.Log("You Scored: " + writingUIScript.userScore.ToString());

                if (typeCategory == "letters")
                    ForWrite("letters");
                else if (typeCategory == "numbers")
                    ForWrite("numbers");
            }
            else if (typeMode == "pronunciation")
            {
                if (typeCategory == "letters")
                    ForPronounce("letters");
                else if (typeCategory == "numbers")
                    ForPronounce("numbers");
            }
            else if (typeMode == "arrange")
            {
                ForArrange();
                //if (arrangeUIScript.userScore == 3)
                //{
                //    pointsOblong.text = "+3 points";
                //    banner3Star.SetActive(true);
                //    banner2Star.SetActive(false);
                //    banner1Star.SetActive(false);
                //}
                //else if (arrangeUIScript.userScore == 2)
                //{
                //    pointsOblong.text = "+2 points";
                //    banner3Star.SetActive(false);
                //    banner2Star.SetActive(true);
                //    banner1Star.SetActive(false);
                //}
                //else if (arrangeUIScript.userScore == 1)
                //{
                //    pointsOblong.text = "+1 points";
                //    banner3Star.SetActive(false);
                //    banner2Star.SetActive(false);
                //    banner1Star.SetActive(true);
                //}
            }
        }
        else if (winType == "unwin")
        {

            winDialog[0] = "Try Again";
            winDialog[1] = "Almost";
            winDialog[2] = "Nice One!";
            winDialog[3] = "Nice Work!";

            winText.text = "Try Again";
        }
    }

    public void ForAddingExperience(int score)
    {
        playerExperiencePoints = playerExperiencePoints + score;

        Debug.Log("My Point Right Now: " + playerExperiencePoints.ToString());

        if (playerPrefStats.playerPrefID == 1)
        {
            PlayerPrefs.SetInt("playerPrefUserExperiencePoints1", playerExperiencePoints);
        }
        else if (playerPrefStats.playerPrefID == 2)
        {
            PlayerPrefs.SetInt("playerPrefUserExperiencePoints2", playerExperiencePoints);
        }
        else if (playerPrefStats.playerPrefID == 3)
        {
            PlayerPrefs.SetInt("playerPrefUserExperiencePoints3", playerExperiencePoints);
        }
    }

    public void ForPlusPointsText(bool add)
    {
        
        if (writingUIScript.userScore == 3)
        {
            if (add)
            {
                pointsOblong.text = "+3 points";
                ForAddingExperience(3);
            }
            else
                pointsOblong.text = "+0 points";

            banner3Star.SetActive(true);
            banner2Star.SetActive(false);
            banner1Star.SetActive(false);
        }
        else if (writingUIScript.userScore == 2)
        {
            if (add)
            {
                pointsOblong.text = "+2 points";
                ForAddingExperience(2);
            }
            else
                pointsOblong.text = "+0 points";

            banner3Star.SetActive(false);
            banner2Star.SetActive(true);
            banner1Star.SetActive(false);
        }
        else if (writingUIScript.userScore == 1)
        {
            if (add)
            {
                pointsOblong.text = "+1 points";
                ForAddingExperience(1);
            }
            else
                pointsOblong.text = "+0 points";

            banner3Star.SetActive(false);
            banner2Star.SetActive(false);
            banner1Star.SetActive(true);
        }
    }

    public void ForWrite(string category)
    {
        int pointsMultiplier = 15;

        if (category == "letters")
        {
            if (gameManager.writingLevel == 1)
        {
            if (playerExperiencePoints >= requiredPointsForLevels.forWL2 * pointsMultiplier)
            {
                ForPlusPointsText(false);
            }
            else if (playerExperiencePoints < requiredPointsForLevels.forWL2 * pointsMultiplier)
            {
                ForPlusPointsText(true);
            }
        }
            else if (gameManager.writingLevel == 2)
        {
            if (playerExperiencePoints >= requiredPointsForLevels.forWL3 * pointsMultiplier)
            {
                ForPlusPointsText(false);
            }
            else if (playerExperiencePoints < requiredPointsForLevels.forWL3 * pointsMultiplier)
            {
                ForPlusPointsText(true);
            }
        }
            else if (gameManager.writingLevel == 3)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL4 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL4 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 4)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL5 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL5 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 5)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL6 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL6 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 6)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL7 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL7 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 7)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL8 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL8 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 8)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL9 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL9 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 9)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL10 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL10 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 10)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL11 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL11 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 11)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL12 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL12 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 12)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL13 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL13 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 13)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL14 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL14 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 14)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL15 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL15 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 15)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL16 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL16 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 16)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL17 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL17 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 17)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL18 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL18 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 18)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL19 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL19 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 19)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL20 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL20 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 20)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL21 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL21 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 21)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL22 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL22 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 22)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL23 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL23 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 23)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL24 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL24 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 24)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL25 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL25 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 25)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL26 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL26 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 26)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL27 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL27 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 27)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWL28 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWL28 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 28)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWN1 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWN1 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
        }
        else if (category == "numbers")
        {
            if (gameManager.writingLevel == 1)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWN2 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWN2 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 2)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWN3 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWN3 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 3)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWN4 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWN4 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 4)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWN5 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWN5 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 5)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWN6 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWN6 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 6)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWN7 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWN7 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 7)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWN8 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWN8 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 8)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWN9 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWN9 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 9)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWN10 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWN10 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 10)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forWN11 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forWN11 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.writingLevel == 11)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL1 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL1 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
        }
    }




    public void ForPronounce(string category)
    {
        int pointsMultiplier = 15;

        if(category == "letters")
        {
            if (gameManager.pronuncationLevel == 1)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL2 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL2 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 2)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL3 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL3 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 3)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL4 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL4 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 4)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL5 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL5 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 5)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL6 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL6 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 6)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL7 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL7 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 7)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL8 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL8 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 8)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL9 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL9 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 9)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL10 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL10 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 10)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL11 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL11 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 11)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL12 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL12 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 12)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL13 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL13 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 13)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL14 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL14 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 14)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL15 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL15 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 15)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL16 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL16 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 16)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL17 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL17 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 17)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL18 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL18 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 18)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL19 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL19 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 19)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL20 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL20 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 20)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL21 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL21 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 21)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL22 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL22 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 22)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL23 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL23 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 23)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL24 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL24 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 24)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL25 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL25 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 25)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL26 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL26 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 26)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL27 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL27 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 27)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPL28 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPL28 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 28)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPN1 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPN1 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
        }
        else if (category == "numbers")
        {
            if (gameManager.pronuncationLevel == 1)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPN2 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPN2 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 2)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPN3 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPN3 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 3)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPN4 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPN4 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 4)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPN5 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPN5 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 5)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPN6 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPN6 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 6)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPN7 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPN7 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 7)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPN8 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPN8 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 8)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPN9 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPN9 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 9)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPN10 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPN10 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 10)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPN11 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forPN11 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
            else if (gameManager.pronuncationLevel == 11)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forARR1 * pointsMultiplier)
                {
                    ForPlusPointsText(false);
                }
                else if (playerExperiencePoints < requiredPointsForLevels.forARR1 * pointsMultiplier)
                {
                    ForPlusPointsText(true);
                }
            }
        }
    }

    public void ForArrange()
    {
        int pointsMultiplier = 15;

        if (gameManager.arrangeLevel == 1)
        {
            if (playerExperiencePoints >= requiredPointsForLevels.forARR2 * pointsMultiplier)
            {
                ForPlusPointsText(false);
            }
            else if (playerExperiencePoints < requiredPointsForLevels.forARR2 * pointsMultiplier)
            {
                ForPlusPointsText(true);
            }
        }
        else if (gameManager.arrangeLevel == 2)
        {
            if (playerExperiencePoints >= requiredPointsForLevels.forARR3 * pointsMultiplier)
            {
                ForPlusPointsText(false);
            }
            else if (playerExperiencePoints < requiredPointsForLevels.forARR3 * pointsMultiplier)
            {
                ForPlusPointsText(true);
            }
        }
        else if (gameManager.arrangeLevel == 3)
        {
            if (playerExperiencePoints >= requiredPointsForLevels.forARR4 * pointsMultiplier)
            {
                ForPlusPointsText(false);
            }
            else if (playerExperiencePoints < requiredPointsForLevels.forARR4 * pointsMultiplier)
            {
                ForPlusPointsText(true);
            }
        }
        else if (gameManager.arrangeLevel == 4)
        {
            if (playerExperiencePoints >= requiredPointsForLevels.forARR5 * pointsMultiplier)
            {
                ForPlusPointsText(false);
            }
            else if (playerExperiencePoints < requiredPointsForLevels.forARR5 * pointsMultiplier)
            {
                ForPlusPointsText(true);
            }
        }
        else if (gameManager.arrangeLevel == 5)
        {
            if (playerExperiencePoints >= requiredPointsForLevels.forARR6 * pointsMultiplier)
            {
                ForPlusPointsText(false);
            }
            else if (playerExperiencePoints < requiredPointsForLevels.forARR6 * pointsMultiplier)
            {
                ForPlusPointsText(true);
            }
        }
        else if (gameManager.arrangeLevel == 6)
        {
            if (playerExperiencePoints >= requiredPointsForLevels.forARR7 * pointsMultiplier)
            {
                ForPlusPointsText(false);
            }
            else if (playerExperiencePoints < requiredPointsForLevels.forARR7 * pointsMultiplier)
            {
                ForPlusPointsText(true);
            }
        }
        else if (gameManager.arrangeLevel == 7)
        {
            if (playerExperiencePoints >= requiredPointsForLevels.forARR8 * pointsMultiplier)
            {
                ForPlusPointsText(false);
            }
            else if (playerExperiencePoints < requiredPointsForLevels.forARR8 * pointsMultiplier)
            {
                ForPlusPointsText(true);
            }
        }
        else if (gameManager.arrangeLevel == 8)
        {
            if (playerExperiencePoints >= requiredPointsForLevels.forARR9 * pointsMultiplier)
            {
                ForPlusPointsText(false);
            }
            else if (playerExperiencePoints < requiredPointsForLevels.forARR9 * pointsMultiplier)
            {
                ForPlusPointsText(true);
            }
        }
        else if (gameManager.arrangeLevel == 9)
        {
            if (playerExperiencePoints >= requiredPointsForLevels.forARR10 * pointsMultiplier)
            {
                ForPlusPointsText(false);
            }
            else if (playerExperiencePoints < requiredPointsForLevels.forARR10 * pointsMultiplier)
            {
                ForPlusPointsText(true);
            }
        }
        else if (gameManager.arrangeLevel == 10)
        {
            if (playerExperiencePoints >= requiredPointsForLevels.forARR11 * pointsMultiplier)
            {
                ForPlusPointsText(false);
            }
            else if (playerExperiencePoints < requiredPointsForLevels.forARR11 * pointsMultiplier)
            {
                ForPlusPointsText(true);
            }
        }
        else if (gameManager.arrangeLevel == 11)
        {
            if (playerExperiencePoints >= requiredPointsForLevels.forARR12 * pointsMultiplier)
            {
                ForPlusPointsText(false);
            }
            else if (playerExperiencePoints < requiredPointsForLevels.forARR12 * pointsMultiplier)
            {
                ForPlusPointsText(true);
            }
        }
        else if (gameManager.arrangeLevel == 12)
        {
            if (playerExperiencePoints >= requiredPointsForLevels.forARR13 * pointsMultiplier)
            {
                ForPlusPointsText(false);
            }
            else if (playerExperiencePoints < requiredPointsForLevels.forARR13 * pointsMultiplier)
            {
                ForPlusPointsText(true);
            }
        }
        else if (gameManager.arrangeLevel == 13)
        {
            if (playerExperiencePoints >= requiredPointsForLevels.forARR14 * pointsMultiplier)
            {
                ForPlusPointsText(false);
            }
            else if (playerExperiencePoints < requiredPointsForLevels.forARR14 * pointsMultiplier)
            {
                ForPlusPointsText(true);
            }
        }
        else if (gameManager.arrangeLevel == 14)
        {
            if (playerExperiencePoints >= requiredPointsForLevels.forARR15 * pointsMultiplier)
            {
                ForPlusPointsText(false);
            }
            else if (playerExperiencePoints < requiredPointsForLevels.forARR15 * pointsMultiplier)
            {
                ForPlusPointsText(true);
            }
        }
        else if (gameManager.arrangeLevel == 15)
        {
            if (playerExperiencePoints >= requiredPointsForLevels.forARR16 * pointsMultiplier)
            {
                ForPlusPointsText(false);
            }
            else if (playerExperiencePoints < requiredPointsForLevels.forARR16 * pointsMultiplier)
            {
                ForPlusPointsText(true);
            }
        }
        else if (gameManager.arrangeLevel == 16)
        {
            if (playerExperiencePoints >= requiredPointsForLevels.forARR17 * pointsMultiplier)
            {
                ForPlusPointsText(false);
            }
            else if (playerExperiencePoints < requiredPointsForLevels.forARR17 * pointsMultiplier)
            {
                ForPlusPointsText(true);
            }
        }
        else if (gameManager.arrangeLevel == 17)
        {
            if (playerExperiencePoints >= requiredPointsForLevels.forARR18 * pointsMultiplier)
            {
                ForPlusPointsText(false);
            }
            else if (playerExperiencePoints < requiredPointsForLevels.forARR18 * pointsMultiplier)
            {
                ForPlusPointsText(true);
            }
        }
        else if (gameManager.arrangeLevel >= 18)
        {
            if (playerExperiencePoints >= requiredPointsForLevels.forPostTest * pointsMultiplier)
            {
                ForPlusPointsText(false);
            }
            else if (playerExperiencePoints < requiredPointsForLevels.forPostTest * pointsMultiplier)
            {
                ForPlusPointsText(true);
            }
        }
    }


}


