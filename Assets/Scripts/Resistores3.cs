using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Resistores3 : MonoBehaviour
{

    public float resistencia = 1;
    public bool modificado, reduzido, click;


    // Start is called before the first frame update
    void Start()
    {
        modificado = false;
        reduzido = false;
        click = true;
    }

    private void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().color = Color.yellow;
        if (reduzido == true)
        {
            transform.GetChild(1).gameObject.SetActive(true);

        }
    }

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = Color.black;
        if (reduzido == true)
        {
            transform.GetChild(1).gameObject.SetActive(false);

        }
    }

    void OnMouseDown()
    {

        if (reduzido == false && click == true)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            click = false;
        }
    }
    private void Update()
    {
        transform.GetChild(1).transform.GetChild(0).gameObject.GetComponent<TMP_Text>().SetText("Resistencia: " + GetComponent<Resistores3>().resistencia.ToString());
    }
    public void setarResistencia(string texto)
    {
        resistencia = float.Parse(texto);
        transform.GetChild(0).gameObject.SetActive(false);
        modificado = true;
        click = true;
    }
}
