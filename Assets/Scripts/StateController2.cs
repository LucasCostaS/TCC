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
                    if (vet.tag == "LinhaLPrefab" && math.Ceiling(vet.gameObject.transform.eulerAngles.z) == 90)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 1:
                    if (vet.tag == "LinhaRetaPrefab" && (math.Ceiling(vet.gameObject.transform.eulerAngles.z) == 0 || math.Ceiling(vet.gameObject.transform.eulerAngles.z) == 180))
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 2:
                    if (vet.tag == "LinhaTPrefab" && math.Ceiling(vet.gameObject.transform.eulerAngles.z) == 180)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 3:
                    if (vet.tag == "LinhaLPrefab" && math.Ceiling(vet.gameObject.transform.eulerAngles.z) == 180)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 4:
                    if (vet.tag == "LinhaRetaPrefab" && (math.Ceiling(vet.gameObject.transform.eulerAngles.z) == 90 || math.Ceiling(vet.gameObject.transform.eulerAngles.z) == 270))
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 5:
                    if (vet == null)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 6:
                    if (vet.tag == "ResistorPrefab" && math.Ceiling(vet.gameObject.transform.eulerAngles.z) == 90)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 7:
                    if (vet.tag == "LinhaRetaPrefab" && (math.Ceiling(vet.gameObject.transform.eulerAngles.z) == 90 || math.Ceiling(vet.gameObject.transform.eulerAngles.z) == 270))
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 8:
                    if (vet.tag == "LinhaTPrefab" && math.Ceiling(vet.gameObject.transform.eulerAngles.z) == 45)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 9:
                    if (vet.tag == "FontePrefab" && math.Ceiling(vet.gameObject.transform.eulerAngles.z) == 0)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 10:
                    if (vet.tag == "LinhaLPrefab" && math.Ceiling(vet.gameObject.transform.eulerAngles.z) == 270)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 11:
                    if (vet.tag == "LinhaRetaPrefab" && (math.Ceiling(vet.gameObject.transform.eulerAngles.z) == 90 || math.Ceiling(vet.gameObject.transform.eulerAngles.z) == 270))
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 12:
                    if (vet.tag == "LinhaLPrefab" && math.Ceiling(vet.gameObject.transform.eulerAngles.z) == 0)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 13:
                    if (vet.tag == "ResistorPrefab" && math.Ceiling(vet.gameObject.transform.eulerAngles.z) == 0)
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 14:
                    if (vet.tag == "LinhaRetaPrefab" && (math.Ceiling(vet.gameObject.transform.eulerAngles.z) == 0 || math.Ceiling(vet.gameObject.transform.eulerAngles.z) == 180))
                    {
                        posicaoCorreta[i] = true;
                    }
                    else
                    {
                        posicaoCorreta[i] = false;
                    }
                    break;
                case 15:
                    if (vet.tag == "LinhaLPrefab" && math.Ceiling(vet.gameObject.transform.eulerAngles.z) == 270)
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
           for(int i = 0; i < posicaoCorreta.Lenght; i++){
               if (posicaoCorreta[i] == true)
               cont++;
           }
           if (cont==16){
           //ativar screen de vitoria
           //mudar as cores do circuito
           spawn = false;
           }

      
    }
