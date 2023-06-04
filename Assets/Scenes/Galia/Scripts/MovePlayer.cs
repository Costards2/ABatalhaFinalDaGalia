using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Animator animator;
    public float speed = 5.0f;
    private Rigidbody2D rb;
    private Vector3 direita;
    private Vector3 esquerda;
    public GameObject bulletPrefab;
    public Transform shootingPoint;
    private bool m_FacingRight = true;
    public float fireRate;
    float nextFire; 

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

        if (horizontal > 0 && !m_FacingRight)
        {
          
            Flip();
        }
        
        else if (horizontal < 0 && m_FacingRight)
        {
            
            Flip();
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
        
            animator.SetBool("IsRunning", true);
        
        }
        
        else
        {
            animator.SetBool("IsRunning", false);
        }

        if (Input.GetMouseButtonDown(0))
        {

            Shoot();

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

        void Shoot()
        {
            if(Time.time > nextFire)
            {
                nextFire = Time.time + fireRate; 
                shootingPoint.rotation = gameObject.transform.rotation;
                Instantiate(bulletPrefab, shootingPoint.transform.position, shootingPoint.rotation);
            }
        }

        void Flip()
        {
            m_FacingRight = !m_FacingRight;

            transform.Rotate(0f, 180f, 0f);
        }
    }
}
