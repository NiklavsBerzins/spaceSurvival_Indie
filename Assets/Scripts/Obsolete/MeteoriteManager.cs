using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteManager : MonoBehaviour
{

    public GameObject meteoritePrefab;
    public Vector2 meteoriteSpawnPoint;
    public Transform player;
    public float meteoriteSpeed = 10;
    public float meteoriteSpawnTime = 3;

    float xSpawnPoint0 = -50;
    float xSpawnPoint1 = -40;
    float xSpawnPoint2 = 40;
    float xSpawnPoint3 = 50;

    float ySpawnPoint0 = -50;
    float ySpawnPoint1 = -40;
    float ySpawnPoint2 = 40;
    float ySpawnPoint3 = 50;


    private void Start()
    {
        StartCoroutine(SpawnMeteorite());    
    }


    IEnumerator SpawnMeteorite()
    {
        float xSpawn0 = Random.Range(xSpawnPoint0, xSpawnPoint1); // -40 to -50
        float xSpawn1 = Random.Range(xSpawnPoint2, xSpawnPoint3); // 40 to 50

        float ySpawn0 = Random.Range(ySpawnPoint0, ySpawnPoint1); // -40 to -50
        float ySpawn1 = Random.Range(ySpawnPoint2, ySpawnPoint3); // 40 to 50

        float xCalculation = Random.Range(xSpawn0, xSpawn1); // -50 to 50
        float yCalculation = Random.Range(ySpawn0, ySpawn1); // -50 to 50

        

        if (xCalculation > 0)
        {
            meteoriteSpawnPoint.x = xSpawn0;
        }
        else meteoriteSpawnPoint.x = xSpawn1;


        if (yCalculation > 0)
        {
            meteoriteSpawnPoint.y = ySpawn0;
        }
        else meteoriteSpawnPoint.y = ySpawn1;



        GameObject meteorite = Instantiate(meteoritePrefab, meteoriteSpawnPoint, Quaternion.identity);


        //meteorite.GetComponent<Rigidbody2D>().velocity = new Vector2(player.position.x -
        //meteoriteSpawnPoint.x, player.position.y - meteoriteSpawnPoint.y).normalized * meteoriteSpeed;

        

        yield return new WaitForSeconds(meteoriteSpawnTime);
        StartCoroutine(SpawnMeteorite());
    }
    
}
