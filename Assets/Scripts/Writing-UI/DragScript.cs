using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class DragScript : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    // *** ---- This script is for the Writing Module specially for the object that will drag by the user in order to write or follow the path ---- *** //

    [SerializeField] private Canvas canvas;

    public int orderDrag;
    public int orderDragFinal;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    public int indexCount = 0;

    public Vector2 startPosition; 

    Trace traceContent;
    public GameObject traceC;

    void OnEnable()
    {
        // *** ---- the OnEnable function will be call when the page loads and it will get the components and objects with a scripts ---- *** //

        traceContent = traceC.GetComponent<Trace>();
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();

        indexCount = 0;
        
        if (startPosition.x == 0)
        {
            startPosition.x = transform.position.x;
        }

        if (startPosition.y == 0)
        {
            startPosition.y = transform.position.y;
        }

        transform.position = new Vector2(startPosition.x, startPosition.y);

        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        // *** ---- the OnBeginDrag function will be call when the user begin to drag the object to write ---- *** //

        canvasGroup.alpha = .8f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // *** ---- the OnDrag function will be call when the user is dragging the object ---- *** //

        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // *** ---- the OnEndDrag function will be call when the user finished dragging the object ---- *** //

        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        indexCount = 0;
        transform.position = new Vector2(startPosition.x, startPosition.y);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // *** ---- the OnPointerDown function will be call when the user hold or click the object before dragging it ---- *** //

        if (indexCount <= 1)
            indexCount = indexCount + 1;

        traceContent.timerStartFunction();
    }

    private void Update()
    {
        // *** ---- the Update function will be call every second when the current page load and it will check the tracing on the Writing Module ---- *** //

        if (indexCount == orderDragFinal)
        {
            traceContent.TracingCheck(orderDrag);
        }
    }

    // --------------------------------------------------- For Checkpoints --------------------------------------------------- //
    private void OnTriggerEnter2D(Collider2D other)
    {
        // *** ---- the OnTriggerEnter2D function will be call when the user grads the onject to the checkpoints and check if it is correct order ---- *** //

        if (other.gameObject.name == "Checkpoint1" && indexCount == 1)
        {
            indexCount = indexCount + 1;
            //Debug.Log("Check2");
        }
        else if (other.gameObject.name == "Checkpoint2" && indexCount == 2)
        {
            indexCount = indexCount + 1;
            //Debug.Log("Check3");
        }
        else if (other.gameObject.name == "Checkpoint3" && indexCount == 3)
        {
            indexCount = indexCount + 1;
            //Debug.Log("Check4");
        }
        else if (other.gameObject.name == "Checkpoint4" && indexCount == 4)
        {
            indexCount = indexCount + 1;
            //Debug.Log("Check5");
        }
        else if (other.gameObject.name == "Checkpoint5" && indexCount == 5)
        {
            indexCount = indexCount + 1;
            //Debug.Log("Check6");
        }
        else if (other.gameObject.name == "Checkpoint6" && indexCount == 6)
        {
            indexCount = indexCount + 1;
            //Debug.Log("Check7");
        }
        else if (other.gameObject.name == "Checkpoint7" && indexCount == 7)
        {
            indexCount = indexCount + 1;
            //Debug.Log("Check8");
        }
        else if (other.gameObject.name == "Checkpoint8" && indexCount == 8)
        {
            indexCount = indexCount + 1;
            //Debug.Log("Check9");
        }
        else if (other.gameObject.name == "Checkpoint9" && indexCount == 9)
        {
            indexCount = indexCount + 1;
            //Debug.Log("Check10");
        }
        else if (other.gameObject.name == "Checkpoint10" && indexCount == 10)
        {
            indexCount = indexCount + 1;
            //Debug.Log("Check11");
        }

    }

}
