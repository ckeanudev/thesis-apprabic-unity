using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandForTutsAnim : MonoBehaviour
{
    public string tutsType;
    public GameObject handAnim;

    void OnEnable ()
    {   
        if(handAnim != null)
            handAnim.SetActive(false);

        if (tutsType == "pretest1")
        {
            StartCoroutine(ForPreTest1());
        }

        if (tutsType == "pretest2")
        {
            StartCoroutine(ForPreTest2());
        }

        if (tutsType == "pretest3")
        {
            StartCoroutine(ForPreTest3());
        }

        if (tutsType == "lvlbtn")
        {
            StartCoroutine(ForLvlBtn());
        }

        if (tutsType == "write")
        {
            StartCoroutine(ForWrite());
        }

        if (tutsType == "prounounce")
        {
            StartCoroutine(ForPronounce());
        }

        if (tutsType == "arrange")
        {
            StartCoroutine(ForArrange());
        }
    }

    public IEnumerator ForPreTest1()
    {
        yield return new WaitForSeconds(15.0f);
        handAnim.SetActive(true);
    }

    public IEnumerator ForPreTest2()
    {
        yield return new WaitForSeconds(30.0f);
        handAnim.SetActive(true);
    }

    public IEnumerator ForPreTest3()
    {
        yield return new WaitForSeconds(27.0f);
        handAnim.SetActive(true);
    }

    public IEnumerator ForWrite()
    {
        yield return new WaitForSeconds(60.0f);
        handAnim.SetActive(true);
    }

    public IEnumerator ForPronounce()
    {
        yield return new WaitForSeconds(50.0f);
        handAnim.SetActive(true);
    }

    public IEnumerator ForArrange()
    {
        yield return new WaitForSeconds(25.0f);
        handAnim.SetActive(true);
    }

    public IEnumerator ForLvlBtn()
    {
        yield return new WaitForSeconds(48.0f);
        handAnim.SetActive(true);
    }
}
