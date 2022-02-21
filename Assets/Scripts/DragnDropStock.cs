using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragnDropStock : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    private SpriteRenderer rend;
    private string tipo;
    public GameObject prefab;


    private void OnMouseOver()
    {
        rend = GetComponent<SpriteRenderer>();
        rend.color = Color.yellow;
        tipo = gameObject.tag;

    }

    private void OnMouseExit()
    {
        rend.color = Color.black;
    }

    void OnMouseDown()
    {

        Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
        //screenPoint = Camera.main.WorldToScreenPoint(prefab.transform.position);
        //offset = prefab.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

    }

    /* void OnMouseDrag()
     {
         Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
         Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
         transform.position = cursorPosition;
     }*/
}
