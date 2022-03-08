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

    public GameObject state;
    private StateController2 controlador;
    private int limite;
    private void Start()
    {
        controlador = state.GetComponent<StateController2>();
    }


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
        switch (gameObject.tag)
        {
            case "Resistor":
                limite = controlador.limiteResistor;
                if (controlador.limiteResistor > 0 && controlador.spawn == true)
                    controlador.limiteResistor -= 1;
                break;

            case "Fonte":
                limite = controlador.limiteFonte;
                if (controlador.limiteFonte > 0 && controlador.spawn == true)
                    controlador.limiteFonte -= 1;
                break;

            case "LinhaL":
                limite = controlador.limiteL;
                if (controlador.limiteL > 0 && controlador.spawn == true)
                    controlador.limiteL -= 1;
                break;

            case "LinhaReta":
                limite = controlador.limiteReta;
                if (controlador.limiteReta > 0 && controlador.spawn == true)
                    controlador.limiteReta -= 1;
                break;

            case "LinhaT":
                limite = controlador.limiteT;
                if (controlador.limiteT > 0 && controlador.spawn == true)
                    controlador.limiteT -= 1;
                break;
        }

        if (controlador.spawn == true && limite > 0)
        {
            Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
            controlador.spawn = false;
        }

        //limiteAtual -= 1;
        //screenPoint = Camera.main.WorldToScreenPoint(prefab.transform.position);
        //offset = prefab.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

    }


}
