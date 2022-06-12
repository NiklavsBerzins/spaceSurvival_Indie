using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;

    Renderer rndr;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rndr = GetComponent<Renderer>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        if (!rndr.isVisible)
        {
            Destroy(bullet);
            print("destroyed");
        }
        //{
        //    Destroy(bullet);
        //}
       
    }
}
