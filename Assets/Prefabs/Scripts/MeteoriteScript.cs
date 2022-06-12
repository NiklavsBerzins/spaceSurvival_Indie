using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteScript : MonoBehaviour
{

    public bool canDespawn;
    Renderer rndr;



    // Start is called before the first frame update
    void Start()
    {
        rndr = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rndr.isVisible)
        {
            canDespawn = true;
        }


        
    }

    private void OnTriggerExit2D (Collider2D collision)
    {
        if (canDespawn)
        {
            Destroy(gameObject);
            print("Meteorite destroyed");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Bullet(Clone)")
        {
            Destroy(gameObject);
        }
    }

}
