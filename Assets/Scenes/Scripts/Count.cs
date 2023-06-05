using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour
{
    public int count;
    //public int countInicial;

    void Start()
    {
        count = 0;
    }

    
    void Update()
    {
        count = GameObject.Find("Arrow").GetComponent<Arrow>().count; 
    }
}
