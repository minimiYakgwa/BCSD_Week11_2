using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class SpawnManager2 : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerupPb;

    private float zEnemySpawn = 46.0f;
    private float xSpawnRange = 46.0f;
    private float zPowerupRange = 20.0f;
    private float ySpawn = 0.75f;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
        StartCoroutine(SpawnPowerup());
    }
    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            float randomX = Random.Range(-xSpawnRange, xSpawnRange);
            int randomIndex = Random.Range(0, enemies.Length);

            Vector3 spawnPos = new Vector3(randomX, ySpawn, zEnemySpawn);

            Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
            yield return new WaitForSeconds(1.0f);
        }


    }

    private IEnumerator SpawnPowerup()
    {
        while (true)
        {
            float randomX = Random.Range(-xSpawnRange, xSpawnRange);
            float randomZ = Random.Range(-zPowerupRange, zPowerupRange);

            Vector3 spawnPos = new Vector3(randomX, ySpawn, randomZ);

            Instantiate(powerupPb, spawnPos, powerupPb.transform.rotation);

            yield return new WaitForSeconds(2.0f);
        }
        
    }

}
