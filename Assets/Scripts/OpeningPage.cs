using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OpeningPage : MonoBehaviour
{
    public GameObject userAppContent;
    public GameObject createUserContent;
    public GameObject chooseAvatarContent;
    public GameObject loadUsersContent;
    public GameObject loadingContent;

    SQLiteScript sqliteScript;
    public GameObject scriptDB;

    public TextMeshProUGUI warningText;

    public int contentPage = 1;

    public string nameText = "";
    public int avatarID = 0;

    void Start()
    {
        sqliteScript = scriptDB.GetComponent<SQLiteScript>();
        warningText.text = "";

        userAppContent.SetActive(false);
    }

    public void GetFieldText(string name)
    {
        nameText = name;
        Debug.Log(nameText);
    }

    public void GetAvatarID(int avatar)
    {
        avatarID = avatar;
        Debug.Log(avatarID);
        //sqliteScript.CreateNewUserApp(nameText, avatarID);
        contentPage = 4;
    }

    public void ShowContent(int content)
    {
        if (content == 0)
        {
            userAppContent.SetActive(true);
            contentPage = 1;
        }
        else if (content == 1)
        {
            // For Creating Username
            contentPage = 1;
        }
        else if (content == 2)
        {
            // For Choosing Avatar
            contentPage = 2;
        }
        else if (content == 3)
        {
            contentPage = 3;
        }
        else if (content == 4)
        {
            contentPage = 4;
        }
    }

    public IEnumerator CloseUserContent()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("NICE!");
        userAppContent.SetActive(false);
        contentPage = 2;
    }


    private void Update()
    {
        if (contentPage == 1)
        {
            createUserContent.SetActive(true);
            chooseAvatarContent.SetActive(false);
            loadUsersContent.SetActive(false);
            loadUsersContent.SetActive(false);
        }
        else if (contentPage == 2)
        {
            createUserContent.SetActive(false);
            chooseAvatarContent.SetActive(true);
            loadUsersContent.SetActive(false);
            loadingContent.SetActive(false);
        }
        else if (contentPage == 3)
        {
            createUserContent.SetActive(false);
            chooseAvatarContent.SetActive(false);
            loadUsersContent.SetActive(true);
            loadingContent.SetActive(false);
        }
        else if (contentPage == 4)
        {
            createUserContent.SetActive(false);
            chooseAvatarContent.SetActive(false);
            loadUsersContent.SetActive(false);
            loadingContent.SetActive(true);
        }
    }

    

}
