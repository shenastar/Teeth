using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragHandler : MonoBehaviour {

    public static GameObject grabbedItem;
    public static bool isDragging;
    Vector3 startPos;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            selectItem();
            startPos = grabbedItem.transform.position;
            isDragging = true;
        }

        if (Input.GetMouseButton(0))
        {

            grabbedItem.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            grabbedItem.transform.position = new Vector3(grabbedItem.transform.position.x, grabbedItem.transform.position.y, 0);
        }

        if (Input.GetMouseButtonUp(0))
        {
            grabbedItem.transform.position = startPos;
            grabbedItem = null;
            isDragging = false;
        }

    }

    void selectItem()
    {
        Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);

        RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);
        if (hit)
        {
            grabbedItem = hit.transform.tag == "dragable" ? hit.transform.gameObject : null;
        }
    }
}
