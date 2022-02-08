using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao : MonoBehaviour
{

    private Renderer rend;

    private void OnMouseOver()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.yellow;
        // Se botão direito do mouse pressionado, rotaciona para direita
        if (Input.GetMouseButtonDown(0))
        {


            transform.Rotate(0.0f, 0.0f, -45.0f, Space.Self);
        }
        // Se botão direito do mouse pressionado, rotaciona para esquerda
        else if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(Input.mousePosition);
            transform.Rotate(0.0f, 0.0f, 45.0f, Space.Self);
        }
    }

    private void OnMouseExit()
    {

        rend.material.color = Color.black;

    }

}
