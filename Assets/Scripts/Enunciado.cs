using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enunciado : MonoBehaviour
{
    public GameObject objeto;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        objeto.SetActive(true);
    }
}
