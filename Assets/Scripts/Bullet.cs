using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Renderer rdrr;
    public GameObject hitEffect;
    private void Start()
    {
        rdrr = GetComponent<Renderer>();
        print("alert");
    }
    private void Update()
    {
        if (!rdrr.isVisible)
        {
            Destroy(gameObject);
            print("destroyed");
        }
    }

    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        //Destroy(effect, 5f);
        rdrr = GetComponent<Renderer>();
        if (!rdrr.isVisible)
        {
            Destroy(gameObject);    
            print("destroyed");
        }

    }
}
