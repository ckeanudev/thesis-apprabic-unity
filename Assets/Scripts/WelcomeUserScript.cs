using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeUserScript : MonoBehaviour
{
    public string typeWelcome;
    
    public GameObject welcomeUser1;
    public GameObject welcomeUser2;

    private void OnEnable ()
    {
        welcomeUser1.SetActive(true);
        welcomeUser2.SetActive(false);
    }

    public void WelcomeUserNextBtn ()
    {
        welcomeUser1.SetActive(false);
        welcomeUser2.SetActive(true);
    }
}
