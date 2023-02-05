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
        SceneManager.LoadScene("NIVELCENEMIGOS");
    }

    public void WINM()
    {
        SceneManager.LoadScene("WINSCREEN");
    }

    public void LOOSEM()
    {
        SceneManager.LoadScene("LOOSESCREEN");
    }

    public void TIME0()
    {
        Time.timeScale = 0f;
    }

    public void TIME1()
    {
        Time.timeScale = 1.0f;
    }

    public void QUIT()
    {
        Application.Quit();
    }

    public void INTRO()
    {
        SceneManager.LoadScene("INTRO");
    }

}
