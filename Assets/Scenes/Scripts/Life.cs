using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField] public int life;
    public bool dead = false;
    public Animator animator;
    private bool isDying = false;
    //private bool pronto = false;
    public GameObject scriptmove;
    public GameObject derrota;


    void Start()
    {
       
    }

    void Update()
    {
        if (life <= 0)
        {
            //animator.SetBool("Dead", true);
            //gameObject.SetActive(false);
            //dead = true;
            //isDying = true;
            scriptmove = GameObject.FindWithTag("Player");
            scriptmove.GetComponent<MovePlayer>().enabled = false;

            Destroy(gameObject);
            derrota.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0f;

            isDying = false;

        }
        //if (isDying == true)
        //{
            //StartCoroutine(DeathCoroutine());
        //}
    }
    //private IEnumerator DeathCoroutine()
    //{
        //isDying = true;

        //animator.SetTrigger("Death");


        //yield return new WaitForSeconds((0));
        //scriptmove = GameObject.FindWithTag("Player");
        //scriptmove.GetComponent<MovePlayer>().enabled = false;

        //Destroy(gameObject);
        //derrota.SetActive(true);
        //Cursor.visible = true;
        //Time.timeScale = 0f;

        //isDying = false;
        //dead = true;
    //}

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            life--;
        }
    }
}
