using System.Diagnostics;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController2 : MonoBehaviour
{
    // Start is called before the first frame update
    public bool spawn;
    private Vector2 lugar = new Vector2(0.0f, 0.0f);
    private Collider2D vet, vet1;
    private float[] gradeX = new float[] { -7.68f, -2.56f, 2.56f, 7.68f };
    private float[] gradeY = new float[] { -7.68f, -2.56f, 2.56f, 7.68f };
    private Vector2[] posicao = new Vector2[16];
    private bool[] posicaoCorreta = new bool[16];
    public GameObject vitoria, sombra, pecas;
    // Start is called before the first frame update
    void Start()
    {
        spawn = true;
        for (int i = 0; i < gradeY.Length; i++)
        {
            for (int j = 0; j < gradeX.Length; j++)
            {
                posicao[(i * 4) + j].Set(gradeX[j], gradeY[i]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        vet = Physics2D.OverlapCircle(lugar, 0.1f);
        if (vet == null)
        {
            spawn = true;
        }


        for (int i = 0; i < posicaoCorreta.Length; i++)
        {
            vet1 = Physics2D.OverlapCircle(posicao[i], 0f);

            switch (i)
            {
                case 0:
                    if (vet1 != null && vet1.tag == "LinhaLPrefab" && Math.Ceiling(vet1.gameObject.transform.eulerAngles.z) == 90)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 1:

                    if (vet1 != null && vet1.tag == "LinhaRetaPrefab" && (Math.Ceiling(vet1.gameObject.transform.eulerAngles.z) == 0 || Math.Ceiling(vet1.gameObject.transform.eulerAngles.z) == 180))
                    {

                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 2:
                    if (vet1 != null && vet1.tag == "LinhaTPrefab" && Math.Ceiling(vet1.gameObject.transform.eulerAngles.z) == 180)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 3:
                    if (vet1 != null && vet1.tag == "LinhaLPrefab" && Math.Ceiling(vet1.gameObject.transform.eulerAngles.z) == 180)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 4:
                    if (vet1 != null && vet1.tag == "LinhaRetaPrefab" && (Math.Ceiling(vet1.gameObject.transform.eulerAngles.z) == 90 || Math.Ceiling(vet1.gameObject.transform.eulerAngles.z) == 270))
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 5:
                    if (vet1 == null)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 6:
                    if (vet1 != null && vet1.tag == "ResistorPrefab" && Math.Ceiling(vet1.gameObject.transform.eulerAngles.z) == 90)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 7:
                    if (vet1 != null && vet1.tag == "LinhaRetaPrefab" && (Math.Ceiling(vet1.gameObject.transform.eulerAngles.z) == 90 || Math.Ceiling(vet1.gameObject.transform.eulerAngles.z) == 270))
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 8:
                    if (vet1 != null && vet1.tag == "LinhaTPrefab" && Math.Ceiling(vet1.gameObject.transform.eulerAngles.z) == 90)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 9:
                    if (vet1 != null && vet1.tag == "FontePrefab" && Math.Ceiling(vet1.gameObject.transform.eulerAngles.z) == 0)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 10:
                    if (vet1 != null && vet1.tag == "LinhaLPrefab" && Math.Ceiling(vet1.gameObject.transform.eulerAngles.z) == 270)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 11:
                    if (vet1 != null && vet1.tag == "LinhaRetaPrefab" && (Math.Ceiling(vet1.gameObject.transform.eulerAngles.z) == 90 || Math.Ceiling(vet1.gameObject.transform.eulerAngles.z) == 270))
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 12:
                    if (vet1 != null && vet1.tag == "LinhaLPrefab" && Math.Ceiling(vet1.gameObject.transform.eulerAngles.z) == 0)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 13:
                    if (vet1 != null && vet1.tag == "ResistorPrefab" && Math.Ceiling(vet1.gameObject.transform.eulerAngles.z) == 0)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 14:
                    if (vet1 != null && vet1.tag == "LinhaRetaPrefab" && (Math.Ceiling(vet1.gameObject.transform.eulerAngles.z) == 0 || Math.Ceiling(vet1.gameObject.transform.eulerAngles.z) == 180))
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 15:
                    if (vet1 != null && vet1.tag == "LinhaLPrefab" && Math.Ceiling(vet1.gameObject.transform.eulerAngles.z) == 270)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                default:
                    break;
            }

        }
        int cont = 0;
        for (int i = 0; i < posicaoCorreta.Length; i++)
        {
            if (posicaoCorreta[i] == true)
                cont += 1;

        }
        if (cont >= 16)
        {
            vitoria.SetActive(true);
            sombra.SetActive(false);
            int k = pecas.transform.childCount;
            for (int i = 0; i < k; i++)
            {
                SpriteRenderer rend = pecas.transform.GetChild(i).GetChild(0).GetComponent<SpriteRenderer>();
                rend.color = Color.yellow;
            }
            //mudar as cores do circuito
            spawn = false;
        }


    }
}
