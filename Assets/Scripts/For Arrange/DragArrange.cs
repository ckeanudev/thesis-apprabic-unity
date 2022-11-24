using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class DragArrange : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;

    public int orderDrag;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    
    public Vector2 startPosition;

    Arrange arrange;
    public GameObject arrangeA;

    private void OnEnable()
    {
        arrange = arrangeA.GetComponent<Arrange>();
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();

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
        //transform.position = new Vector2(startPosition.x, startPosition.y);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("OnPointerDOwn " + orderDrag.ToString());
        //indexCount = indexCount + 1;
        //Debug.Log("OnPointerDOwn");
    }
}
