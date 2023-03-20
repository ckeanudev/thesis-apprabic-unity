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
        // *** ---- the OnBeginDrag function will be call everytime th user begin to drag the letter or number to the empty slot in order to arrange them ---- *** //

        canvasGroup.alpha = .8f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // *** ---- the OnDrag function will be call when the user will drag the object ---- *** //

        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // *** ---- the OnEndDrag function will be call when the user stop dragging the object ---- *** //

        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        //transform.position = new Vector2(startPosition.x, startPosition.y);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // *** ---- the OnPointerDown function will be call when the user click the object ---- *** //

        //Debug.Log("OnPointerDOwn " + orderDrag.ToString());
        //indexCount = indexCount + 1;
        //Debug.Log("OnPointerDOwn");
    }
}
