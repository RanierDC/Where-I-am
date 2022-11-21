using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controleDoMenu : MonoBehaviour
{
    public void botaoNao()
    {
        SceneManager.LoadScene("Menu");
    }

    public void botaoIniciar()
    {
        SceneManager.LoadScene("Cabana");
    }

    public void botaoLabirintoUm()
    {
        SceneManager.LoadScene("Labirinto1");
    }

    public void botaoLabirintoDois()
    {
        SceneManager.LoadScene("Labirinto2");
    }

    public void botaoLabirintoTres()
    {
        SceneManager.LoadScene("Labirinto3");
    }

    public void botaoSair()
    {
        Application.Quit();
    }
}
