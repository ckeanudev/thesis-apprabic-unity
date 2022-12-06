using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WriteLesson : MonoBehaviour
{
    public string lessonType;

    public GameObject lessonL1;
    public GameObject lessonL2;
    public GameObject lessonL3;
    public GameObject lessonL4;
    public GameObject lessonL5;
    public GameObject lessonL6;
    public GameObject lessonL7;
    public GameObject lessonL8;
    public GameObject lessonL9;
    public GameObject lessonL10;
    public GameObject lessonL11;
    public GameObject lessonL12;
    public GameObject lessonL13;
    public GameObject lessonL14;
    public GameObject lessonL15;
    public GameObject lessonL16;
    public GameObject lessonL17;
    public GameObject lessonL18;
    public GameObject lessonL19;
    public GameObject lessonL20;
    public GameObject lessonL21;
    public GameObject lessonL22;
    public GameObject lessonL23;
    public GameObject lessonL24;
    public GameObject lessonL25;
    public GameObject lessonL26;
    public GameObject lessonL27;
    public GameObject lessonL28;

    public GameObject lessonN1;
    public GameObject lessonN2;
    public GameObject lessonN3;
    public GameObject lessonN4;
    public GameObject lessonN5;
    public GameObject lessonN6;
    public GameObject lessonN7;
    public GameObject lessonN8;
    public GameObject lessonN9;
    public GameObject lessonN10;
    public GameObject lessonN11;

    GameManager gameManager;
    public GameObject gameM;

    private void Awake ()
    {
        gameManager = gameM.GetComponent<GameManager>();
    }

    private void OnEnable()
    {
        if (lessonType == "letters")
        {
            lessonL1.SetActive(false);
            lessonL2.SetActive(false);
            lessonL3.SetActive(false);
            lessonL4.SetActive(false);
            lessonL5.SetActive(false);
            lessonL6.SetActive(false);
            lessonL7.SetActive(false);
            lessonL8.SetActive(false);
            lessonL9.SetActive(false);
            lessonL10.SetActive(false);
            lessonL11.SetActive(false);
            lessonL12.SetActive(false);
            lessonL13.SetActive(false);
            lessonL14.SetActive(false);
            lessonL15.SetActive(false);
            lessonL16.SetActive(false);
            lessonL17.SetActive(false);
            lessonL18.SetActive(false);
            lessonL19.SetActive(false);
            lessonL20.SetActive(false);
            lessonL21.SetActive(false);
            lessonL22.SetActive(false);
            lessonL23.SetActive(false);
            lessonL24.SetActive(false);
            lessonL25.SetActive(false);
            lessonL26.SetActive(false);
            lessonL27.SetActive(false);
            lessonL28.SetActive(false);
        } 
        else if (lessonType == "numbers")
        {
            lessonN1.SetActive(false);
            lessonN2.SetActive(false);
            lessonN3.SetActive(false);
            lessonN4.SetActive(false);
            lessonN5.SetActive(false);
            lessonN6.SetActive(false);
            lessonN7.SetActive(false);
            lessonN8.SetActive(false);
            lessonN9.SetActive(false);
            lessonN10.SetActive(false);
            lessonN11.SetActive(false);
        }

        LessonRender();
    }

    public void LessonRender ()
    {
        if (lessonType == "letters")
        {
            if (gameManager.writingLevel == 1)
                lessonL1.SetActive(true);

            if (gameManager.writingLevel == 2)
                lessonL2.SetActive(true);

            if (gameManager.writingLevel == 3)
                lessonL3.SetActive(true);

            if (gameManager.writingLevel == 4)
                lessonL4.SetActive(true);

            if (gameManager.writingLevel == 5)
                lessonL5.SetActive(true);

            if (gameManager.writingLevel == 6)
                lessonL6.SetActive(true);

            if (gameManager.writingLevel == 7)
                lessonL7.SetActive(true);

            if (gameManager.writingLevel == 8)
                lessonL8.SetActive(true);

            if (gameManager.writingLevel == 9)
                lessonL9.SetActive(true);

            if (gameManager.writingLevel == 10)
                lessonL10.SetActive(true);

            if (gameManager.writingLevel == 11)
                lessonL11.SetActive(true);

            if (gameManager.writingLevel == 12)
                lessonL12.SetActive(true);

            if (gameManager.writingLevel == 13)
                lessonL13.SetActive(true);

            if (gameManager.writingLevel == 14)
                lessonL14.SetActive(true);

            if (gameManager.writingLevel == 15)
                lessonL15.SetActive(true);

            if (gameManager.writingLevel == 16)
                lessonL16.SetActive(true);

            if (gameManager.writingLevel == 17)
                lessonL17.SetActive(true);

            if (gameManager.writingLevel == 18)
                lessonL18.SetActive(true);


            if (gameManager.writingLevel == 19)
                lessonL19.SetActive(true);

            if (gameManager.writingLevel == 20)
                lessonL20.SetActive(true);

            if (gameManager.writingLevel == 21)
                lessonL21.SetActive(true);


            if (gameManager.writingLevel == 22)
                lessonL22.SetActive(true);

            if (gameManager.writingLevel == 23)
                lessonL23.SetActive(true);


            if (gameManager.writingLevel == 24)
                lessonL24.SetActive(true);

            if (gameManager.writingLevel == 25)
            {
                lessonL25.SetActive(true);
            }

            if (gameManager.writingLevel == 26)
                lessonL26.SetActive(true);

            if (gameManager.writingLevel == 27)
                lessonL27.SetActive(true);

            if (gameManager.writingLevel == 28)
                lessonL28.SetActive(true);

        }

        if(lessonType == "numbers")
        {
            if (gameManager.writingLevel == 1)
                lessonN1.SetActive(true);

            if (gameManager.writingLevel == 2)
                lessonN2.SetActive(true);

            if (gameManager.writingLevel == 3)
                lessonN3.SetActive(true);

            if (gameManager.writingLevel == 4)
                lessonN4.SetActive(true);

            if (gameManager.writingLevel == 5)
                lessonN5.SetActive(true);

            if (gameManager.writingLevel == 6)
                lessonN6.SetActive(true);

            if (gameManager.writingLevel == 7)
                lessonN7.SetActive(true);

            if (gameManager.writingLevel == 8)
                lessonN8.SetActive(true);

            if (gameManager.writingLevel == 9)
                lessonN9.SetActive(true);

            if (gameManager.writingLevel == 10)
                lessonN10.SetActive(true);

            if (gameManager.writingLevel == 11)
                lessonN11.SetActive(true);
        }
    }
}
