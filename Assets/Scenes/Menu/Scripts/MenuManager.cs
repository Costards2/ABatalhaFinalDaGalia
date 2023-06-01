using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject painelMenuInicial;

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void RomaSide()
    {
        SceneManager.LoadScene("Roma");
    }

    public void GaliaSide()
    {
        SceneManager.LoadScene("Galia");
    }

    public void Jogar()
    {
        //painelMenuInicial.SetActive(false);
        //painelMenuSecundario.SetActive(true);
    }

    public void Sair()
    {
        Debug.Log("Sair");
        Application.Quit();
    }

}