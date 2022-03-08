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
    private float[] gradeX = new float[] { -7.68f, -2.56f, 2.56f, 7.68f };
    private float[] gradeY = new float[] { -7.68f, -2.56f, 2.56f, 7.68f };
    private Vector2[] posicao = new Vector2[16];
    private bool[] posicaoCorreta = new bool[16];
    // Start is called before the first frame update
    async void Start()
    {
        spawn = true;
        for (int i = 0; i < gradeX.Length; i++)
        {
            for (int j = 0; j < gradeY.Length; j++)
            {
                posicao[(i * 4) + j].Set(gradeX[i], gradeY[j]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        vet = Physics2D.OverlapCircle(lugar, 1f);
        if (vet == null)
        {
            spawn = true;
        }


        for (int i = 0; i < posicaoCorreta.Length; i++)
        {
            vet = Physics2D.OverlapCircle(posicao[i], 0.5f);
            switch (i)
            {
                case 0:
                    if (vet.tag == "LinhaLPrefab" && vet.gameObject.transform.eulerAngles.z == 0)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 1:
                    if (vet.tag == "LinhaL_Base" && vet.gameObject.transform.eulerAngles.z == 0)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 0:
                    if (vet.tag == "LinhaL_Base" && vet.gameObject.transform.eulerAngles.z == 0)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 0:
                    if (vet.tag == "LinhaL_Base" && vet.gameObject.transform.eulerAngles.z == 0)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 0:
                    if (vet.tag == "LinhaL_Base" && vet.gameObject.transform.eulerAngles.z == 0)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 0:
                    if (vet.tag == "LinhaL_Base" && vet.gameObject.transform.eulerAngles.z == 0)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 0:
                    if (vet.tag == "LinhaL_Base" && vet.gameObject.transform.eulerAngles.z == 0)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 0:
                    if (vet.tag == "LinhaL_Base" && vet.gameObject.transform.eulerAngles.z == 0)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 0:
                    if (vet.tag == "LinhaL_Base" && vet.gameObject.transform.eulerAngles.z == 0)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 0:
                    if (vet.tag == "LinhaL_Base" && vet.gameObject.transform.eulerAngles.z == 0)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 0:
                    if (vet.tag == "LinhaL_Base" && vet.gameObject.transform.eulerAngles.z == 0)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 0:
                    if (vet.tag == "LinhaL_Base" && vet.gameObject.transform.eulerAngles.z == 0)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 0:
                    if (vet.tag == "LinhaL_Base" && vet.gameObject.transform.eulerAngles.z == 0)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 0:
                    if (vet.tag == "LinhaL_Base" && vet.gameObject.transform.eulerAngles.z == 0)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 0:
                    if (vet.tag == "LinhaL_Base" && vet.gameObject.transform.eulerAngles.z == 0)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 0:
                    if (vet.tag == "LinhaL_Base" && vet.gameObject.transform.eulerAngles.z == 0)
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



            //if (posicaoCorreta[1] == tru)
            vet = Physics2D.OverlapCircle(posicao[0], 0.5f);
            if (vet != null)
                Debug.Log(vet.tag);
        }

        /*/// <summary>
        /// OnGUI is called for rendering and handling GUI events.
        /// This function can be called multiple times per frame (one call per event).
        /// </summary>
        void OnGUI()
        {
            GUI.Box(new Rect(48, 16, 32, 32), limiteResistor.ToString());
            GUI.Box(new Rect(x, y, 32, 32), limiteFonte.ToString());
        }
        //colocar em um game controller*/
    }
