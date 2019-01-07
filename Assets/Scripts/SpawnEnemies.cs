using System;
using System.Collections;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public float TimeBetweenWaves = 5f;
    public float InitialWaveDelay = 2f;
    public GameObject[] enemies;
    private int minimumX;
    private int minimumY;
    private int maximumX;
    private int maximumY;
    public int WaveNumber;

    void Start()
    {
        minimumX = 1350;
        maximumX = 15000;

        minimumY = 50;
        maximumY = 150;

        WaveNumber = 1;
        LoopGame();
    }

    void LoopGame()
    {
        new WaitForSeconds(InitialWaveDelay);
        GenerateWave(WaveNumber);
    }

    void GenerateWave(int wave)
    {
        for (int i = 0; i < Math.Log(wave+2) * wave; i++)
        {
            Spawn();
        }
        //WaitForNextWave();
        //GenerateWave(wave);
    }

    IEnumerator WaitForNextWave()
    {
        yield return new WaitForSeconds(TimeBetweenWaves);
    }
    void Spawn()
    {
        // Instantiate a random enemy.
        int EnemyIndex = UnityEngine.Random.Range(0, enemies.Length);
        Vector3 randomPos = new Vector3(UnityEngine.Random.Range(minimumX, maximumX), UnityEngine.Random.Range(minimumY, maximumY), 0);
        Instantiate(enemies[EnemyIndex], randomPos, transform.rotation);
    }
}
