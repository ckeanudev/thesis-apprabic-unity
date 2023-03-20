using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading : MonoBehaviour
{
    // *** ---- This script is for the loading animation object ---- *** //

    WritingUIScript writingUIScript;
    public GameObject writingUIS;

    public GameObject winDialogContent;

    void OnEnable()
    {
        writingUIScript = writingUIS.GetComponent<WritingUIScript>();

        StartCoroutine(ShowWinDialog());
    }

    public IEnumerator ShowWinDialog()
    {
        yield return new WaitForSeconds(1f);
        winDialogContent.SetActive(true);

        
    }
}
