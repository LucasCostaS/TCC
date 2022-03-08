using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController2 : MonoBehaviour
{
    // Start is called before the first frame update

    public int limiteResistor, limiteReta, limiteL, limiteT, limiteFonte, x, y;
    public bool spawn;
    private Vector2 lugar = new Vector2(0.0f, 0.0f);
    private Collider2D vet;
    // Start is called before the first frame update
    void Start()
    {
        spawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        vet = Physics2D.OverlapCircle(lugar, 1f);
        if (vet != null)
        {
            Debug.Log(vet.tag);
        }
        else
        {
            spawn = true;
        }


    }

    /// <summary>
    /// OnGUI is called for rendering and handling GUI events.
    /// This function can be called multiple times per frame (one call per event).
    /// </summary>
    void OnGUI()
    {
        GUI.Box(new Rect(48, 16, 32, 32), limiteResistor.ToString());
        GUI.Box(new Rect(x, y, 32, 32), limiteFonte.ToString());
    }
    //colocar em um game controller
}
