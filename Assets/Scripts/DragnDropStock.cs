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
    //public int limiteMax;
    //private int limiteAtual;

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
        //limiteAtual -= 1;
        //screenPoint = Camera.main.WorldToScreenPoint(prefab.transform.position);
        //offset = prefab.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

    }

    /// <summary>
    /// OnGUI is called for rendering and handling GUI events.
    /// This function can be called multiple times per frame (one call per event).
    /// </summary>
   /* void OnGUI()
    {
        GUI.Box(new Rect(32, 0, 32, 128), limiteAtual.ToString());
    }
    colocar em um game controller
    */
}
