using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //[SerializeField] private GameObject
    public GameObject player;
    public GameObject pause;
    public bool dead;
    public GameObject hist;

    void Awake()
    {
        Cursor.visible = true;
        Time.timeScale = 0f;
    }

    private void Start()
    {
        //dead = player.GetComponent<Life>().dead;
        //Time.timeScale = 0f;
    }

    private void Update()
    {
        dead = player.GetComponent<Life>().dead;
        if (dead == true)
        {
            Debug.LogError("Jogador esta morto!");
            //Time.timeScale = 0f;
            //painelMenuInicial.SetActive(false);
            //derrota.SetActive(true);
            
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0f;
        }
    }

    public void Play()
    {
        //Time.timeScale = 1f;
        //hist.SetActive(false);
        //Cursor.visible = false;
    }
}
