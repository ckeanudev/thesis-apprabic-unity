using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoadUserButton : MonoBehaviour
{
    public int id;
    public TextMeshProUGUI playerNameText;
    public TextMeshProUGUI playerPointsText;
    public GameObject avatar1;
    public GameObject avatar2;
    public GameObject avatar3;
    public GameObject avatar4;
    public GameObject avatar5;
    public GameObject avatar6;
    public GameObject avatar7;
    public GameObject avatar8;
    public GameObject avatar9;
    public GameObject avatar10;

    public GameObject award;

    void OnEnable()
    {
        avatar1.SetActive(false);
        avatar2.SetActive(false);
        avatar3.SetActive(false);
        avatar4.SetActive(false);
        avatar5.SetActive(false);
        avatar6.SetActive(false);
        avatar7.SetActive(false);
        avatar8.SetActive(false);
        avatar9.SetActive(false);
        avatar10.SetActive(false);

        if (id == 1)
        {
            string firstPlayer = PlayerPrefs.GetString("playerPrefUser1");
            int firstPlayerAvatar = PlayerPrefs.GetInt("playerPrefUserAvatar1");

            int firstExpPoints = PlayerPrefs.GetInt("playerPrefUserExperiencePoints1");

            int firstGraduate = PlayerPrefs.GetInt("playerPrefUserGraduate1");

            playerNameText.text = firstPlayer.ToString();


            if(firstGraduate == 1)
            {
                playerPointsText.text = "Completed";
                award.SetActive(true);
            }
            else if (firstGraduate == 0)
            {
                playerPointsText.text = firstExpPoints.ToString() + " Points";
                award.SetActive(false);
            }

            if (firstPlayerAvatar == 1)
            {
                avatar1.SetActive(true);
            }
            else if (firstPlayerAvatar == 2)
            {
                avatar2.SetActive(true);
            }
            else if (firstPlayerAvatar == 3)
            {
                avatar3.SetActive(true);
            }
            else if (firstPlayerAvatar == 4)
            {
                avatar4.SetActive(true);
            }
            else if (firstPlayerAvatar == 5)
            {
                avatar5.SetActive(true);
            }
            else if (firstPlayerAvatar == 6)
            {
                avatar6.SetActive(true);
            }
            else if (firstPlayerAvatar == 7)
            {
                avatar7.SetActive(true);
            }
            else if (firstPlayerAvatar == 8)
            {
                avatar8.SetActive(true);
            }
            else if (firstPlayerAvatar == 9)
            {
                avatar9.SetActive(true);
            }
            else if (firstPlayerAvatar == 10)
            {
                avatar10.SetActive(true);
            }

        }
        else if (id == 2)
        {
            string secondPlayer = PlayerPrefs.GetString("playerPrefUser2");
            int secondPlayerAvatar = PlayerPrefs.GetInt("playerPrefUserAvatar2");

            int secondExpPoints = PlayerPrefs.GetInt("playerPrefUserExperiencePoints2");

            int secondGraduate = PlayerPrefs.GetInt("playerPrefUserGraduate2");

            playerNameText.text = secondPlayer.ToString();


            if (secondGraduate == 1)
            {
                playerPointsText.text = "Completed";
                award.SetActive(true);
            }
            else if (secondGraduate == 0)
            {
                playerPointsText.text = secondExpPoints.ToString() + " Points";
                award.SetActive(false);
            }

            if (secondPlayerAvatar == 1)
            {
                avatar1.SetActive(true);
            }
            else if (secondPlayerAvatar == 2)
            {
                avatar2.SetActive(true);
            }
            else if (secondPlayerAvatar == 3)
            {
                avatar3.SetActive(true);
            }
            else if (secondPlayerAvatar == 4)
            {
                avatar4.SetActive(true);
            }
            else if (secondPlayerAvatar == 5)
            {
                avatar5.SetActive(true);
            }
            else if (secondPlayerAvatar == 6)
            {
                avatar6.SetActive(true);
            }
            else if (secondPlayerAvatar == 7)
            {
                avatar7.SetActive(true);
            }
            else if (secondPlayerAvatar == 8)
            {
                avatar8.SetActive(true);
            }
            else if (secondPlayerAvatar == 9)
            {
                avatar9.SetActive(true);
            }
            else if (secondPlayerAvatar == 10)
            {
                avatar10.SetActive(true);
            }
        }
        else if (id == 3)
        {
            string thirdPlayer = PlayerPrefs.GetString("playerPrefUser3");
            int thirdPlayerAvatar = PlayerPrefs.GetInt("playerPrefUserAvatar3");

            int thirdExpPoints = PlayerPrefs.GetInt("playerPrefUserExperiencePoints3");

            int thirdGraduate = PlayerPrefs.GetInt("playerPrefUserGraduate3");

            playerNameText.text = thirdPlayer.ToString();

            

            if (thirdGraduate == 1)
            {
                playerPointsText.text = "Completed";
                award.SetActive(true);
            }
            else if (thirdGraduate == 0)
            {
                playerPointsText.text = thirdExpPoints.ToString() + " Points";
                award.SetActive(false);
            }

            if (thirdPlayerAvatar == 1)
            {
                avatar1.SetActive(true);
            }
            else if (thirdPlayerAvatar == 2)
            {
                avatar2.SetActive(true);
            }
            else if (thirdPlayerAvatar == 3)
            {
                avatar3.SetActive(true);
            }
            else if (thirdPlayerAvatar == 4)
            {
                avatar4.SetActive(true);
            }
            else if (thirdPlayerAvatar == 5)
            {
                avatar5.SetActive(true);
            }
            else if (thirdPlayerAvatar == 6)
            {
                avatar6.SetActive(true);
            }
            else if (thirdPlayerAvatar == 7)
            {
                avatar7.SetActive(true);
            }
            else if (thirdPlayerAvatar == 8)
            {
                avatar8.SetActive(true);
            }
            else if (thirdPlayerAvatar == 9)
            {
                avatar9.SetActive(true);
            }
            else if (thirdPlayerAvatar == 10)
            {
                avatar10.SetActive(true);
            }
        }

    }

}
