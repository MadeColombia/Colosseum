using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;


public class MainMenu2 : MonoBehaviour
{
    

    public void Jugar()
    {
        SceneManager.LoadScene("ColosseumScene");
    }

    public void Atras()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Salir()
    {
        Application.Quit();
    }

    

}