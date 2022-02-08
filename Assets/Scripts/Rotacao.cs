using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao : MonoBehaviour
{

    // private GameObject linha;
    // Start is called before the first frame update
    void Start()
    {
        //linha = GetComponent();
    }

    // Update is called once per frame
    void Update()
    {

        //linha = GetComponent(onMou);
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
