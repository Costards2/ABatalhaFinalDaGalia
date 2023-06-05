using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public int life;
    public GameObject coracao1;
    public GameObject coracao2;
    public GameObject coracao3;
    public GameObject coracao4;
    public GameObject coracao5;

    void Start()
    {
        //life = GameObject.Find("GaulCavalryArcher").GetComponent<Life>().life;
    }

    void Update()
    {
        life = GameObject.FindWithTag("Player").GetComponent<Life>().life;

        if (life < 10)
        {
            Destroy(coracao5);
        }

        if (life < 8)
        {
            Destroy(coracao4);
        }

        if (life < 6)
        {
            Destroy(coracao3);
        }

        if (life < 4)
        {
            Destroy(coracao2);
        }

        if (life < 1)
        {
            Destroy(coracao1);
        }
    }
}
