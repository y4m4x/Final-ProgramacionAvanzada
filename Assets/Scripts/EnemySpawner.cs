using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject prefabASpawnear;
    public float minY = 8f;
    public float maxY = 5f;
    public float xPos = -3.31f;
    public float intervaloMinTiempoSpawn = 3f;
    public float intervaloMaxTiempoSpawn = 6f;

    private void Start()
    {
        StartCoroutine(SpawnObstaculo(Random.Range(intervaloMinTiempoSpawn, intervaloMaxTiempoSpawn), prefabASpawnear));
    }

    private IEnumerator SpawnObstaculo(float intervalo, GameObject EnemyShip)
    {

        yield return new WaitForSeconds(intervalo);
        Instantiate(EnemyShip, new Vector3(Random.Range(minY, maxY), xPos, 0), Quaternion.identity);
        StartCoroutine(SpawnObstaculo(intervalo, EnemyShip));
    }
}