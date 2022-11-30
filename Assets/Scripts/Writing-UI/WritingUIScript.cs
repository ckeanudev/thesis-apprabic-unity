using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WritingUIScript : MonoBehaviour
{
    public string writingCategoryType;
    public TextMeshProUGUI levelNameText;
    public GameObject topContent;

    public TextMeshProUGUI levelText;

    public GameObject sufficientPointsObject;
    public TextMeshProUGUI sufficientPointsText;

    GameManager gameManager;
    public GameObject gameM;

    PlayerStats playerPrefStats;
    public GameObject playerPrefS;

    RequiredPointsForLevels requiredPointsForLevels;
    public GameObject requiredPointsS;

    public GameObject lvl1;
    public GameObject lvl2;
    public GameObject lvl3;
    public GameObject lvl4;
    public GameObject lvl5;
    public GameObject lvl6;
    public GameObject lvl7;
    public GameObject lvl8;
    public GameObject lvl9;
    public GameObject lvl10;
    public GameObject lvl11;
    public GameObject lvl12;
    public GameObject lvl13;
    public GameObject lvl14;
    public GameObject lvl15;
    public GameObject lvl16;
    public GameObject lvl17;
    public GameObject lvl18;
    public GameObject lvl19;
    public GameObject lvl20;
    public GameObject lvl21;
    public GameObject lvl22;
    public GameObject lvl23;
    public GameObject lvl24;
    public GameObject lvl25;
    public GameObject lvl26;
    public GameObject lvl27;
    public GameObject lvl28;
    
    public bool showWinDialog = false;
    public bool delayOnce = false;

    public GameObject winContainer;
    public GameObject loadingObject;
    public GameObject videoObject;

    public int userScore = 0;

    public bool pressNextButton = true;

    private void OnEnable()
    {
        gameManager = gameM.GetComponent<GameManager>();
        playerPrefStats = playerPrefS.GetComponent<PlayerStats>();
        requiredPointsForLevels = requiredPointsS.GetComponent<RequiredPointsForLevels>();

        showWinDialog = false;
        winContainer.SetActive(false);
        sufficientPointsObject.SetActive(false);

        levelText.text = "Level " + gameManager.writingLevel.ToString();
        LevelPageRender();
    }

    // For showing the video per each levels
    public void ShowVideo(int number)
    {
        if(number == 1)
        {
            videoObject.SetActive(true);
        }
        else if (number == 0)
        {
            videoObject.SetActive(false);
        }
    }

    // -------------------------------- For Win Panel Button
    public void BackToChooseLevel()
    {
        sufficientPointsObject.SetActive(false);
        showWinDialog = false;
        if (writingCategoryType == "alphabets")
        {
            gameManager.pageNumber = 1;
            gameManager.mainPageNumber = 4;
        }
        else if (writingCategoryType == "numbers")
        {
            gameManager.pageNumber = 1;
            gameManager.mainPageNumber = 5;
        }
    }

    public void NextLevelBtn()
    {
        if (pressNextButton)
        {
            int playerExperiencePoints = 0;
            int pointsMultiplier = 15;

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

            //gameManager.writingLevel += 1;
            //showWinDialog = false;

            if (writingCategoryType == "alphabets")
            {
                if (gameManager.writingLevel == 1)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL2 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL2 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 2)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL3 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL3 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);

                    }
                }
                else if (gameManager.writingLevel == 3)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL4 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL4 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 4)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL5 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL5 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 5)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL6 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL6 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 6)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL7 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL7 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 7)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL8 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL8 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 8)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL9 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL9 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 9)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL10 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL10 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 10)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL11 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL11 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 11)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL12 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL12 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 12)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL13 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL13 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 13)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL14 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL14 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 14)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL15 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL15 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 15)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL16 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL16 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 16)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL17 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL17 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 17)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL18 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL18 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 18)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL19 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL19 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 19)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL20 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL20 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 20)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL21 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL21 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 21)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL22 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL22 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 22)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL23 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL23 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 23)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL24 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL24 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 24)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL25 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL25 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 25)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL26 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL26 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 26)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL27 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL27 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 27)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWL28 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWL28 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 28)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWN1 * pointsMultiplier)
                    {
                        //AddWritingLevel();
                        gameManager.pageNumber = 1;
                        gameManager.mainPageNumber = 5;
                        showWinDialog = false;
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWN1 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }

            }
            else if (writingCategoryType == "numbers")
            {
                if (gameManager.writingLevel == 1)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWN2 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWN2 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 2)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWN3 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWN3 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 3)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWN4 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWN4 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 4)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWN5 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWN5 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 5)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWN6 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWN6 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 6)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWN7 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWN7 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 7)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWN8 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWN8 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 8)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWN9 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWN9 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 9)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWN10 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWN10 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 10)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forWN11 * pointsMultiplier)
                    {
                        AddWritingLevel();
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forWN11 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
                else if (gameManager.writingLevel == 11)
                {
                    if (playerExperiencePoints >= requiredPointsForLevels.forPL1 * pointsMultiplier)
                    {
                        //AddWritingLevel();
                        gameManager.pageNumber = 1;
                        gameManager.mainPageNumber = 1;
                        showWinDialog = false;
                    }
                    else
                    {
                        int temp = (requiredPointsForLevels.forPL1 * pointsMultiplier) - playerExperiencePoints;
                        ShowSufficientObject(temp);
                    }
                }
            }

        }
        
    }

    public void AddWritingLevel ()
    {
        gameManager.writingLevel += 1;
        showWinDialog = false;
    }

    public void ShowSufficientObject(int num)
    {
        sufficientPointsText.text = "You need " + num.ToString() + " more points to proceed. Retry to earn more points";
        sufficientPointsObject.SetActive(true);
        pressNextButton = false;
        StartCoroutine(HideSufficientAgain());
    }

    public IEnumerator HideSufficientAgain()
    {
        yield return new WaitForSeconds(10f);
        sufficientPointsObject.SetActive(false);
        pressNextButton = true;
    }

    public void CloseSufficientObject()
    {
        sufficientPointsObject.SetActive(false);
        pressNextButton = true;
    }

    public void RetryBtn()
    {
        sufficientPointsObject.SetActive(false);
        pressNextButton = true;
        showWinDialog = false;
        lvl1.SetActive(false);
        lvl2.SetActive(false);
        lvl3.SetActive(false);
        lvl4.SetActive(false);
        lvl5.SetActive(false);
        lvl6.SetActive(false);
        lvl7.SetActive(false);
        lvl8.SetActive(false);
        lvl9.SetActive(false);
        lvl10.SetActive(false);
        lvl11.SetActive(false);
        if (writingCategoryType == "alphabets")
        {
            lvl12.SetActive(false);
            lvl13.SetActive(false);
            lvl14.SetActive(false);
            lvl15.SetActive(false);
            lvl16.SetActive(false);
            lvl17.SetActive(false);
            lvl18.SetActive(false);
            lvl19.SetActive(false);
            lvl20.SetActive(false);
            lvl21.SetActive(false);
            lvl22.SetActive(false);
            lvl23.SetActive(false);
            lvl24.SetActive(false);
            lvl25.SetActive(false);
            lvl26.SetActive(false);
            lvl27.SetActive(false);
            lvl28.SetActive(false);
        }
    }
    // -------------------------------- For Win Panel Button

    private void Update()
    {
        levelText.text = "Level " + gameManager.writingLevel.ToString();

        if (showWinDialog && delayOnce)
        {
            loadingObject.SetActive(true);
            topContent.SetActive(false);
            delayOnce = false;
            StartCoroutine(ShowResult());
        }
        else if (!showWinDialog)
        {
            winContainer.SetActive(false);
            LevelPageRender();
        }
    }

    public IEnumerator ShowResult()
    {
        yield return new WaitForSeconds(1f);
        topContent.SetActive(true);
        loadingObject.SetActive(false);
        winContainer.SetActive(true);

    }

    public void BackFromWritingA()
    {
        gameManager.mainPageNumber = 4;
        gameManager.pageNumber = 1;
        lvl1.SetActive(false);
        lvl2.SetActive(false);
        lvl3.SetActive(false);
        lvl4.SetActive(false);
        lvl5.SetActive(false);
        lvl6.SetActive(false);
        lvl7.SetActive(false);
        lvl8.SetActive(false);
        lvl9.SetActive(false);
        lvl10.SetActive(false);
        lvl11.SetActive(false);
        if(writingCategoryType == "alphabets")
        {
            lvl12.SetActive(false);
            lvl13.SetActive(false);
            lvl14.SetActive(false);
            lvl15.SetActive(false);
            lvl16.SetActive(false);
            lvl17.SetActive(false);
            lvl18.SetActive(false);
            lvl19.SetActive(false);
            lvl20.SetActive(false);
            lvl21.SetActive(false);
            lvl22.SetActive(false);
            lvl23.SetActive(false);
            lvl24.SetActive(false);
            lvl25.SetActive(false);
            lvl26.SetActive(false);
            lvl27.SetActive(false);
            lvl28.SetActive(false);
        }
    }

    public void BackFromWritingN()
    {
        gameManager.mainPageNumber = 5;
        gameManager.pageNumber = 1;
        lvl1.SetActive(false);
        lvl2.SetActive(false);
        lvl3.SetActive(false);
        lvl4.SetActive(false);
        lvl5.SetActive(false);
        lvl6.SetActive(false);
        lvl7.SetActive(false);
        lvl8.SetActive(false);
        lvl9.SetActive(false);
        lvl10.SetActive(false);
        lvl11.SetActive(false);
    }


    public void LevelPageRender()
    {
        if (gameManager.writingLevel == 1)
        {
            if (writingCategoryType == "alphabets")
            {
                levelNameText.text = "Alif";
            } else if (writingCategoryType == "numbers")
            {
                levelNameText.text = "Ṣifr";
            }

            lvl1.SetActive(true);
            lvl2.SetActive(false);
            lvl3.SetActive(false);
            lvl4.SetActive(false);
            lvl5.SetActive(false);
            lvl6.SetActive(false);
            lvl7.SetActive(false);
            lvl8.SetActive(false);
            lvl9.SetActive(false);
            lvl10.SetActive(false);
            lvl11.SetActive(false);
            if (writingCategoryType == "alphabets")
            {
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
                
        }
        else if (gameManager.writingLevel == 2)
        {
            if (writingCategoryType == "alphabets")
            {
                levelNameText.text = "Baa";
            }
            else if (writingCategoryType == "numbers")
            {
                levelNameText.text = "Waḥid";
            }

            lvl1.SetActive(false);
            lvl2.SetActive(true);
            lvl3.SetActive(false);
            lvl4.SetActive(false);
            lvl5.SetActive(false);
            lvl6.SetActive(false);
            lvl7.SetActive(false);
            lvl8.SetActive(false);
            lvl9.SetActive(false);
            lvl10.SetActive(false);
            lvl11.SetActive(false);
            if (writingCategoryType == "alphabets")
            {
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
               
        }
        else if (gameManager.writingLevel == 3)
        {
            if (writingCategoryType == "alphabets")
            {
                levelNameText.text = "Taa";
            }
            else if (writingCategoryType == "numbers")
            {
                levelNameText.text = "Ithnan";
            }

            lvl1.SetActive(false);
            lvl2.SetActive(false);
            lvl3.SetActive(true);
            lvl4.SetActive(false);
            lvl5.SetActive(false);
            lvl6.SetActive(false);
            lvl7.SetActive(false);
            lvl8.SetActive(false);
            lvl9.SetActive(false);
            lvl10.SetActive(false);
            lvl11.SetActive(false);
            if (writingCategoryType == "alphabets")
            {
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
               
        }
        else if (gameManager.writingLevel == 4)
        {
            if (writingCategoryType == "alphabets")
            {
                levelNameText.text = "Thaa";
            }
            else if (writingCategoryType == "numbers")
            {
                levelNameText.text = "Thalathah";
            }

            lvl1.SetActive(false);
            lvl2.SetActive(false);
            lvl3.SetActive(false);
            lvl4.SetActive(true);
            lvl5.SetActive(false);
            lvl6.SetActive(false);
            lvl7.SetActive(false);
            lvl8.SetActive(false);
            lvl9.SetActive(false);
            lvl10.SetActive(false);
            lvl11.SetActive(false);
            if (writingCategoryType == "alphabets")
            {
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
                
        }
        else if (gameManager.writingLevel == 5)
        {
            if (writingCategoryType == "alphabets")
            {
                levelNameText.text = "Jeem";
            }
            else if (writingCategoryType == "numbers")
            {
                levelNameText.text = "Arba’ah";
            }

            lvl1.SetActive(false);
            lvl2.SetActive(false);
            lvl3.SetActive(false);
            lvl4.SetActive(false);
            lvl5.SetActive(true);
            lvl6.SetActive(false);
            lvl7.SetActive(false);
            lvl8.SetActive(false);
            lvl9.SetActive(false);
            lvl10.SetActive(false);
            lvl11.SetActive(false);
            if (writingCategoryType == "alphabets")
            {
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
               
        }
        else if (gameManager.writingLevel == 6)
        {
            if (writingCategoryType == "alphabets")
            {
                levelNameText.text = "Ḥa";
            }
            else if (writingCategoryType == "numbers")
            {
                levelNameText.text = "Khamsah";
            }

            lvl1.SetActive(false);
            lvl2.SetActive(false);
            lvl3.SetActive(false);
            lvl4.SetActive(false);
            lvl5.SetActive(false);
            lvl6.SetActive(true);
            lvl7.SetActive(false);
            lvl8.SetActive(false);
            lvl9.SetActive(false);
            lvl10.SetActive(false);
            lvl11.SetActive(false);
            if (writingCategoryType == "alphabets")
            {
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
                
        }
        else if (gameManager.writingLevel == 7)
        {
            if (writingCategoryType == "alphabets")
            {
                levelNameText.text = "Kha";
            }
            else if (writingCategoryType == "numbers")
            {
                levelNameText.text = "Sittah";
            }
            lvl1.SetActive(false);
            lvl2.SetActive(false);
            lvl3.SetActive(false);
            lvl4.SetActive(false);
            lvl5.SetActive(false);
            lvl6.SetActive(false);
            lvl7.SetActive(true);
            lvl8.SetActive(false);
            lvl9.SetActive(false);
            lvl10.SetActive(false);
            lvl11.SetActive(false);
            if (writingCategoryType == "alphabets")
            {
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
               
        }
        else if (gameManager.writingLevel == 8)
        {
            if (writingCategoryType == "alphabets")
            {
                levelNameText.text = "Daal";
            }
            else if (writingCategoryType == "numbers")
            {
                levelNameText.text = "Sab’ah";
            }
            lvl1.SetActive(false);
            lvl2.SetActive(false);
            lvl3.SetActive(false);
            lvl4.SetActive(false);
            lvl5.SetActive(false);
            lvl6.SetActive(false);
            lvl7.SetActive(false);
            lvl8.SetActive(true);
            lvl9.SetActive(false);
            lvl10.SetActive(false);
            lvl11.SetActive(false);
            if (writingCategoryType == "alphabets")
            {
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
                
        }
        else if (gameManager.writingLevel == 9)
        {
            if (writingCategoryType == "alphabets")
            {
                levelNameText.text = "Dhaal";
            }
            else if (writingCategoryType == "numbers")
            {
                levelNameText.text = "Thamaniyah";
            }
            lvl1.SetActive(false);
            lvl2.SetActive(false);
            lvl3.SetActive(false);
            lvl4.SetActive(false);
            lvl5.SetActive(false);
            lvl6.SetActive(false);
            lvl7.SetActive(false);
            lvl8.SetActive(false);
            lvl9.SetActive(true);
            lvl10.SetActive(false);
            lvl11.SetActive(false);
            if (writingCategoryType == "alphabets")
            {
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
                
        }
        else if (gameManager.writingLevel == 10)
        {
            if (writingCategoryType == "alphabets")
            {
                levelNameText.text = "Raa";
            }
            else if (writingCategoryType == "numbers")
            {
                levelNameText.text = "Tis’ah";
            }
            lvl1.SetActive(false);
            lvl2.SetActive(false);
            lvl3.SetActive(false);
            lvl4.SetActive(false);
            lvl5.SetActive(false);
            lvl6.SetActive(false);
            lvl7.SetActive(false);
            lvl8.SetActive(false);
            lvl9.SetActive(false);
            lvl10.SetActive(true);
            lvl11.SetActive(false);
            if (writingCategoryType == "alphabets")
            {
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
                
        }
        else if (gameManager.writingLevel == 11)
        {
            if (writingCategoryType == "alphabets")
            {
                levelNameText.text = "Zaa";
            }
            else if (writingCategoryType == "numbers")
            {
                levelNameText.text = "Ashrah";
            }
            lvl1.SetActive(false);
            lvl2.SetActive(false);
            lvl3.SetActive(false);
            lvl4.SetActive(false);
            lvl5.SetActive(false);
            lvl6.SetActive(false);
            lvl7.SetActive(false);
            lvl8.SetActive(false);
            lvl9.SetActive(false);
            lvl10.SetActive(false);
            lvl11.SetActive(true);
            if (writingCategoryType == "alphabets")
            {
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
               
        }

        if(writingCategoryType == "alphabets")
        {
            if (gameManager.writingLevel == 12)
            {
                levelNameText.text = "Seen";
                lvl1.SetActive(false);
                lvl2.SetActive(false);
                lvl3.SetActive(false);
                lvl4.SetActive(false);
                lvl5.SetActive(false);
                lvl6.SetActive(false);
                lvl7.SetActive(false);
                lvl8.SetActive(false);
                lvl9.SetActive(false);
                lvl10.SetActive(false);
                lvl11.SetActive(false);
                lvl12.SetActive(true);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
            else if (gameManager.writingLevel == 13)
            {
                levelNameText.text = "Sheen";
                lvl1.SetActive(false);
                lvl2.SetActive(false);
                lvl3.SetActive(false);
                lvl4.SetActive(false);
                lvl5.SetActive(false);
                lvl6.SetActive(false);
                lvl7.SetActive(false);
                lvl8.SetActive(false);
                lvl9.SetActive(false);
                lvl10.SetActive(false);
                lvl11.SetActive(false);
                lvl12.SetActive(false);
                lvl13.SetActive(true);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
            else if (gameManager.writingLevel == 14)
            {
                levelNameText.text = "Ṣaad";
                lvl1.SetActive(false);
                lvl2.SetActive(false);
                lvl3.SetActive(false);
                lvl4.SetActive(false);
                lvl5.SetActive(false);
                lvl6.SetActive(false);
                lvl7.SetActive(false);
                lvl8.SetActive(false);
                lvl9.SetActive(false);
                lvl10.SetActive(false);
                lvl11.SetActive(false);
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(true);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
            else if (gameManager.writingLevel == 15)
            {
                levelNameText.text = "Ḍaad";
                lvl1.SetActive(false);
                lvl2.SetActive(false);
                lvl3.SetActive(false);
                lvl4.SetActive(false);
                lvl5.SetActive(false);
                lvl6.SetActive(false);
                lvl7.SetActive(false);
                lvl8.SetActive(false);
                lvl9.SetActive(false);
                lvl10.SetActive(false);
                lvl11.SetActive(false);
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(true);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
            else if (gameManager.writingLevel == 16)
            {
                levelNameText.text = "Ṭa";
                lvl1.SetActive(false);
                lvl2.SetActive(false);
                lvl3.SetActive(false);
                lvl4.SetActive(false);
                lvl5.SetActive(false);
                lvl6.SetActive(false);
                lvl7.SetActive(false);
                lvl8.SetActive(false);
                lvl9.SetActive(false);
                lvl10.SetActive(false);
                lvl11.SetActive(false);
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(true);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
            else if (gameManager.writingLevel == 17)
            {
                levelNameText.text = "Ẓa";
                lvl1.SetActive(false);
                lvl2.SetActive(false);
                lvl3.SetActive(false);
                lvl4.SetActive(false);
                lvl5.SetActive(false);
                lvl6.SetActive(false);
                lvl7.SetActive(false);
                lvl8.SetActive(false);
                lvl9.SetActive(false);
                lvl10.SetActive(false);
                lvl11.SetActive(false);
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(true);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
            else if (gameManager.writingLevel == 18)
            {
                levelNameText.text = "Ayn";
                lvl1.SetActive(false);
                lvl2.SetActive(false);
                lvl3.SetActive(false);
                lvl4.SetActive(false);
                lvl5.SetActive(false);
                lvl6.SetActive(false);
                lvl7.SetActive(false);
                lvl8.SetActive(false);
                lvl9.SetActive(false);
                lvl10.SetActive(false);
                lvl11.SetActive(false);
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(true);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
            else if (gameManager.writingLevel == 19)
            {
                levelNameText.text = "Ghayn";
                lvl1.SetActive(false);
                lvl2.SetActive(false);
                lvl3.SetActive(false);
                lvl4.SetActive(false);
                lvl5.SetActive(false);
                lvl6.SetActive(false);
                lvl7.SetActive(false);
                lvl8.SetActive(false);
                lvl9.SetActive(false);
                lvl10.SetActive(false);
                lvl11.SetActive(false);
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(true);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
            else if (gameManager.writingLevel == 20)
            {
                levelNameText.text = "Faa";
                lvl1.SetActive(false);
                lvl2.SetActive(false);
                lvl3.SetActive(false);
                lvl4.SetActive(false);
                lvl5.SetActive(false);
                lvl6.SetActive(false);
                lvl7.SetActive(false);
                lvl8.SetActive(false);
                lvl9.SetActive(false);
                lvl10.SetActive(false);
                lvl11.SetActive(false);
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(true);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
            else if (gameManager.writingLevel == 21)
            {
                levelNameText.text = "Qaaf";
                lvl1.SetActive(false);
                lvl2.SetActive(false);
                lvl3.SetActive(false);
                lvl4.SetActive(false);
                lvl5.SetActive(false);
                lvl6.SetActive(false);
                lvl7.SetActive(false);
                lvl8.SetActive(false);
                lvl9.SetActive(false);
                lvl10.SetActive(false);
                lvl11.SetActive(false);
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(true);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
            else if (gameManager.writingLevel == 22)
            {
                levelNameText.text = "Kaaf";
                lvl1.SetActive(false);
                lvl2.SetActive(false);
                lvl3.SetActive(false);
                lvl4.SetActive(false);
                lvl5.SetActive(false);
                lvl6.SetActive(false);
                lvl7.SetActive(false);
                lvl8.SetActive(false);
                lvl9.SetActive(false);
                lvl10.SetActive(false);
                lvl11.SetActive(false);
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(true);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
            else if (gameManager.writingLevel == 23)
            {
                levelNameText.text = "Laam";
                lvl1.SetActive(false);
                lvl2.SetActive(false);
                lvl3.SetActive(false);
                lvl4.SetActive(false);
                lvl5.SetActive(false);
                lvl6.SetActive(false);
                lvl7.SetActive(false);
                lvl8.SetActive(false);
                lvl9.SetActive(false);
                lvl10.SetActive(false);
                lvl11.SetActive(false);
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(true);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
            else if (gameManager.writingLevel == 24)
            {
                levelNameText.text = "Meem";
                lvl1.SetActive(false);
                lvl2.SetActive(false);
                lvl3.SetActive(false);
                lvl4.SetActive(false);
                lvl5.SetActive(false);
                lvl6.SetActive(false);
                lvl7.SetActive(false);
                lvl8.SetActive(false);
                lvl9.SetActive(false);
                lvl10.SetActive(false);
                lvl11.SetActive(false);
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(true);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
            else if (gameManager.writingLevel == 25)
            {
                levelNameText.text = "Noon";
                lvl1.SetActive(false);
                lvl2.SetActive(false);
                lvl3.SetActive(false);
                lvl4.SetActive(false);
                lvl5.SetActive(false);
                lvl6.SetActive(false);
                lvl7.SetActive(false);
                lvl8.SetActive(false);
                lvl9.SetActive(false);
                lvl10.SetActive(false);
                lvl11.SetActive(false);
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(true);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
            else if (gameManager.writingLevel == 26)
            {
                levelNameText.text = "Haa";
                lvl1.SetActive(false);
                lvl2.SetActive(false);
                lvl3.SetActive(false);
                lvl4.SetActive(false);
                lvl5.SetActive(false);
                lvl6.SetActive(false);
                lvl7.SetActive(false);
                lvl8.SetActive(false);
                lvl9.SetActive(false);
                lvl10.SetActive(false);
                lvl11.SetActive(false);
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(true);
                lvl27.SetActive(false);
                lvl28.SetActive(false);
            }
            else if (gameManager.writingLevel == 27)
            {
                levelNameText.text = "Waaw";
                lvl1.SetActive(false);
                lvl2.SetActive(false);
                lvl3.SetActive(false);
                lvl4.SetActive(false);
                lvl5.SetActive(false);
                lvl6.SetActive(false);
                lvl7.SetActive(false);
                lvl8.SetActive(false);
                lvl9.SetActive(false);
                lvl10.SetActive(false);
                lvl11.SetActive(false);
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(true);
                lvl28.SetActive(false);
            }
            else if (gameManager.writingLevel == 28)
            {
                levelNameText.text = "Yaa";
                lvl1.SetActive(false);
                lvl2.SetActive(false);
                lvl3.SetActive(false);
                lvl4.SetActive(false);
                lvl5.SetActive(false);
                lvl6.SetActive(false);
                lvl7.SetActive(false);
                lvl8.SetActive(false);
                lvl9.SetActive(false);
                lvl10.SetActive(false);
                lvl11.SetActive(false);
                lvl12.SetActive(false);
                lvl13.SetActive(false);
                lvl14.SetActive(false);
                lvl15.SetActive(false);
                lvl16.SetActive(false);
                lvl17.SetActive(false);
                lvl18.SetActive(false);
                lvl19.SetActive(false);
                lvl20.SetActive(false);
                lvl21.SetActive(false);
                lvl22.SetActive(false);
                lvl23.SetActive(false);
                lvl24.SetActive(false);
                lvl25.SetActive(false);
                lvl26.SetActive(false);
                lvl27.SetActive(false);
                lvl28.SetActive(true);
            }

        }


    }

}
