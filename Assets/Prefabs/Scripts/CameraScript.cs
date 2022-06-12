using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public Transform player;
    public Camera cam;
    Vector3 offset;


    private void Start()
    {
        offset = new Vector3(0, 0, -1);
    }

    private void Update()
    {
        transform.position = player.position + offset;


    }

}


