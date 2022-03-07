using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoJogar : MonoBehaviour
{
    public GameObject menuInicial, menuFases;
    /*
        private AssetBundle myLoadedAssetBundle;
        private string[] scenePaths;
        void Start()
        {
            myLoadedAssetBundle = AssetBundle.LoadFromFile("Assets\Scenes");
            scenePaths = myLoadedAssetBundle.GetAllScenePaths();
        }*/

    public void PlayGame()
    {
        menuInicial.SetActive(false);
        menuFases.SetActive(true);
        //SceneManager.LoadScene(1);
    }
}
