using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelPlay;
    [SerializeField] private GameObject painelControles; 


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
        painelPlay.SetActive(true);
    }

    public void Controles()
    {
        //painelMenuInicial.SetActive(false);
        painelControles.SetActive(true);
    }

    public void Sair()
    {
        Debug.Log("Sair");
        Application.Quit();
    }

}