using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botoes : MonoBehaviour
{

    public GameObject menuInicial, menuFases;
    public void BotaoJogar()
    {
        menuInicial.SetActive(false);
        menuFases.SetActive(true);
        //SceneManager.LoadScene(1);
    }

    public void Fase1()
    {
        SceneManager.LoadScene(1);
    }

    public void Fase2()
    {
        SceneManager.LoadScene(2);
    }

    public void VoltarMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void BotaoSair()
    {
        Application.Quit();
    }


}
