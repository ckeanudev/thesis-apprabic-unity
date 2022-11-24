using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PreTestScript : MonoBehaviour
{
    public string testType;

    public TextMeshProUGUI testOrderText;

    public GameObject test1;
    public GameObject test2;
    public GameObject test3;
    public GameObject test4;
    public GameObject test5;
    public GameObject test6;
    public GameObject test7;
    public GameObject test8;
    public GameObject test9;
    public GameObject test10;
    public GameObject test11;
    public GameObject test12;
    public GameObject test13;
    public GameObject test14;
    public GameObject test15;
    public GameObject testResult;

    public GameObject orderCircle;

    public int testNumber = 1;
    public int testScore = 0;

    public void NextTest(int score)
    {
        testNumber += 1;
        testScore += score;
        Debug.Log("Test Number: " + testNumber.ToString());
        Debug.Log("Test Score: " + testScore.ToString());
    }

    private void Update()
    {
        if (testNumber < 16)
        {
            testOrderText.text = testNumber.ToString();
            orderCircle.SetActive(true);
        }
        else
        {
            orderCircle.SetActive(false);
        }

        if (testNumber == 1)
        {
            test1.SetActive(true);
            test2.SetActive(false);
            test3.SetActive(false);
            test4.SetActive(false);
            test5.SetActive(false);
            test6.SetActive(false);
            test7.SetActive(false);
            test8.SetActive(false);
            test9.SetActive(false);
            test10.SetActive(false);
            test11.SetActive(false);
            test12.SetActive(false);
            test13.SetActive(false);
            test14.SetActive(false);
            test15.SetActive(false);
            testResult.SetActive(false);
        }
        else if (testNumber == 2)
        {
            test1.SetActive(false);
            test2.SetActive(true);
        }
        else if (testNumber == 3)
        {
            test2.SetActive(false);
            test3.SetActive(true);
        }
        else if (testNumber == 4)
        {
            test3.SetActive(false);
            test4.SetActive(true);
        }
        else if (testNumber == 5)
        {
            test4.SetActive(false);
            test5.SetActive(true);
        }
        else if (testNumber == 6)
        {
            test5.SetActive(false);
            test6.SetActive(true);
        }
        else if (testNumber == 7)
        {
            test6.SetActive(false);
            test7.SetActive(true);
        }
        else if (testNumber == 8)
        {
            test7.SetActive(false);
            test8.SetActive(true);
        }
        else if (testNumber == 9)
        {
            test8.SetActive(false);
            test9.SetActive(true);
        }
        else if (testNumber == 10)
        {
            test9.SetActive(false);
            test10.SetActive(true);
        }
        else if (testNumber == 11)
        {
            test10.SetActive(false);
            test11.SetActive(true);
        }
        else if (testNumber == 12)
        {
            test11.SetActive(false);
            test12.SetActive(true);
        }
        else if (testNumber == 13)
        {
            test12.SetActive(false);
            test13.SetActive(true);
        }
        else if (testNumber == 14)
        {
            test13.SetActive(false);
            test14.SetActive(true);
        }
        else if (testNumber == 15)
        {
            test14.SetActive(false);
            test15.SetActive(true);
        }
        else if (testNumber == 16)
        {
            test15.SetActive(false);
            testResult.SetActive(true);
            //Debug.Log(testScore);
        }
    }

}
