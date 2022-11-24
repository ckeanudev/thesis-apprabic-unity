using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject openingPage;
    public GameObject mainPage;
    public GameObject writingAPage;
    public GameObject writingNPage;
    public GameObject pronunciationAPage;
    public GameObject pronunciationNPage;

    public GameObject preTestPage;
    public GameObject postTestPage;

    public GameObject arrangePage;


    public int pageNumber = 0;
    public int mainPageNumber = 1;

    public string writingCategory;
    public int writingLevel = 0;

    public string pronunciationCategory;
    public int pronuncationLevel = 0;

    public int arrangeLevel = 0;

    public void SetPageActive(int page)
    {
        pageNumber = page;
    }

    public void SetMainPageActive(int page)
    {
        mainPageNumber = page;
    }


    private void Update()
    {
        if (pageNumber == 0)
        {
            openingPage.SetActive(true);
            mainPage.SetActive(false);
            writingAPage.SetActive(false);
            writingNPage.SetActive(false);
            pronunciationAPage.SetActive(false);
            pronunciationNPage.SetActive(false);
            preTestPage.SetActive(false);
            postTestPage.SetActive(false);
            arrangePage.SetActive(false);
        }
        else if (pageNumber == 1)
        {
            openingPage.SetActive(false);
            mainPage.SetActive(true);
            writingAPage.SetActive(false);
            writingNPage.SetActive(false);
            pronunciationAPage.SetActive(false);
            pronunciationNPage.SetActive(false);
            preTestPage.SetActive(false);
            postTestPage.SetActive(false);
            arrangePage.SetActive(false);
        }
        else if (pageNumber == 2)
        {
            openingPage.SetActive(false);
            mainPage.SetActive(false);
            writingAPage.SetActive(true);
            writingNPage.SetActive(false);
            pronunciationAPage.SetActive(false);
            pronunciationNPage.SetActive(false);
            preTestPage.SetActive(false);
            postTestPage.SetActive(false);
            arrangePage.SetActive(false);
        }
        else if (pageNumber == 3)
        {
            openingPage.SetActive(false);
            mainPage.SetActive(false);
            writingAPage.SetActive(false);
            writingNPage.SetActive(true);
            pronunciationAPage.SetActive(false);
            pronunciationNPage.SetActive(false);
            preTestPage.SetActive(false);
            postTestPage.SetActive(false);
            arrangePage.SetActive(false);
        }
        else if (pageNumber == 4)
        {
            openingPage.SetActive(false);
            mainPage.SetActive(false);
            writingAPage.SetActive(false);
            writingNPage.SetActive(false);
            pronunciationAPage.SetActive(true);
            pronunciationNPage.SetActive(false);
            preTestPage.SetActive(false);
            postTestPage.SetActive(false);
            arrangePage.SetActive(false);
        }
        else if (pageNumber == 5)
        {
            openingPage.SetActive(false);
            mainPage.SetActive(false);
            writingAPage.SetActive(false);
            writingNPage.SetActive(false);
            pronunciationAPage.SetActive(false);
            pronunciationNPage.SetActive(true);
            preTestPage.SetActive(false);
            postTestPage.SetActive(false);
            arrangePage.SetActive(false);
        }
        else if (pageNumber == 6)
        {
            openingPage.SetActive(false);
            mainPage.SetActive(false);
            writingAPage.SetActive(false);
            writingNPage.SetActive(false);
            pronunciationAPage.SetActive(false);
            pronunciationNPage.SetActive(false);
            preTestPage.SetActive(true);
            postTestPage.SetActive(false);
            arrangePage.SetActive(false);
        }
        else if (pageNumber == 7)
        {
            openingPage.SetActive(false);
            mainPage.SetActive(false);
            writingAPage.SetActive(false);
            writingNPage.SetActive(false);
            pronunciationAPage.SetActive(false);
            pronunciationNPage.SetActive(false);
            preTestPage.SetActive(false);
            postTestPage.SetActive(true);
            arrangePage.SetActive(false);
        }
        else if (pageNumber == 8)
        {
            openingPage.SetActive(false);
            mainPage.SetActive(false);
            writingAPage.SetActive(false);
            writingNPage.SetActive(false);
            pronunciationAPage.SetActive(false);
            pronunciationNPage.SetActive(false);
            preTestPage.SetActive(false);
            postTestPage.SetActive(false);
            arrangePage.SetActive(true);
        }
        else if (pageNumber == 9)
        {
            openingPage.SetActive(false);
            mainPage.SetActive(false);
            writingAPage.SetActive(false);
            writingNPage.SetActive(false);
            pronunciationAPage.SetActive(false);
            pronunciationNPage.SetActive(false);
            preTestPage.SetActive(false);
            postTestPage.SetActive(false);
            arrangePage.SetActive(true);
        }
    }

    public void SetWritingA(string writingAUI)
    {
        Debug.Log(writingAUI);
        pageNumber = 2;
        if (writingAUI == "WA-1")
        {
            writingLevel = 1;
        }
        else if (writingAUI == "WA-2")
        {
            writingLevel = 2;
        }
        else if (writingAUI == "WA-3")
        {
            writingLevel = 3;
        }
        else if (writingAUI == "WA-4")
        {
            writingLevel = 4;
        }
        else if (writingAUI == "WA-5")
        {
            writingLevel = 5;
        }
        else if (writingAUI == "WA-6")
        {
            writingLevel = 6;
        }
        else if (writingAUI == "WA-7")
        {
            writingLevel = 7;
        }
        else if (writingAUI == "WA-8")
        {
            writingLevel = 8;
        }
        else if (writingAUI == "WA-9")
        {
            writingLevel = 9;
        }
        else if (writingAUI == "WA-10")
        {
            writingLevel = 10;
        }
        else if (writingAUI == "WA-11")
        {
            writingLevel = 11;
        }
        else if (writingAUI == "WA-12")
        {
            writingLevel = 12;
        }
        else if (writingAUI == "WA-13")
        {
            writingLevel = 13;
        }
        else if (writingAUI == "WA-14")
        {
            writingLevel = 14;
        }
        else if (writingAUI == "WA-15")
        {
            writingLevel = 15;
        }
        else if (writingAUI == "WA-16")
        {
            writingLevel = 16;
        }
        else if (writingAUI == "WA-17")
        {
            writingLevel = 17;
        }
        else if (writingAUI == "WA-18")
        {
            writingLevel = 18;
        }
        else if (writingAUI == "WA-19")
        {
            writingLevel = 19;
        }
        else if (writingAUI == "WA-20")
        {
            writingLevel = 20;
        }
        else if (writingAUI == "WA-21")
        {
            writingLevel = 21;
        }
        else if (writingAUI == "WA-22")
        {
            writingLevel = 22;
        }
        else if (writingAUI == "WA-23")
        {
            writingLevel = 23;
        }
        else if (writingAUI == "WA-24")
        {
            writingLevel = 24;
        }
        else if (writingAUI == "WA-25")
        {
            writingLevel = 25;
        }
        else if (writingAUI == "WA-26")
        {
            writingLevel = 26;
        }
        else if (writingAUI == "WA-27")
        {
            writingLevel = 27;
        }
        else if (writingAUI == "WA-28")
        {
            writingLevel = 28;
        }
    }

    public void SetWritingN(string writingNUI)
    {
        Debug.Log(writingNUI);

        pageNumber = 3;
        if (writingNUI == "WN-1")
        {
            writingLevel = 1;
        }
        else if (writingNUI == "WN-2")
        {
            writingLevel = 2;
        }
        else if (writingNUI == "WN-3")
        {
            writingLevel = 3;
        }
        else if (writingNUI == "WN-4")
        {
            writingLevel = 4;
        }
        else if (writingNUI == "WN-5")
        {
            writingLevel = 5;
        }
        else if (writingNUI == "WN-6")
        {
            writingLevel = 6;
        }
        else if (writingNUI == "WN-7")
        {
            writingLevel = 7;
        }
        else if (writingNUI == "WN-8")
        {
            writingLevel = 8;
        }
        else if (writingNUI == "WN-9")
        {
            writingLevel = 9;
        }
        else if (writingNUI == "WN-10")
        {
            writingLevel = 10;
        }
        else if (writingNUI == "WN-11")
        {
            writingLevel = 11;
        }
    }

    public void SetPronunciationA(string pronunciationAUI)
    {
        pageNumber = 4;
        if (pronunciationAUI == "PA-1")
        {
            pronuncationLevel = 1;
        }
        else if (pronunciationAUI == "PA-2")
        {
            pronuncationLevel = 2;
        }
        else if (pronunciationAUI == "PA-3")
        {
            pronuncationLevel = 3;
        }
        else if (pronunciationAUI == "PA-4")
        {
            pronuncationLevel = 4;
        }
        else if (pronunciationAUI == "PA-5")
        {
            pronuncationLevel = 5;
        }
        else if (pronunciationAUI == "PA-6")
        {
            pronuncationLevel = 6;
        }
        else if (pronunciationAUI == "PA-7")
        {
            pronuncationLevel = 7;
        }
        else if (pronunciationAUI == "PA-8")
        {
            pronuncationLevel = 8;
        }
        else if (pronunciationAUI == "PA-9")
        {
            pronuncationLevel = 9;
        }
        else if (pronunciationAUI == "PA-10")
        {
            pronuncationLevel = 10;
        }
        else if (pronunciationAUI == "PA-11")
        {
            pronuncationLevel = 11;
        }
        else if (pronunciationAUI == "PA-12")
        {
            pronuncationLevel = 12;
        }
        else if (pronunciationAUI == "PA-13")
        {
            pronuncationLevel = 13;
        }
        else if (pronunciationAUI == "PA-14")
        {
            pronuncationLevel = 14;
        }
        else if (pronunciationAUI == "PA-15")
        {
            pronuncationLevel = 15;
        }
        else if (pronunciationAUI == "PA-16")
        {
            pronuncationLevel = 16;
        }
        else if (pronunciationAUI == "PA-17")
        {
            pronuncationLevel = 17;
        }
        else if (pronunciationAUI == "PA-18")
        {
            pronuncationLevel = 18;
        }
        else if (pronunciationAUI == "PA-19")
        {
            pronuncationLevel = 19;
        }
        else if (pronunciationAUI == "PA-20")
        {
            pronuncationLevel = 20;
        }
        else if (pronunciationAUI == "PA-21")
        {
            pronuncationLevel = 21;
        }
        else if (pronunciationAUI == "PA-22")
        {
            pronuncationLevel = 22;
        }
        else if (pronunciationAUI == "PA-23")
        {
            pronuncationLevel = 23;
        }
        else if (pronunciationAUI == "PA-24")
        {
            pronuncationLevel = 24;
        }
        else if (pronunciationAUI == "PA-25")
        {
            pronuncationLevel = 25;
        }
        else if (pronunciationAUI == "PA-26")
        {
            pronuncationLevel = 26;
        }
        else if (pronunciationAUI == "PA-27")
        {
            pronuncationLevel = 27;
        }
        else if (pronunciationAUI == "PA-28")
        {
            pronuncationLevel = 28;
        }
    }

    public void SetPronunciationN(string pronunciationNUI)
    {
        pageNumber = 5;
        if (pronunciationNUI == "PN-1")
        {
            pronuncationLevel = 1;
        }
        else if (pronunciationNUI == "PN-2")
        {
            pronuncationLevel = 2;
        }
        else if (pronunciationNUI == "PN-3")
        {
            pronuncationLevel = 3;
        }
        else if (pronunciationNUI == "PN-4")
        {
            pronuncationLevel = 4;
        }
        else if (pronunciationNUI == "PN-5")
        {
            pronuncationLevel = 5;
        }
        else if (pronunciationNUI == "PN-6")
        {
            pronuncationLevel = 6;
        }
        else if (pronunciationNUI == "PN-7")
        {
            pronuncationLevel = 7;
        }
        else if (pronunciationNUI == "PN-8")
        {
            pronuncationLevel = 8;
        }
        else if (pronunciationNUI == "PN-9")
        {
            pronuncationLevel = 9;
        }
        else if (pronunciationNUI == "PN-10")
        {
            pronuncationLevel = 10;
        }
        else if (pronunciationNUI == "PN-11")
        {
            pronuncationLevel = 11;
        }
    }

    public void SetArrange(string arrange)
    {
        pageNumber = 8;
        if (arrange == "AR-1")
        {
            arrangeLevel = 1;
        }
        else if (arrange == "AR-2")
        {
            arrangeLevel = 2;
        }
        else if (arrange == "AR-3")
        {
            arrangeLevel = 3;
        }
        else if (arrange == "AR-4")
        {
            arrangeLevel = 4;
        }
        else if (arrange == "AR-5")
        {
            arrangeLevel = 5;
        }
        else if (arrange == "AR-6")
        {
            arrangeLevel = 6;
        }
        else if (arrange == "AR-7")
        {
            arrangeLevel = 7;
        }
        else if (arrange == "AR-8")
        {
            arrangeLevel = 8;
        }
        else if (arrange == "AR-9")
        {
            arrangeLevel = 9;
        }
        else if (arrange == "AR-10")
        {
            arrangeLevel = 10;
        }
        else if (arrange == "AR-11")
        {
            arrangeLevel = 11;
        }
        else if (arrange == "AR-12")
        {
            arrangeLevel = 12;
        }
        else if (arrange == "AR-13")
        {
            arrangeLevel = 13;
        }
        else if (arrange == "AR-14")
        {
            arrangeLevel = 14;
        }
        else if (arrange == "AR-15")
        {
            arrangeLevel = 15;
        }
        else if (arrange == "AR-16")
        {
            arrangeLevel = 16;
        }
        else if (arrange == "AR-17")
        {
            arrangeLevel = 17;
        }
        else if (arrange == "AR-18")
        {
            arrangeLevel = 18;
        }

    }

}
