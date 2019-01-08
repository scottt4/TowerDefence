using System;
using System.Collections;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public float waveTimer = 3.0f;
    private float timeTillWave = 2.0f;
    public GameObject[] enemies;
    private float minimumX;
    private float minimumY;
    private float maximumX;
    private float maximumY;
    public int WaveNumber;
    private int enemiesToSpawn;

    void Start()
    {
        minimumX = 1350.0f;
        maximumX = 1900.0f;

        minimumY = 50.0f;
        maximumY = 150.0f;

        WaveNumber = 0;

        enemiesToSpawn = 0;
    }

    void Update()
    {
        timeTillWave += Time.deltaTime;

        if (enemiesToSpawn > 0)
        {
            if (UnityEngine.Random.Range(0, WaveNumber) == (WaveNumber - 1))
            {
                Spawn();
            }
        }

        if (timeTillWave >= waveTimer)
        {
            WaveNumber++;
            timeTillWave = 0.0f;
            waveTimer = waveTimer + .25f;
            Debug.Log("You are on wave number " + WaveNumber + " with " + enemiesToSpawn + " enemies in queue." + " Next wave is in " + waveTimer + " seconds");
            enemiesToSpawn = enemiesToSpawn + (int) Math.Log(WaveNumber + 2) + WaveNumber;

        }
 
    }

    void Spawn()
    {
        // Instantiate a random enemy.
        int EnemyIndex = UnityEngine.Random.Range(0, enemies.Length);
        if (WaveNumber < 3)
        {
            EnemyIndex = UnityEngine.Random.Range(0, enemies.Length - 2);
        }
        else if (WaveNumber < 6)
        {
            EnemyIndex = UnityEngine.Random.Range(0, enemies.Length - 1);
        }

        if (EnemyIndex == 0)
        {
            enemiesToSpawn--;
        }
        else if (EnemyIndex == 2)
        {
            enemiesToSpawn = enemiesToSpawn - 2;
        }
        else if (EnemyIndex == 5)
        {
            enemiesToSpawn = enemiesToSpawn - 10;
        }

        Vector3 randomPos = new Vector3(UnityEngine.Random.Range(minimumX, maximumX), UnityEngine.Random.Range(minimumY, maximumY), 0);
        Instantiate(enemies[EnemyIndex], randomPos, transform.rotation);
    }
}
