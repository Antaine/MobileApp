using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;
    float randX;
    float randY;
    Vector2 spawnloacation;
    public float spawnRate = 2f;
    float newxtSpawn = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > newxtSpawn)
        {
            newxtSpawn = Time.time + spawnRate;
            randX = Random.Range(-300f, 300f);
            randY = Random.Range(-150f, 300f);
            spawnloacation = new Vector2(randX, randY);

            Instantiate(enemy, spawnloacation, Quaternion.identity);
        }
        
    }
}
