using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //[SerializeField] private GameObject
    public GameObject player;
    public bool dead; 

    private void Start()
    {
        Cursor.visible = false;
        //dead = player.GetComponent<Life>().dead;
    }

    private void Update()
    {
        dead = player.GetComponent<Life>().dead;
        if (dead == true)
        {
            Debug.LogError("Jogador esta morto!");
            //Time.timeScale = 0f;
            //painelMenuInicial.SetActive(false);
            
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
        }
    }
}
