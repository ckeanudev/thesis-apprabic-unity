using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class DragScript : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
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
        traceContent = traceC.GetComponent<Trace>();
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();

        //Debug.Log("Drag Enabled ---------------------------------------");
        indexCount = 0;
        
        //Debug.Log(transform.position);

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
        //Debug.Log("OnBeginDrag");
        canvasGroup.alpha = .8f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        indexCount = 0;
        transform.position = new Vector2(startPosition.x, startPosition.y);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("OnPointerDOwn " + orderDrag.ToString());
        if (indexCount <= 1)
            indexCount = indexCount + 1;

        //Debug.Log("Check1");
        traceContent.timerStartFunction();
    }

    private void Update()
    {
        if (indexCount == orderDragFinal)
        {
            //Debug.Log("Finished!!");
            traceContent.TracingCheck(orderDrag);
        }
    }

    // --------------------------------------------------- For Checkpoints --------------------------------------------------- //
    private void OnTriggerEnter2D(Collider2D other)
    {
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
