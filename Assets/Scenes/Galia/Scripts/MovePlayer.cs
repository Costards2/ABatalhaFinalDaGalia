using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Animator animator;
    public float speed = 5.0f;
    private Rigidbody2D rb;
    private Vector3 direita;
    private Vector3 esquerda;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direita = transform.localScale;
        esquerda = transform.localScale;
        esquerda.x = esquerda.x * -1;
    }

    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, vertical, 0) * Time.deltaTime * speed;

        float horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontal, 0, 0) * Time.deltaTime * speed;

        if (horizontal > 0)
        {
            transform.localScale = direita;
        }
        if (horizontal < 0)
        {
            transform.localScale = esquerda;
        }

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
        
            animator.SetBool("IsRunning", true);
        
        }
        
        else
        {
            animator.SetBool("IsRunning", false);
        }

        if (Input.GetMouseButtonDown(0))
        {

            animator.SetBool("Atack", true);

        }

        else
        {
            animator.SetBool("Atack", false);
        }

        if (Input.GetMouseButtonDown(0) && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
        {

            animator.SetBool("Atack&Run", true);

        }

        else
        {
            animator.SetBool("Atack&Run", false);
        }



    }
}
