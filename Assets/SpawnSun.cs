using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSun : MonoBehaviour {

    public GameObject sun;
    float rangeX;
    Vector2 whereToSpawn;
    public float spawnRate;
    float nextSpawn = 2f;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            rangeX = Random.Range(-11.75f, 10.78f);
            whereToSpawn = new Vector2(rangeX, transform.position.y);
            Instantiate(sun, whereToSpawn, Quaternion.identity);
        }
    }
}
