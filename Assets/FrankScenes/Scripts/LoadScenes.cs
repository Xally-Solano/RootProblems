using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadScenes : MonoBehaviour
{

    public void TitleS()
    {
        SceneManager.LoadScene("TITLE_SCREEN");
    }

    public void MainM()
    {
        SceneManager.LoadScene("MAIN_MENU");
    }

    public void GAMEM()
    {
        SceneManager.LoadScene("GAME");
    }

    public void WINM()
    {
        SceneManager.LoadScene("WINSCREEN");
    }

    public void LOOSEM()
    {
        SceneManager.LoadScene("LOOSESCREEN");
    }

}
