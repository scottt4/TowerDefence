﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public float WaveDelay = 1.0f;
    public GameObject[] enemies;
    public int WaveNumber;
    private int EnemiesInWave;
    public Queue SpawnQueue = new Queue();

    // Dictionary to hold all enemies. Allows us to refer to them by name, instead of memorizing their positon in the array
    Dictionary<string, GameObject> EnemyDictionary = new Dictionary<string, GameObject>();

    // Spawn range for enemies
    private float minimumX, minimumY, maximumX, maximumY;

    private float CurrentWaveTime = 0.0f;
    private static SpawnEnemies Instance;

    private void Awake()
    {
        Instance = this;
    }
    public static SpawnEnemies GetInstance()
    {
        return Instance;
    }

    void Start()
    {
        minimumX = 1350.0f;
        maximumX = 2000.0f;

        minimumY = 50.0f;
        maximumY = 170.0f;

        WaveNumber = 0;
        EnemiesInWave = 0;

        EnemyDictionary.Add("Rat", enemies[0]);
        EnemyDictionary.Add("Goblin", enemies[1]);
        EnemyDictionary.Add("Skeleton1", enemies[2]);
    }

    void Update()
    {
        CurrentWaveTime += Time.deltaTime;

        if ((CurrentWaveTime >= WaveDelay) && (GameManager.EnemiesRemaining <= 0))
        {
            WaveNumber++;
            Debug.Log("You made it to wave " + WaveNumber);
            CurrentWaveTime = 0.0f;
            EnemiesInWave = 0;
            InitiateWave();
        }

        if (SpawnQueue.Count > 0)
        {
            Spawn();
            GameManager.EnemiesRemaining++;
        }
    }

    void InitiateWave()
    {
        switch (WaveNumber)
        {
            case 1:
                EnemiesInWave = 10;
                for (int i = 0; i < EnemiesInWave; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                }
                break;
            case 2:
                EnemiesInWave = 15;
                for (int i = 0; i < EnemiesInWave; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                }
                break;
            case 3:
                EnemiesInWave = 10;
                for (int i = 0; i < EnemiesInWave; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Goblin"]);
                }
                break;
            case 4:
                EnemiesInWave = 20;
                for (int i = 0; i < EnemiesInWave / 2; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Goblin"]);
                }
                break;
            case 5:
                EnemiesInWave = 30;
                for (int i = 0; i < EnemiesInWave / 2; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Goblin"]);
                }
                break;
            case 6:
                EnemiesInWave = 30;
                for (int i = 0; i < EnemiesInWave; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                }
                break;
            case 7:
                EnemiesInWave = 20;
                for (int i = 0; i < EnemiesInWave; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Goblin"]);
                }
                break;
            case 8:
                EnemiesInWave = 40;
                for (int i = 0; i < EnemiesInWave / 2; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Goblin"]);
                }
                break;
            case 9:
                EnemiesInWave = 60;
                for (int i = 0; i < EnemiesInWave; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                }
                break;
            case 10:
                EnemiesInWave = 40;
                for (int i = 0; i < EnemiesInWave; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Goblin"]);
                }
                break;
            case 11:
                EnemiesInWave = 10;
                for (int i = 0; i < EnemiesInWave; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Skeleton1"]);
                }
                break;
            case 12:
                EnemiesInWave = 20;
                for (int i = 0; i < EnemiesInWave / 2; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Skeleton1"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                }
                break;
            case 13:
                EnemiesInWave = 30;
                for (int i = 0; i < EnemiesInWave / 3; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Goblin"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Skeleton1"]);
                }
                break;
            case 14:
                EnemiesInWave = 20;
                for (int i = 0; i < EnemiesInWave; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Skeleton1"]);
                }
                break;
            case 15:
                EnemiesInWave = 30;
                for (int i = 0; i < EnemiesInWave / 3; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Goblin"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Skeleton1"]);
                }
                break;
            case 16:
                EnemiesInWave = 20;
                for (int i = 0; i < EnemiesInWave; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Skeleton1"]);
                }
                break;
            case 17:
                EnemiesInWave = 30;
                for (int i = 0; i < EnemiesInWave / 3; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Goblin"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Skeleton1"]);
                }
                break;
            case 18:
                EnemiesInWave = 20;
                for (int i = 0; i < EnemiesInWave; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Skeleton1"]);
                }
                break;
            case 19:
                EnemiesInWave = 30;
                for (int i = 0; i < EnemiesInWave / 3; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Goblin"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Skeleton1"]);
                }
                break;
            case 20:
                EnemiesInWave = 20;
                for (int i = 0; i < EnemiesInWave; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Skeleton1"]);
                }
                break;
            default:
                EnemiesInWave = WaveNumber * 3;
                for (int i = 0; i < EnemiesInWave / 3; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Goblin"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Skeleton1"]);
                }
                break;
        }
    }

    void Spawn()
    {
        GameObject NextEnemy = (GameObject) SpawnQueue.Dequeue();
        Vector3 randomPos = new Vector3(UnityEngine.Random.Range(minimumX, maximumX), UnityEngine.Random.Range(minimumY, maximumY), 0);
        Instantiate(NextEnemy, randomPos, transform.rotation);
    }
}
