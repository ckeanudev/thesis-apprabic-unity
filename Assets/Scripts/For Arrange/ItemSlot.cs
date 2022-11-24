using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    public bool isTest;

    public int arrangePosition;
    public Vector2 dropPosition;

    Arrange arrange;
    public GameObject arrangeA;

    TestScript arrangeTest;
    public GameObject arrangeT;

    private void OnEnable()
    {
        if(isTest)
        {
            arrangeTest = arrangeT.GetComponent<TestScript>();
        }
        else
        {
            arrange = arrangeA.GetComponent<Arrange>();
        }

        //------------------------------------------------------------

        if (dropPosition.x == 0)
        {
            dropPosition.x = transform.position.x;
        }

        if (dropPosition.y == 0)
        {
            dropPosition.y = transform.position.y;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        //Debug.Log(eventData.pointerDrag);

        //Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            //Debug.Log("DROP!");
            eventData.pointerDrag.GetComponent<RectTransform>().transform.position = new Vector2(dropPosition.x, dropPosition.y);

            //Debug.Log(eventData.pointerDrag.GetComponent<DragArrange>().orderDrag);

            if(arrangePosition == 1)
            {
                if (isTest)
                {
                    arrangeTest.firstPosFill = true;
                    if (eventData.pointerDrag.GetComponent<DragArrange>().orderDrag == 1)
                    {
                        arrangeTest.firstPosition = true;
                    }
                    else
                    {
                        arrangeTest.firstPosition = false;
                    }
                } else
                {
                    arrange.firstPosFill = true;
                    if (eventData.pointerDrag.GetComponent<DragArrange>().orderDrag == 1)
                    {
                        arrange.firstPosition = true;
                    }
                    else
                    {
                        arrange.firstPosition = false;
                    }
                }
            }

            else if (arrangePosition == 2)
            {
                if (isTest)
                {
                    arrangeTest.secondPosFill = true;
                    if (eventData.pointerDrag.GetComponent<DragArrange>().orderDrag == 2)
                    {
                        arrangeTest.secondPosition = true;
                    }
                    else
                    {
                        arrangeTest.secondPosition = false;
                    }
                }
                else
                {
                    arrange.secondPosFill = true;
                    if (eventData.pointerDrag.GetComponent<DragArrange>().orderDrag == 2)
                    {
                        arrange.secondPosition = true;
                    }
                    else
                    {
                        arrange.secondPosition = false;
                    }
                }
            }
            else if (arrangePosition == 3)
            {
                if (isTest)
                {
                    arrangeTest.thirdPosFill = true;
                    if (eventData.pointerDrag.GetComponent<DragArrange>().orderDrag == 3)
                    {
                        arrangeTest.thirdPosition = true;
                    }
                    else
                    {
                        arrangeTest.thirdPosition = false;
                    }
                }
                else
                {
                    arrange.thirdPosFill = true;
                    if (eventData.pointerDrag.GetComponent<DragArrange>().orderDrag == 3)
                    {
                        arrange.thirdPosition = true;
                    }
                    else
                    {
                        arrange.thirdPosition = false;
                    }
                }
            }
            else if (arrangePosition == 4)
            {
                if (isTest)
                {
                    arrangeTest.fourthPosFill = true;
                    if (eventData.pointerDrag.GetComponent<DragArrange>().orderDrag == 4)
                    {
                        arrangeTest.fourthPosition = true;
                    }
                    else
                    {
                        arrangeTest.fourthPosition = false;
                    }
                }
                else
                {
                    arrange.fourthPosFill = true;
                    if (eventData.pointerDrag.GetComponent<DragArrange>().orderDrag == 4)
                    {
                        arrange.fourthPosition = true;
                    }
                    else
                    {
                        arrange.fourthPosition = false;
                    }
                }
            }
            else if (arrangePosition == 5)
            {
                if (isTest)
                {
                    arrangeTest.fifthPosFill = true;
                    if (eventData.pointerDrag.GetComponent<DragArrange>().orderDrag == 5)
                    {
                        arrangeTest.fifthPosition = true;
                    }
                    else
                    {
                        arrangeTest.fifthPosition = false;
                    }
                } else
                {
                    arrange.fifthPosFill = true;
                    if (eventData.pointerDrag.GetComponent<DragArrange>().orderDrag == 5)
                    {
                        arrange.fifthPosition = true;
                    }
                    else
                    {
                        arrange.fifthPosition = false;
                    }
                }
                 
            }
        } 
        else
        {
            //Debug.Log("NICe NONE NICE NONC!!");
        }
    }
}
