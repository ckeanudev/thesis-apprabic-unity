using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LvlBtn : MonoBehaviour
{
    public string levelTitle;
    public int levelNumber;
    public string mode;
    public string category;
    public int numberReferenceLevel;

    public TextMeshProUGUI levelTitleText;
    public TextMeshProUGUI levelNumberText;

    public GameObject checkDone;
    public GameObject lockMode;

    GameManager gameManager;
    public GameObject gameM;

    PlayerStats playerPrefStats;
    public GameObject playerPrefS;

    public int pointsUnlock = 0;

    int pointsMultiplier = 15;
    int playerExperiencePoints = 0;

    private void OnEnable()
    {
        lockMode.SetActive(false);
        checkDone.SetActive(false);

        gameManager = gameM.GetComponent<GameManager>();

        playerPrefStats = playerPrefS.GetComponent<PlayerStats>();

        levelTitleText.text = levelTitle;
        levelNumberText.text = levelNumber.ToString();

        int tempLevelref = numberReferenceLevel - 1;

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

        if (tempLevelref == 0)
        {

        }

        if (tempLevelref * pointsMultiplier >= playerExperiencePoints && playerExperiencePoints < numberReferenceLevel * pointsMultiplier)
        {

        }

        if (playerExperiencePoints < tempLevelref * pointsMultiplier)
        {
            lockMode.SetActive(true);
        }

        //if (playerExperiencePoints >= numberReferenceLevel * pointsMultiplier)
        //{
        //    //checkDone.SetActive(true);
        //    lockMode.SetActive(false);
        //}

        if (playerExperiencePoints >= (tempLevelref + 1) * pointsMultiplier)
        {
            checkDone.SetActive(true);
        }


    }

    private void Update ()
    {

    }

    public void LevelButtonContinue()
    {
        if (mode == "writing")
        {
            if(category == "alphabets")
            {
                if(levelNumber == 1)
                {
                    gameManager.SetWritingA("WA-1");
                }
                else if (levelNumber == 2)
                {
                    gameManager.SetWritingA("WA-2");
                }
                else if (levelNumber == 3)
                {
                    gameManager.SetWritingA("WA-3");
                }
                else if (levelNumber == 4)
                {
                    gameManager.SetWritingA("WA-4");
                }
                else if (levelNumber == 5)
                {
                    gameManager.SetWritingA("WA-5");
                }
                else if (levelNumber == 6)
                {
                    gameManager.SetWritingA("WA-6");
                }
                else if (levelNumber == 7)
                {
                    gameManager.SetWritingA("WA-7");
                }
                else if (levelNumber == 8)
                {
                    gameManager.SetWritingA("WA-8");
                }
                else if (levelNumber == 9)
                {
                    gameManager.SetWritingA("WA-9");
                }
                else if (levelNumber == 10)
                {
                    gameManager.SetWritingA("WA-10");
                }
                else if (levelNumber == 11)
                {
                    gameManager.SetWritingA("WA-11");
                }
                else if (levelNumber == 12)
                {
                    gameManager.SetWritingA("WA-12");
                }
                else if (levelNumber == 13)
                {
                    gameManager.SetWritingA("WA-13");
                }
                else if (levelNumber == 14)
                {
                    gameManager.SetWritingA("WA-14");
                }
                else if (levelNumber == 15)
                {
                    gameManager.SetWritingA("WA-15");
                }
                else if (levelNumber == 16)
                {
                    gameManager.SetWritingA("WA-16");
                }
                else if (levelNumber == 17)
                {
                    gameManager.SetWritingA("WA-17");
                }
                else if (levelNumber == 18)
                {
                    gameManager.SetWritingA("WA-18");
                }
                else if (levelNumber == 19)
                {
                    gameManager.SetWritingA("WA-19");
                }
                else if (levelNumber == 20)
                {
                    gameManager.SetWritingA("WA-20");
                }
                else if (levelNumber == 21)
                {
                    gameManager.SetWritingA("WA-21");
                }
                else if (levelNumber == 22)
                {
                    gameManager.SetWritingA("WA-22");
                }
                else if (levelNumber == 23)
                {
                    gameManager.SetWritingA("WA-23");
                }
                else if (levelNumber == 24)
                {
                    gameManager.SetWritingA("WA-24");
                }
                else if (levelNumber == 25)
                {
                    gameManager.SetWritingA("WA-25");
                }
                else if (levelNumber == 26)
                {
                    gameManager.SetWritingA("WA-26");
                }
                else if (levelNumber == 27)
                {
                    gameManager.SetWritingA("WA-27");
                }
                else if (levelNumber == 28)
                {
                    gameManager.SetWritingA("WA-28");
                }
            }
            else if (category == "numbers")
            {
                if (levelNumber == 1)
                {
                    gameManager.SetWritingN("WN-1");
                }
                else if (levelNumber == 2)
                {
                    gameManager.SetWritingN("WN-2");
                }
                else if (levelNumber == 3)
                {
                    gameManager.SetWritingN("WN-3");
                }
                else if (levelNumber == 4)
                {
                    gameManager.SetWritingN("WN-4");
                }
                else if (levelNumber == 5)
                {
                    gameManager.SetWritingN("WN-5");
                }
                else if (levelNumber == 6)
                {
                    gameManager.SetWritingN("WN-6");
                }
                else if (levelNumber == 7)
                {
                    gameManager.SetWritingN("WN-7");
                }
                else if (levelNumber == 8)
                {
                    gameManager.SetWritingN("WN-8");
                }
                else if (levelNumber == 9)
                {
                    gameManager.SetWritingN("WN-9");
                }
                else if (levelNumber == 10)
                {
                    gameManager.SetWritingN("WN-10");
                }
                else if (levelNumber == 11)
                {
                    gameManager.SetWritingN("WN-11");
                }
            }
        }
        else if (mode == "pronunciation")
        {
            if (category == "alphabets")
            {
                if (levelNumber == 1)
                {
                    gameManager.SetPronunciationA("PA-1");
                }
                else if (levelNumber == 2)
                {
                    gameManager.SetPronunciationA("PA-2");
                }
                else if (levelNumber == 3)
                {
                    gameManager.SetPronunciationA("PA-3");
                }
                else if (levelNumber == 4)
                {
                    gameManager.SetPronunciationA("PA-4");
                }
                else if (levelNumber == 5)
                {
                    gameManager.SetPronunciationA("PA-5");
                }
                else if (levelNumber == 6)
                {
                    gameManager.SetPronunciationA("PA-6");
                }
                else if (levelNumber == 7)
                {
                    gameManager.SetPronunciationA("PA-7");
                }
                else if (levelNumber == 8)
                {
                    gameManager.SetPronunciationA("PA-8");
                }
                else if (levelNumber == 9)
                {
                    gameManager.SetPronunciationA("PA-9");
                }
                else if (levelNumber == 10)
                {
                    gameManager.SetPronunciationA("PA-10");
                }
                else if (levelNumber == 11)
                {
                    gameManager.SetPronunciationA("PA-11");
                }
                else if (levelNumber == 12)
                {
                    gameManager.SetPronunciationA("PA-12");
                }
                else if (levelNumber == 13)
                {
                    gameManager.SetPronunciationA("PA-13");
                }
                else if (levelNumber == 14)
                {
                    gameManager.SetPronunciationA("PA-14");
                }
                else if (levelNumber == 15)
                {
                    gameManager.SetPronunciationA("PA-15");
                }
                else if (levelNumber == 16)
                {
                    gameManager.SetPronunciationA("PA-16");
                }
                else if (levelNumber == 17)
                {
                    gameManager.SetPronunciationA("PA-17");
                }
                else if (levelNumber == 18)
                {
                    gameManager.SetPronunciationA("PA-18");
                }
                else if (levelNumber == 19)
                {
                    gameManager.SetPronunciationA("PA-19");
                }
                else if (levelNumber == 20)
                {
                    gameManager.SetPronunciationA("PA-20");
                }
                else if (levelNumber == 21)
                {
                    gameManager.SetPronunciationA("PA-21");
                }
                else if (levelNumber == 22)
                {
                    gameManager.SetPronunciationA("PA-22");
                }
                else if (levelNumber == 23)
                {
                    gameManager.SetPronunciationA("PA-23");
                }
                else if (levelNumber == 24)
                {
                    gameManager.SetPronunciationA("PA-24");
                }
                else if (levelNumber == 25)
                {
                    gameManager.SetPronunciationA("PA-25");
                }
                else if (levelNumber == 26)
                {
                    gameManager.SetPronunciationA("PA-26");
                }
                else if (levelNumber == 27)
                {
                    gameManager.SetPronunciationA("PA-27");
                }
                else if (levelNumber == 28)
                {
                    gameManager.SetPronunciationA("PA-28");
                }
            }
            else if (category == "numbers")
            {
                if (levelNumber == 1)
                {
                    gameManager.SetPronunciationN("PN-1");
                }
                else if (levelNumber == 2)
                {
                    gameManager.SetPronunciationN("PN-2");
                }
                else if (levelNumber == 3)
                {
                    gameManager.SetPronunciationN("PN-3");
                }
                else if (levelNumber == 4)
                {
                    gameManager.SetPronunciationN("PN-4");
                }
                else if (levelNumber == 5)
                {
                    gameManager.SetPronunciationN("PN-5");
                }
                else if (levelNumber == 6)
                {
                    gameManager.SetPronunciationN("PN-6");
                }
                else if (levelNumber == 7)
                {
                    gameManager.SetPronunciationN("PN-7");
                }
                else if (levelNumber == 8)
                {
                    gameManager.SetPronunciationN("PN-8");
                }
                else if (levelNumber == 9)
                {
                    gameManager.SetPronunciationN("PN-9");
                }
                else if (levelNumber == 10)
                {
                    gameManager.SetPronunciationN("PN-10");
                }
                else if (levelNumber == 11)
                {
                    gameManager.SetPronunciationN("PN-11");
                }
            }
        }
        else if (mode == "arrange")
        {
            if (levelNumber == 1)
            {
                gameManager.SetArrange("AR-1");
            }
            else if (levelNumber == 2)
            {
                gameManager.SetArrange("AR-2");
            }
            else if (levelNumber == 3)
            {
                gameManager.SetArrange("AR-3");
            }
            else if (levelNumber == 4)
            {
                gameManager.SetArrange("AR-4");
            }
            else if (levelNumber == 5)
            {
                gameManager.SetArrange("AR-5");
            }
            else if (levelNumber == 6)
            {
                gameManager.SetArrange("AR-6");
            }
            else if (levelNumber == 7)
            {
                gameManager.SetArrange("AR-7");
            }
            else if (levelNumber == 8)
            {
                gameManager.SetArrange("AR-8");
            }
            else if (levelNumber == 9)
            {
                gameManager.SetArrange("AR-9");
            }
            else if (levelNumber == 10)
            {
                gameManager.SetArrange("AR-10");
            }
            else if (levelNumber == 11)
            {
                gameManager.SetArrange("AR-11");
            }
            else if (levelNumber == 12)
            {
                gameManager.SetArrange("AR-12");
            }
            else if (levelNumber == 13)
            {
                gameManager.SetArrange("AR-13");
            }
            else if (levelNumber == 14)
            {
                gameManager.SetArrange("AR-14");
            }
            else if (levelNumber == 15)
            {
                gameManager.SetArrange("AR-15");
            }
            else if (levelNumber == 16)
            {
                gameManager.SetArrange("AR-16");
            }
            else if (levelNumber == 17)
            {
                gameManager.SetArrange("AR-17");
            }
            else if (levelNumber == 18)
            {
                gameManager.SetArrange("AR-18");
            }
        }
    }



}
