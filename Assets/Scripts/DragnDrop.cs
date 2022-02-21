using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragnDrop : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;

    private SpriteRenderer rend;

    private void OnMouseOver()
    {
        rend = GetComponent<SpriteRenderer>();
        rend.color = Color.yellow;

    }

    private void OnMouseExit()
    {
        rend.color = Color.black;
    }

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
        transform.position = cursorPosition;
    }
}
