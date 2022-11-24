using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PronouneUIScript : MonoBehaviour
{
    public string pronunciationCategoryType;
    public TextMeshProUGUI levelNameText;
    public GameObject topContent;

    public TextMeshProUGUI levelText;

    GameManager gameManager;
    public GameObject gameM;

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
    public GameObject unwinContainer;
    public GameObject loadingObject;
    public GameObject videoObject;

    public bool userAnswer = false;
    public int userScore = 0;

    private void OnEnable()
    {
        gameManager = gameM.GetComponent<GameManager>();

        showWinDialog = false;
        winContainer.SetActive(false);

        levelText.text = "Level " + gameManager.pronuncationLevel.ToString();
        LevelPageRender();
    }

    // For showing the video per each levels
    public void ShowVideo(int number)
    {
        if (number == 1)
        {
            videoObject.SetActive(true);
        }
        else if (number == 0)
        {
            videoObject.SetActive(false);
        }
    }

    // -------------------------------- For Win Panel Button >>>>
    public void BackToChooseLevel()
    {
        showWinDialog = false;
        if (pronunciationCategoryType == "alphabets")
        {
            gameManager.pageNumber = 1;
            gameManager.mainPageNumber = 6;
        }
        else if (pronunciationCategoryType == "numbers")
        {
            gameManager.pageNumber = 1;
            gameManager.mainPageNumber = 7;
        }
    }

    public void NextLevelBtn()
    {
        showWinDialog = false;
        if (pronunciationCategoryType == "numbers" && gameManager.pronuncationLevel >= 11)
        {
            gameManager.pageNumber = 1;
            gameManager.mainPageNumber = 1;
        }
        else if (pronunciationCategoryType == "alphabets" && gameManager.pronuncationLevel >= 28)
        {
            gameManager.pageNumber = 1;
            gameManager.mainPageNumber = 7;
        }
        else
        {
            gameManager.pronuncationLevel += 1;
        }
    }

    public void RetryBtn()
    {
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
        if (pronunciationCategoryType == "alphabets")
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
    // -------------------------------- For Win Panel Button >>>>

    // -------------------------------- For Back Button
    public void BackFromPronunciationA()
    {
        gameManager.mainPageNumber = 6;
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
        if (pronunciationCategoryType == "alphabets")
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

    public void BackFromPronunciationN()
    {
        gameManager.mainPageNumber = 7;
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

    private void Update()
    {
        levelText.text = "Level " + gameManager.pronuncationLevel.ToString();

        if (showWinDialog && delayOnce)
        {
            if(userAnswer)
            {
                loadingObject.SetActive(true);
                topContent.SetActive(false);
                delayOnce = false;
                userAnswer = false;
                StartCoroutine(ShowResult1());
            } else
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

    public void LevelPageRender()
    {
        if (gameManager.pronuncationLevel == 1)
        {
            if (pronunciationCategoryType == "alphabets")
            {
                levelNameText.text = "Alif";
            }
            else if (pronunciationCategoryType == "numbers")
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
            if (pronunciationCategoryType == "alphabets")
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
        else if (gameManager.pronuncationLevel == 2)
        {
            if (pronunciationCategoryType == "alphabets")
            {
                levelNameText.text = "Baa";
            }
            else if (pronunciationCategoryType == "numbers")
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
            if (pronunciationCategoryType == "alphabets")
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
        else if (gameManager.pronuncationLevel == 3)
        {
            if (pronunciationCategoryType == "alphabets")
            {
                levelNameText.text = "Taa";
            }
            else if (pronunciationCategoryType == "numbers")
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
            if (pronunciationCategoryType == "alphabets")
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
        else if (gameManager.pronuncationLevel == 4)
        {
            if (pronunciationCategoryType == "alphabets")
            {
                levelNameText.text = "Thaa";
            }
            else if (pronunciationCategoryType == "numbers")
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
            if (pronunciationCategoryType == "alphabets")
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
        else if (gameManager.pronuncationLevel == 5)
        {
            if (pronunciationCategoryType == "alphabets")
            {
                levelNameText.text = "Jeem";
            }
            else if (pronunciationCategoryType == "numbers")
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
            if (pronunciationCategoryType == "alphabets")
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
        else if (gameManager.pronuncationLevel == 6)
        {
            if (pronunciationCategoryType == "alphabets")
            {
                levelNameText.text = "Ḥa";
            }
            else if (pronunciationCategoryType == "numbers")
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
            if (pronunciationCategoryType == "alphabets")
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
        else if (gameManager.pronuncationLevel == 7)
        {
            if (pronunciationCategoryType == "alphabets")
            {
                levelNameText.text = "Kha";
            }
            else if (pronunciationCategoryType == "numbers")
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
            if (pronunciationCategoryType == "alphabets")
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
        else if (gameManager.pronuncationLevel == 8)
        {
            if (pronunciationCategoryType == "alphabets")
            {
                levelNameText.text = "Daal";
            }
            else if (pronunciationCategoryType == "numbers")
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
            if (pronunciationCategoryType == "alphabets")
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
        else if (gameManager.pronuncationLevel == 9)
        {
            if (pronunciationCategoryType == "alphabets")
            {
                levelNameText.text = "Dhaal";
            }
            else if (pronunciationCategoryType == "numbers")
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
            if (pronunciationCategoryType == "alphabets")
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
        else if (gameManager.pronuncationLevel == 10)
        {
            if (pronunciationCategoryType == "alphabets")
            {
                levelNameText.text = "Raa";
            }
            else if (pronunciationCategoryType == "numbers")
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
            if (pronunciationCategoryType == "alphabets")
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
        else if (gameManager.pronuncationLevel == 11)
        {
            if (pronunciationCategoryType == "alphabets")
            {
                levelNameText.text = "Zaa";
            }
            else if (pronunciationCategoryType == "numbers")
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
            if (pronunciationCategoryType == "alphabets")
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

        if (pronunciationCategoryType == "alphabets")
        {
            if (gameManager.pronuncationLevel == 12)
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
            else if (gameManager.pronuncationLevel == 13)
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
            else if (gameManager.pronuncationLevel == 14)
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
            else if (gameManager.pronuncationLevel == 15)
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
            else if (gameManager.pronuncationLevel == 16)
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
            else if (gameManager.pronuncationLevel == 17)
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
            else if (gameManager.pronuncationLevel == 18)
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
            else if (gameManager.pronuncationLevel == 19)
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
            else if (gameManager.pronuncationLevel == 20)
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
            else if (gameManager.pronuncationLevel == 21)
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
            else if (gameManager.pronuncationLevel == 22)
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
            else if (gameManager.pronuncationLevel == 23)
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
            else if (gameManager.pronuncationLevel == 24)
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
            else if (gameManager.pronuncationLevel == 25)
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
            else if (gameManager.pronuncationLevel == 26)
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
            else if (gameManager.pronuncationLevel == 27)
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
            else if (gameManager.pronuncationLevel == 28)
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
