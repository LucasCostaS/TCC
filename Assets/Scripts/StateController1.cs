using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController1 : MonoBehaviour
{
    // Start is called before the first frame update
    private bool b1 = false;
    public GameObject fase, botao;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(Math.Ceiling(fase.transform.GetChild(0).transform.eulerAngles.z));
        if (Math.Ceiling(fase.transform.GetChild(0).transform.eulerAngles.z) == 0 &&
        Math.Ceiling(fase.transform.GetChild(1).transform.eulerAngles.z) == 0 &&
        Math.Ceiling(fase.transform.GetChild(2).transform.eulerAngles.z) == 0 &&
        Math.Ceiling(fase.transform.GetChild(3).transform.eulerAngles.z) == 0 &&
        Math.Ceiling(fase.transform.GetChild(4).transform.eulerAngles.z) == 270 &&
        Math.Ceiling(fase.transform.GetChild(5).transform.eulerAngles.z) == 90 &&
        Math.Ceiling(fase.transform.GetChild(6).transform.eulerAngles.z) == 0 &&
        Math.Ceiling(fase.transform.GetChild(7).transform.eulerAngles.z) == 0 &&
        Math.Ceiling(fase.transform.GetChild(8).transform.eulerAngles.z) == 0 &&
        Math.Ceiling(fase.transform.GetChild(9).transform.eulerAngles.z) == 270 &&
        Math.Ceiling(fase.transform.GetChild(10).transform.eulerAngles.z) == 90 &&
        Math.Ceiling(fase.transform.GetChild(11).transform.eulerAngles.z) == 0 &&
        Math.Ceiling(fase.transform.GetChild(12).transform.eulerAngles.z) == 0 &&
        Math.Ceiling(fase.transform.GetChild(13).transform.eulerAngles.z) == 0 &&
        Math.Ceiling(fase.transform.GetChild(14).transform.eulerAngles.z) == 180)
            b1 = true;
        else
            b1 = false;

        if (b1 == true)
        {
            for (int i = 0; i < 15; i++)
            {
                SpriteRenderer rend = fase.transform.GetChild(i).GetComponent<SpriteRenderer>();
                rend.color = Color.yellow;
            }

            botao.SetActive(true);

        }


    }
}
