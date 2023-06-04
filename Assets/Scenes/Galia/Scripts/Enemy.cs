using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public float chaseSpeed = 3f;
    public float chaseDistance = 10f;
    public Animator animator;
    private Vector3 direita;
    private Vector3 esquerda;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();
        direita = transform.localScale;
        esquerda = transform.localScale;
        esquerda.x = esquerda.x * -1;


        if (player == null)
        {
            Debug.LogError("Jogador não encontrado na cena!");
        }
    }

    void Update()
    {
        // Calcula a distância entre o inimigo e o jogador
        float distance = Vector3.Distance(transform.position, player.position);


        if (distance <= chaseDistance)
        {
            // Calcula a direção do jogador em relação ao inimigo
            Vector3 direction = player.position - transform.position;
            direction.Normalize();

            // Move o inimigo na direção do jogador
            transform.position += direction * chaseSpeed * Time.deltaTime;

            animator.SetBool("IsWalking", true);

            if (direction.x > 0)
            {
                transform.localScale = direita;
            }
            else if (direction.x < 0)
            {
                transform.localScale = esquerda;
            }
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            animator.SetBool("IsWalking", false);
            chaseSpeed = 0f;
            animator.SetBool("Atacando", true);
            Debug.Log("Inimigo atingiu o jogador!"); 
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            //animator.SetBool("IsWalking", true);
            chaseSpeed = 3f;
            animator.SetBool("Atacando", false);
        }
    }
}
