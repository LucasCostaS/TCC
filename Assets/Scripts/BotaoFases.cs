using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoFases : MonoBehaviour
{
    // Start is called before the first frame update
    private int i;
    void Start()
    {

    }

    // Update is called once per frame
    public void PlayGame()
    {
        //menuInicial.SetActive(false);
        //menuFases.SetActive(true);
        SceneManager.LoadScene(2);
    }
}

