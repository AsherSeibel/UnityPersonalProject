using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 12;
    private float startDelay = 3;
    private float spawnInterval = 3f;
    private float spawnRangeX = 12;
    private float spawnRangeZ = 20;
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnEnemys", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void SpawnEnemys()
    {

       
        Vector3 spawnRange = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        Instantiate(enemyPrefab, spawnRange, enemyPrefab.transform.rotation);
    }
}

