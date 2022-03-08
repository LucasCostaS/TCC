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
    private Vector2 lugar = new Vector2();
    private int ocupacao;
    private Collider2d[] resultado = new Collider2d[];
    private Vector3 posSnap = new Vector3();
    private Vector3 posReserva = new Vector3();
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

    async void OnMouseUp()
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

        posSnap.Set(posX, posY, 0);
        /*
        vet = Physics2D.OverlapCircle(lugar, 0.1f);
        Debug.Log(vet);
        if (vet != null)
        {
            snap = false;
            posReserva.Set(7.68f + 5.12f, transform.position.y, 0);
            transform.position = posReserva;
        }*/
        if (snap == true)
        {
        /*lugar.Set(posX, posY);
        ocupacao = OverlapCircle(lugar, 0.1f, resultados);
        if (ocupacao>1){
        posReserva.Set(12.8f, transform.position.y, 0);
        transform.position = posReserva;
        }
        else{
          */transform.position = posSnap;
        }
        posX = 0;
        posY = 0;

    }
}
