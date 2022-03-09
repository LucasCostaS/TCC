using System.Diagnostics;
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
    private Collider2D colisorLixo;
    private GameObject lixo;
    private int ocupacao;
    private Vector3 posSnap = new Vector3();
    private Vector3 posReserva = new Vector3();
    private float posX;
    private float posY;
    private bool snap = true;

    void Start()
    {

        colisorLixo = Physics2D.OverlapBox(new Vector2(16.7f, 7.68f), new Vector2(1f, 2f), 0f);
        lixo = colisorLixo.gameObject;

    }

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
        if (Physics2D.IsTouching(colisorLixo, gameObject.GetComponent<BoxCollider2D>()))
        {
            lixo.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else
        {
            lixo.transform.localScale = new Vector3(0.667f, 0.667f, 1f);
        }

    }


    void OnMouseUp()
    {

        if (colisorLixo.IsTouching(gameObject.GetComponent<BoxCollider2D>()))
        {
            Destroy(gameObject.transform.parent.gameObject);
            lixo.transform.localScale = new Vector3(0.667f, 0.667f, 1f);
        }

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
        if (snap == true)
        {
            lugar.Set(posX, posY);
            Collider2D[] resultado = Physics2D.OverlapCircleAll(lugar, 2f);
            ocupacao = resultado.Length;
            if (ocupacao > 1)
            {
                if (transform.position.y >= lixo.transform.position.y - 2.56f)
                {
                    posReserva.Set(12.8f, transform.position.y - 5.2f, 0);
                    transform.position = posReserva;
                }
                else
                {
                    posReserva.Set(12.8f, transform.position.y, 0);
                }
            }
            else
            {
                transform.position = posSnap;
            }

            posX = 0;
            posY = 0;
        }

    }
}
