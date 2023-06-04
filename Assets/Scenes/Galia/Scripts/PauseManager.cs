using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    //[SerializeField] private GameObject

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Pause()
    {
        //painelMenuInicial.SetActive(false);
        //painelMenuSecundario.SetActive(true);
    }

    private bool isPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    private void PauseGame()
    {
        Time.timeScale = 0f; 
        isPaused = true;
    }

    private void ResumeGame()
    {
        Time.timeScale = 1f; 
        isPaused = false;
    }
}

