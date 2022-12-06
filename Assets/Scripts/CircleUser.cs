using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleUser : MonoBehaviour
{
    public string circleType;
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

    PlayerStats playerPrefStats;
    public GameObject playerPrefS;

    private void Awake()
    {
        playerPrefStats = playerPrefS.GetComponent<PlayerStats>();
    }

    private void OnEnable ()
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

        if (playerPrefStats.playerPrefID == 1)
        {
            int firstPlayerAvatar = PlayerPrefs.GetInt("playerPrefUserAvatar1");
            int firstGraduate = PlayerPrefs.GetInt("playerPrefUserGraduate1");
            //Debug.Log("Circle User: " + firstPlayerAvatar.ToString());

            if (circleType == "circleUser")
            {
                if (firstGraduate == 1)
                    award.SetActive(true);

                if (firstGraduate == 0)
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
        else if (playerPrefStats.playerPrefID == 2)
        {
            int secondPlayerAvatar = PlayerPrefs.GetInt("playerPrefUserAvatar2");
            int secondGraduate = PlayerPrefs.GetInt("playerPrefUserGraduate2");
            //Debug.Log("Circle User: " + secondPlayerAvatar.ToString());

            if (circleType == "circleUser")
            {
                if (secondGraduate == 1)
                    award.SetActive(true);

                if (secondGraduate == 0)
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
        else if (playerPrefStats.playerPrefID == 3)
        {
            int thirdPlayerAvatar = PlayerPrefs.GetInt("playerPrefUserAvatar3");
            int thirdGraduate = PlayerPrefs.GetInt("playerPrefUserGraduate3");
            //Debug.Log("Circle User: " + thirdPlayerAvatar.ToString());

            if (circleType == "circleUser")
            {
                if (thirdGraduate == 1)
                    award.SetActive(true);

                if (thirdGraduate == 0)
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

    //private void Update ()
    //{
    //    if (playerPrefStats.playerPrefID == 1)
    //    {
    //        int firstGraduate = PlayerPrefs.GetInt("playerPrefUserGraduate1");

    //        if (firstGraduate == 1)
    //            award.SetActive(true);

    //        else if (firstGraduate == 0)
    //            award.SetActive(false);

    //    }
    //    else if (playerPrefStats.playerPrefID == 2)
    //    {
    //        int secondGraduate = PlayerPrefs.GetInt("playerPrefUserGraduate2");

    //        if (secondGraduate == 1)
    //            award.SetActive(true);

    //        else if (secondGraduate == 0)
    //            award.SetActive(false);
    //    }
    //    else if (playerPrefStats.playerPrefID == 3)
    //    {
    //        int thirdGraduate = PlayerPrefs.GetInt("playerPrefUserGraduate3");

    //        if (thirdGraduate == 1)
    //            award.SetActive(true);

    //        else if (thirdGraduate == 0)
    //            award.SetActive(false);
    //    }

    //}
}
