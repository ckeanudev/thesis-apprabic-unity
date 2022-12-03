using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArrangeUIScript : MonoBehaviour
{
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

    public bool showWinDialog = false;
    public bool delayOnce = false;

    public GameObject winContainer;
    public GameObject unwinContainer;
    public GameObject loadingObject;
    public GameObject videoObject;

    public bool userAnswer = false;
    public int userScore = 0;

    public bool pressNextButton = true;

    private void OnEnable()
    {
        gameManager = gameM.GetComponent<GameManager>();
        playerPrefStats = playerPrefS.GetComponent<PlayerStats>();
        requiredPointsForLevels = requiredPointsS.GetComponent<RequiredPointsForLevels>();

        showWinDialog = false;
        winContainer.SetActive(false);

        levelText.text = "Level " + gameManager.arrangeLevel.ToString();
        LevelPageRender();
    }

    public void BackToChooseLevel()
    {
        gameManager.buttonSoundEffect.Play();
        showWinDialog = false;
        sufficientPointsObject.SetActive(false);
        gameManager.pageNumber = 1;
        gameManager.mainPageNumber = 9;
    }

    public void NextLevelBtn()
    {
        //showWinDialog = false;
        //if(gameManager.arrangeLevel >= 18)
        //{
        //    gameManager.pageNumber = 1;
        //    gameManager.mainPageNumber = 1;
        //}
        //else
        //{
        //    gameManager.arrangeLevel += 1;
        //}

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

            //gameManager.arrangeLevel += 1;
            //showWinDialog = false;

            if (gameManager.arrangeLevel == 1)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forARR2 * pointsMultiplier)
                {
                    AddWritingLevel();
                }
                else
                {
                    int temp = (requiredPointsForLevels.forARR2 * pointsMultiplier) - playerExperiencePoints;
                    ShowSufficientObject(temp);
                }
            }
            else if (gameManager.arrangeLevel == 2)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forARR3 * pointsMultiplier)
                {
                    AddWritingLevel();
                }
                else
                {
                    int temp = (requiredPointsForLevels.forARR3 * pointsMultiplier) - playerExperiencePoints;
                    ShowSufficientObject(temp);
                }
            }
            else if (gameManager.arrangeLevel == 3)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forARR4 * pointsMultiplier)
                {
                    AddWritingLevel();
                }
                else
                {
                    int temp = (requiredPointsForLevels.forARR4 * pointsMultiplier) - playerExperiencePoints;
                    ShowSufficientObject(temp);
                }
            }
            else if (gameManager.arrangeLevel == 4)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forARR5 * pointsMultiplier)
                {
                    AddWritingLevel();
                }
                else
                {
                    int temp = (requiredPointsForLevels.forARR5 * pointsMultiplier) - playerExperiencePoints;
                    ShowSufficientObject(temp);
                }
            }
            else if (gameManager.arrangeLevel == 5)
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
            else if (gameManager.arrangeLevel == 6)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forARR7 * pointsMultiplier)
                {
                    AddWritingLevel();
                }
                else
                {
                    int temp = (requiredPointsForLevels.forARR7 * pointsMultiplier) - playerExperiencePoints;
                    ShowSufficientObject(temp);
                }
            }
            else if (gameManager.arrangeLevel == 7)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forARR8 * pointsMultiplier)
                {
                    AddWritingLevel();
                }
                else
                {
                    int temp = (requiredPointsForLevels.forARR8 * pointsMultiplier) - playerExperiencePoints;
                    ShowSufficientObject(temp);
                }
            }
            else if (gameManager.arrangeLevel == 8)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forARR9 * pointsMultiplier)
                {
                    AddWritingLevel();
                }
                else
                {
                    int temp = (requiredPointsForLevels.forARR9 * pointsMultiplier) - playerExperiencePoints;
                    ShowSufficientObject(temp);
                }
            }
            else if (gameManager.arrangeLevel == 9)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forARR10 * pointsMultiplier)
                {
                    AddWritingLevel();
                }
                else
                {
                    int temp = (requiredPointsForLevels.forARR10 * pointsMultiplier) - playerExperiencePoints;
                    ShowSufficientObject(temp);
                }
            }
            else if (gameManager.arrangeLevel == 10)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forARR11 * pointsMultiplier)
                {
                    AddWritingLevel();
                }
                else
                {
                    int temp = (requiredPointsForLevels.forARR11 * pointsMultiplier) - playerExperiencePoints;
                    ShowSufficientObject(temp);
                }
            }
            else if (gameManager.arrangeLevel == 11)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forARR12 * pointsMultiplier)
                {
                    AddWritingLevel();
                }
                else
                {
                    int temp = (requiredPointsForLevels.forARR12 * pointsMultiplier) - playerExperiencePoints;
                    ShowSufficientObject(temp);
                }
            }
            else if (gameManager.arrangeLevel == 12)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forARR13 * pointsMultiplier)
                {
                    AddWritingLevel();
                }
                else
                {
                    int temp = (requiredPointsForLevels.forARR13 * pointsMultiplier) - playerExperiencePoints;
                    ShowSufficientObject(temp);
                }
            }
            else if (gameManager.arrangeLevel == 13)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forARR14 * pointsMultiplier)
                {
                    AddWritingLevel();
                }
                else
                {
                    int temp = (requiredPointsForLevels.forARR14 * pointsMultiplier) - playerExperiencePoints;
                    ShowSufficientObject(temp);
                }
            }
            else if (gameManager.arrangeLevel == 14)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forARR15 * pointsMultiplier)
                {
                    AddWritingLevel();
                }
                else
                {
                    int temp = (requiredPointsForLevels.forARR15 * pointsMultiplier) - playerExperiencePoints;
                    ShowSufficientObject(temp);
                }
            }
            else if (gameManager.arrangeLevel == 15)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forARR16 * pointsMultiplier)
                {
                    AddWritingLevel();
                }
                else
                {
                    int temp = (requiredPointsForLevels.forARR16 * pointsMultiplier) - playerExperiencePoints;
                    ShowSufficientObject(temp);
                }
            }
            else if (gameManager.arrangeLevel == 16)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forARR17 * pointsMultiplier)
                {
                    AddWritingLevel();
                }
                else
                {
                    int temp = (requiredPointsForLevels.forARR17 * pointsMultiplier) - playerExperiencePoints;
                    ShowSufficientObject(temp);
                }
            }
            else if (gameManager.arrangeLevel == 17)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forARR18 * pointsMultiplier)
                {
                    AddWritingLevel();
                }
                else
                {
                    int temp = (requiredPointsForLevels.forARR18 * pointsMultiplier) - playerExperiencePoints;
                    ShowSufficientObject(temp);
                }
            }
            else if (gameManager.arrangeLevel >= 18)
            {
                if (playerExperiencePoints >= requiredPointsForLevels.forPostTest * pointsMultiplier)
                {
                    //AddWritingLevel();
                    gameManager.pageNumber = 1;
                    gameManager.mainPageNumber = 1;
                }
                else
                {
                    int temp = (requiredPointsForLevels.forPostTest * pointsMultiplier) - playerExperiencePoints;
                    ShowSufficientObject(temp);
                }
            }
        }

    }

    public void AddWritingLevel()
    {
        gameManager.buttonSoundEffect.Play();
        gameManager.arrangeLevel += 1;
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
        gameManager.buttonSoundEffect.Play();
        sufficientPointsObject.SetActive(false);
        pressNextButton = true;
    }

    public void RetryBtn()
    {
        gameManager.buttonSoundEffect.Play();
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
        lvl12.SetActive(false);
        lvl13.SetActive(false);
        lvl14.SetActive(false);
        lvl15.SetActive(false);
        lvl16.SetActive(false);
        lvl17.SetActive(false);
        lvl18.SetActive(false);
    }




    private void Update()
    {
        levelText.text = "Level " + gameManager.arrangeLevel.ToString();

        if (showWinDialog && delayOnce)
        {
            if (userAnswer)
            {
                loadingObject.SetActive(true);
                topContent.SetActive(false);
                delayOnce = false;
                userAnswer = false;
                StartCoroutine(ShowResult1());
            }
            else
            {
                loadingObject.SetActive(true);
                topContent.SetActive(false);
                delayOnce = false;
                userAnswer = false;
                StartCoroutine(ShowResult2());
            }
        }
        else if (!showWinDialog)
        {
            winContainer.SetActive(false);
            unwinContainer.SetActive(false);

            LevelPageRender();
        }
    }

    public IEnumerator ShowResult1()
    {
        yield return new WaitForSeconds(1f);
        topContent.SetActive(true);
        loadingObject.SetActive(false);
        winContainer.SetActive(true);
    }

    public IEnumerator ShowResult2()
    {
        yield return new WaitForSeconds(1f);
        topContent.SetActive(true);
        loadingObject.SetActive(false);
        unwinContainer.SetActive(true);
    }

    public void BackFromArrange()
    {
        gameManager.buttonSoundEffect.Play();
        gameManager.mainPageNumber = 9;
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
        lvl12.SetActive(false);
        lvl13.SetActive(false);
        lvl14.SetActive(false);
        lvl15.SetActive(false);
        lvl16.SetActive(false);
        lvl17.SetActive(false);
        lvl18.SetActive(false);
    }

    public void LevelPageRender()
    {
        if (gameManager.arrangeLevel == 1)
        {
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
            lvl12.SetActive(false);
            lvl13.SetActive(false);
            lvl14.SetActive(false);
            lvl15.SetActive(false);
            lvl16.SetActive(false);
            lvl17.SetActive(false);
            lvl18.SetActive(false);
        }
        else if (gameManager.arrangeLevel == 2)
        {
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
            lvl12.SetActive(false);
            lvl13.SetActive(false);
            lvl14.SetActive(false);
            lvl15.SetActive(false);
            lvl16.SetActive(false);
            lvl17.SetActive(false);
            lvl18.SetActive(false);
        }
        else if (gameManager.arrangeLevel == 3)
        {
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
            lvl12.SetActive(false);
            lvl13.SetActive(false);
            lvl14.SetActive(false);
            lvl15.SetActive(false);
            lvl16.SetActive(false);
            lvl17.SetActive(false);
            lvl18.SetActive(false);
        }
        else if (gameManager.arrangeLevel == 4)
        {
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
            lvl12.SetActive(false);
            lvl13.SetActive(false);
            lvl14.SetActive(false);
            lvl15.SetActive(false);
            lvl16.SetActive(false);
            lvl17.SetActive(false);
            lvl18.SetActive(false);
        }
        else if (gameManager.arrangeLevel == 5)
        {
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
            lvl12.SetActive(false);
            lvl13.SetActive(false);
            lvl14.SetActive(false);
            lvl15.SetActive(false);
            lvl16.SetActive(false);
            lvl17.SetActive(false);
            lvl18.SetActive(false);
        }
        else if (gameManager.arrangeLevel == 6)
        {
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
            lvl12.SetActive(false);
            lvl13.SetActive(false);
            lvl14.SetActive(false);
            lvl15.SetActive(false);
            lvl16.SetActive(false);
            lvl17.SetActive(false);
            lvl18.SetActive(false);
        }
        else if (gameManager.arrangeLevel == 7)
        {
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
            lvl12.SetActive(false);
            lvl13.SetActive(false);
            lvl14.SetActive(false);
            lvl15.SetActive(false);
            lvl16.SetActive(false);
            lvl17.SetActive(false);
            lvl18.SetActive(false);
        }
        else if (gameManager.arrangeLevel == 8)
        {
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
            lvl12.SetActive(false);
            lvl13.SetActive(false);
            lvl14.SetActive(false);
            lvl15.SetActive(false);
            lvl16.SetActive(false);
            lvl17.SetActive(false);
            lvl18.SetActive(false);
        }
        else if (gameManager.arrangeLevel == 9)
        {
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
            lvl12.SetActive(false);
            lvl13.SetActive(false);
            lvl14.SetActive(false);
            lvl15.SetActive(false);
            lvl16.SetActive(false);
            lvl17.SetActive(false);
            lvl18.SetActive(false);
        }
        else if (gameManager.arrangeLevel == 10)
        {
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
            lvl12.SetActive(false);
            lvl13.SetActive(false);
            lvl14.SetActive(false);
            lvl15.SetActive(false);
            lvl16.SetActive(false);
            lvl17.SetActive(false);
            lvl18.SetActive(false);
        }
        else if (gameManager.arrangeLevel == 11)
        {
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
            lvl12.SetActive(false);
            lvl13.SetActive(false);
            lvl14.SetActive(false);
            lvl15.SetActive(false);
            lvl16.SetActive(false);
            lvl17.SetActive(false);
            lvl18.SetActive(false);
        }
        else if (gameManager.arrangeLevel == 12)
        {
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
        }
        else if (gameManager.arrangeLevel == 13)
        {
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
        }
        else if (gameManager.arrangeLevel == 14)
        {
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
        }
        else if (gameManager.arrangeLevel == 15)
        {
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
        }
        else if (gameManager.arrangeLevel == 16)
        {
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
        }
        else if (gameManager.arrangeLevel == 17)
        {
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
        }
        else if (gameManager.arrangeLevel == 18)
        {
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
        }
    }

    public void ShowVideo(int num)
    {
        gameManager.buttonSoundEffect.Play();
        if (num == 1)
        {
            videoObject.SetActive(true);
        }
        else if (num == 0)
        {
            videoObject.SetActive(false);
        }
    }

}