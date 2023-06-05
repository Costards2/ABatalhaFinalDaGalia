using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 2f;
    public Rigidbody2D rb;
    public int count; 

    void Start()
    {
        rb.velocity = transform.right * speed;
        count = 0;
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        StartCoroutine(destroyArrow());
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.CompareTag("Enemy"))
        {
            count++; 
        }

        Destroy(gameObject);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    IEnumerator destroyArrow() 
    {
        yield return new WaitForSeconds(0.8f);
        Destroy(gameObject);

    }
}

