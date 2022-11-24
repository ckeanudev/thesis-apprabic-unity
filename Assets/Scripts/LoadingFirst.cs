using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingFirst : MonoBehaviour
{
    OpeningPage openingPage;
    public GameObject openingP;

    GameManager gameManager;
    public GameObject gameM;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = gameM.GetComponent<GameManager>();
        openingPage = openingP.GetComponent<OpeningPage>();
        StartCoroutine(CloseUserContent());
    }

    public IEnumerator CloseUserContent()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("NICE!");
        gameManager.pageNumber = 1;
        openingPage.userAppContent.SetActive(false);
    }
}
