using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resistores3 : MonoBehaviour
{

    public float resistencia = 1;
    public bool modificado = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().color = Color.yellow;


    }

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = Color.black;
    }

    void OnMouseDown()
    {


        gameObject.transform.GetChild(0).gameObject.SetActive(true);



    }

    public void setarResistencia(string texto)
    {
        resistencia = float.Parse(texto);
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        modificado = true;
    }
}
