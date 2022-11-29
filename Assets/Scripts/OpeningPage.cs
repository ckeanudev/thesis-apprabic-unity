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

    PlayerStats playerPrefStats;
    public GameObject playerPrefS;

    void OnEnable()
    {
        sqliteScript = scriptDB.GetComponent<SQLiteScript>();
 
        playerPrefStats = playerPrefS.GetComponent<PlayerStats>();

        warningText.text = "";

        userAppContent.SetActive(false);
    }

    public void GetFieldText(string name)
    {
        nameText = name;
    }

    public void GetAvatarID(int avatar)
    {
        avatarID = avatar;

        //Debug.Log(avatarID);
        //Debug.Log(nameText);

        string firstPlayer = PlayerPrefs.GetString("playerPrefUser1");
        string secondPlayer = PlayerPrefs.GetString("playerPrefUser2");
        string thirdPlayer = PlayerPrefs.GetString("playerPrefUser3");

        if (firstPlayer == "" || firstPlayer == null)
        {
            PlayerPrefs.SetString("playerPrefUser1", nameText);
            PlayerPrefs.SetInt("playerPrefUserAvatar1", avatarID);
            playerPrefStats.playerPrefID = 1;
        }
        else if (secondPlayer == "" || secondPlayer == null)
        {
            PlayerPrefs.SetString("playerPrefUser2", nameText);
            PlayerPrefs.SetInt("playerPrefUserAvatar2", avatarID);
            playerPrefStats.playerPrefID = 2;
        }
        else if (thirdPlayer == "" || thirdPlayer == null)
        {
            PlayerPrefs.SetString("playerPrefUser3", nameText);
            PlayerPrefs.SetInt("playerPrefUserAvatar3", avatarID);
            playerPrefStats.playerPrefID = 3;
        }

        contentPage = 4;
    }

    public void ForStartButton ()
    {
        string firstPlayer = PlayerPrefs.GetString("playerPrefUser1");
        string secondPlayer = PlayerPrefs.GetString("playerPrefUser2");
        string thirdPlayer = PlayerPrefs.GetString("playerPrefUser3");

        userAppContent.SetActive(true);
        if ((firstPlayer == "" || firstPlayer == null) && (secondPlayer == "" || secondPlayer == null) && (thirdPlayer == "" || thirdPlayer == null)  )
        {
            contentPage = 1;
        }
        else
        {
            contentPage = 3;
        }
    }

    public void ForChoosePlayerBtn (int id)
    {
        playerPrefStats.playerPrefID = id;
        contentPage = 4;
    }

    public void ShowContent(int content)
    {
        userAppContent.SetActive(true);

        if (content == 0)
        {
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
