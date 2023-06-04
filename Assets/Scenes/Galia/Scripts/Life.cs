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
            isDying = true; 

        }
        if (isDying == true)
        {
            StartCoroutine(DeathCoroutine());
        }
    }
    private IEnumerator DeathCoroutine()
    {
        isDying = true;

        animator.SetTrigger("Death");

        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);
        scriptmove = GameObject.Find("GaulCavalryArcher");
        scriptmove.GetComponent<MovePlayer>().enabled = false;

        isDying = false;
        //dead = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            life--;
        }
    }
}
