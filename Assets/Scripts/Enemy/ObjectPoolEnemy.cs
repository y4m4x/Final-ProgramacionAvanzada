using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int poolSize = 5;
    public float spawnRate = 2f;

    private List<GameObject> enemyPool = new List<GameObject>();
    private float nextSpawnTime;

    void Start()
    {
        Debug.Log("Start");
        EnemyPooling();
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            EnemySpawn();
            nextSpawnTime = Time.time + spawnRate;
        }
    }

    void EnemyPooling()
    {
        Debug.Log("BeforeFor");
        for (int i = 0; i < poolSize; i++)
        {
            GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            enemy.SetActive(false);
            enemyPool.Add(enemy);
            Debug.Log("Instantiate" + i + poolSize);
        }
    }

    void EnemySpawn()
    {
        for (int i = 0; i < enemyPool.Count; i++)
        {
            if (!enemyPool[i].activeInHierarchy)
            {
                enemyPool[i].transform.position = transform.position;
                enemyPool[i].SetActive(true);
                return;
            }
        }
    }
}