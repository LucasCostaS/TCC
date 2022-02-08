using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao : MonoBehaviour
{

   
    private void onMouseDown()
    {
     // Se botão direito do mouse pressionado, rotaciona para direita
     if (Input.GetMouseButtonDown(0))
        {

            Debug.Log(Input.mousePosition);
            transform.Rotate(0.0f, 0.0f, -45.0f, Space.Self);
        }
     // Se botão direito do mouse pressionado, rotaciona para esquerda
     if (Input.GetMouseButtonDown(1))
        {
            transform.Rotate(0.0f, 0.0f, 45.0f, Space.Self);
        }
    }

}
