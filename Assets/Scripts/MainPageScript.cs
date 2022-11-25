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

    GameManager gameManager;
    public GameObject gameM;

    private void Awake()
    {
        gameManager = gameM.GetComponent<GameManager>();
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

        backButton.SetActive(false);

        MainPageRender();
    }

    public void ShowPage(int page)
    {
        gameManager.mainPageNumber = page;
    }

    public void ShowUser(int show)
    {
        if (show == 1)
        {
            showUser.SetActive(true);
        }
        else if (show == 0)
        {
            showUser.SetActive(false);
        }
    }

    public void BackPage()
    {
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

            testMenu.SetActive(false);
            arrangePage.SetActive(true);

            topTitleText.text = "Arrange";
            backButton.SetActive(true);
        }
    }

}
