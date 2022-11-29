using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayerUsers : MonoBehaviour
{
    PlayerStats playerPrefStats;
    public GameObject playerPrefS;

    public GameObject playerButton1;
    public GameObject playerButton2;
    public GameObject playerButton3; 

    public GameObject addPlayer1;
    public GameObject addPlayer2;
    public GameObject addPlayer3;

    private void OnEnable()
    {
        playerPrefStats = playerPrefS.GetComponent<PlayerStats>();

        string firstPlayer = PlayerPrefs.GetString("playerPrefUser1");
        string secondPlayer = PlayerPrefs.GetString("playerPrefUser2");
        string thirdPlayer = PlayerPrefs.GetString("playerPrefUser3");

        if (firstPlayer == "" || firstPlayer == null)
        {
            playerButton1.SetActive(false);
            addPlayer1.SetActive(true);
        }
        else
        {
            playerButton1.SetActive(true);
            addPlayer1.SetActive(false);
        }

        if (secondPlayer == "" || secondPlayer == null)
        {
            playerButton2.SetActive(false);
            addPlayer2.SetActive(true);
        }
        else
        {
            playerButton2.SetActive(true);
            addPlayer2.SetActive(false);
        }

        if (thirdPlayer == "" || thirdPlayer == null)
        {
            playerButton3.SetActive(false);
            addPlayer3.SetActive(true);
        }
        else
        {
            playerButton3.SetActive(true);
            addPlayer3.SetActive(false);
        }

    }

}
