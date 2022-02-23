using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragnDrop : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;

    private SpriteRenderer rend;
    private float[] gradeX = new float[] { -7.68f, -2.56f, 2.56f, 7.68f };
    private float[] gradeY = new float[] { -7.68f, -2.56f, 2.56f, 7.68f };
    private float posX;
    private float posY;
    private bool snap = true;

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

    void OnMouseUp()
    {

        for (int i = 0; i < 4; i++)
        {

            if (transform.position.x >= gradeX[i] - 2.56f && transform.position.x < gradeX[i] + 2.56f)
            {
                posX = gradeX[i];
                snap = true;
            }
            if (transform.position.x > gradeX[3] + 2.56f)
            {
                snap = false;
            }
            if (transform.position.y >= gradeY[i] - 2.56f && transform.position.y < gradeY[i] + 2.56f)
            {
                posY = gradeY[i];
            }


        }
        Vector3 posFinal = new Vector3(posX, posY, screenPoint.z);
        if (snap == true)
        {
            transform.position = posFinal;
        }

    }
}
