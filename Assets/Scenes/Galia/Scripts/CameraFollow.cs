using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 deslocamento;
    void Start()
    {
        deslocamento = transform.position;
    }
    void Update()
    {
        transform.position = player.transform.position + deslocamento;
    }
}
