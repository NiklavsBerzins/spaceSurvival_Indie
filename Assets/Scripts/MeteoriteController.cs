using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteController : MonoBehaviour
{

    public GameObject meteoritePrefab;

    public float radius = 40;

    public Transform player;

    public float spawnTime = 3f;

    public float meteoriteSpeed;


//-----------

    void Start()
    {
        StartCoroutine(SpawnMeteorite());
    }




    IEnumerator SpawnMeteorite()
    {

        // ir janosuta infa no sejienes uz citu funkciju 
        //funkcija();

        // A random point on an imaginary circle
        Vector3 meteoriteSpawnPoint = Random.insideUnitCircle.normalized * radius;


        // Instantiates a meteorite on the circle around player
        GameObject meteorite = Instantiate(meteoritePrefab, player.position +
            meteoriteSpawnPoint, Quaternion.identity);

        


        // Sets the velocity of the meteorite towards player
        meteorite.GetComponent<Rigidbody2D>().velocity = new Vector2(player.position.x -
            meteorite.transform.position.x, player.position.y -
            meteorite.transform.position.y).normalized * meteoriteSpeed;


        // Time to wait
        yield return new WaitForSeconds(spawnTime);


        // Start again
        StartCoroutine(SpawnMeteorite());

    }

    //private GameObject funkcija(meteorite)
    //{
    //    return;
    //}
        
}

