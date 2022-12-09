using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlBtnTutsScript : MonoBehaviour
{
    public int order;
    public GameObject hand;
    
    void OnEnable()
    {
        //hand.SetActive(false);
        //hand.SetActive(true);
        StartCoroutine(Show1stHand());
        StartCoroutine(Show2ndHand());
        StartCoroutine(Show3rdHand());
        StartCoroutine(HideHands());
    }

    public IEnumerator Show1stHand()
    {
        yield return new WaitForSeconds(6.0f);
        if (order == 1)
        {
            Debug.Log("1st Hand Go!");
            hand.SetActive(true);
        }
    }

    public IEnumerator Show2ndHand()
    {
        yield return new WaitForSeconds(21.0f);
        if (order == 1)
            hand.SetActive(false);
        if (order == 2)
        {
            Debug.Log("2nd Hand Go!");
            hand.SetActive(true);
        }
    }

    public IEnumerator Show3rdHand()
    {
        yield return new WaitForSeconds(38.0f);
        if (order == 2)
            hand.SetActive(false);
        if (order == 3)
        {
            Debug.Log("3rd Hand Go!");
            hand.SetActive(true);
        }
    }

    public IEnumerator HideHands()
    {
        yield return new WaitForSeconds(50.0f);
        hand.SetActive(false);
    }
}
