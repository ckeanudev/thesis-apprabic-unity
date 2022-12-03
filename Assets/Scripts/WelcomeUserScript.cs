using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeUserScript : MonoBehaviour
{
    public string typeWelcome;
    
    public GameObject welcomeUser1;
    public GameObject welcomeUser2;

    public AudioSource buttonSoundEffect;

    private void OnEnable ()
    {
        welcomeUser1.SetActive(true);
        welcomeUser2.SetActive(false);
    }

    public void WelcomeUserNextBtn ()
    {
        buttonSoundEffect.Play();
        welcomeUser1.SetActive(false);
        welcomeUser2.SetActive(true);
    }
}
