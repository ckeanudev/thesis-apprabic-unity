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
    public GameObject loadingObject;
    public GameObject videoObject;

    public int userScore = 0;

    private void OnEnable()
    {
        gameManager = gameM.GetComponent<GameManager>();

        showWinDialog = false;
        winContainer.SetActive(false);

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
        showWinDialog = false;
        if (writingCategoryType == "numbers" && gameManager.writingLevel >= 11)
        {
            gameManager.pageNumber = 1;
            gameManager.mainPageNumber = 1;
        }
        else if (writingCategoryType == "alphabets" && gameManager.writingLevel >= 28)
        {
            gameManager.pageNumber = 1;
            gameManager.mainPageNumber = 5;
        }
        else
        {
            gameManager.writingLevel += 1;
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
