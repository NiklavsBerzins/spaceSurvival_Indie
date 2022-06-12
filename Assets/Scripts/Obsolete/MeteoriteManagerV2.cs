using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteManagerV2 : MonoBehaviour
{

    public GameObject meteoritePrefab;

    public float radius;

    public Transform tracker;


//-----------

    void Start()
    {
        StartCoroutine(SpawnMeteorite());
    }


    IEnumerator SpawnMeteorite()
    {
        for (int i = 0; i < 100; i++)
        {

            radius = 20f;    // distance from center
            float angle = Random.Range(0, Mathf.PI * 2);    // Random angle in radians
            // sin and cos need value in radians
            // full turn aroud circle in radians equal 2*PI ~6.283185 rad
            Vector2 pos2d = new Vector2(Mathf.Sin(angle) * radius, Mathf.Cos(angle) * radius);


            GameObject meteorite = Instantiate(meteoritePrefab, new Vector2(pos2d.x, pos2d.y), Quaternion.identity, tracker);
            

            yield return new WaitForSeconds(3);
        }
        
    }

}