using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnEnemies : MonoBehaviour
{
    public float WaveDelay = 1.0f;
    public GameObject[] enemies;
    public int WaveNumber;
    private int EnemiesInWave;
    private Queue SpawnQueue = new Queue();
    private GameManager game;

    // Dictionary to hold all enemies. Allows us to refer to them by name, instead of memorizing their positon in the array
    private Dictionary<string, GameObject> EnemyDictionary = new Dictionary<string, GameObject>();

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

    private void Start()
    {
        minimumX = 1350.0f - BoardManager.offset;
        maximumX = 2000.0f - BoardManager.offset;

        minimumY = 50.0f;
        maximumY = 170.0f;

        WaveNumber = 0;
        EnemiesInWave = 0;

        EnemyDictionary.Add("Rat", enemies[0]);
        EnemyDictionary.Add("Goblin", enemies[1]);
        EnemyDictionary.Add("Bat", enemies[2]);
        EnemyDictionary.Add("Snake", enemies[3]);
        EnemyDictionary.Add("Skeleton1", enemies[4]);
        EnemyDictionary.Add("Skeleton2", enemies[5]);
        EnemyDictionary.Add("Ogre", enemies[6]);
        EnemyDictionary.Add("Spectre", enemies[7]);
        EnemyDictionary.Add("Boss", enemies[8]);

        game = GameManager.GetInstance();
    }

    private void Update()
    {
        CurrentWaveTime += Time.deltaTime;

        if ((CurrentWaveTime >= WaveDelay) && (game.GetEnemiesRemaining() <= 0))
        {
            if (WaveNumber > 20)
            {
                Debug.Log("You beat level 1!");
                game.AddScore(500 * game.GetLevel());
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - game.GetLevel());
            }
            else
            {
                game.AddScore(10 * WaveNumber);
                WaveNumber++;
                Debug.Log("You made it to wave " + WaveNumber);
                CurrentWaveTime = 0.0f;
                EnemiesInWave = 0;
                InitiateWave();
            }
        }

        if (SpawnQueue.Count > 0)
        {
            Spawn();
            game.AddEnemies(1);
        }
    }

    void InitiateWave()
    {
        switch (WaveNumber)
        {
            case 1:
                EnemiesInWave = 10;
                for (int i = 0; i < EnemiesInWave / 2; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Bat"]);
                }
                break;
            case 2:
                EnemiesInWave = 16;
                for (int i = 0; i < EnemiesInWave / 2; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Bat"]);
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
                EnemiesInWave = 20;
                SpawnQueue.Enqueue(EnemyDictionary["Skeleton1"]);
                for (int i = 0; i < EnemiesInWave / 2; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Bat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Goblin"]);
                }
                break;
            case 6:
                EnemiesInWave = 30;
                for (int i = 0; i < EnemiesInWave; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                }
                SpawnQueue.Enqueue(EnemyDictionary["Skeleton2"]);
                break;
            case 7:
                EnemiesInWave = 24;
                for (int i = 0; i < EnemiesInWave / 3; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Bat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Bat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Goblin"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Goblin"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Skeleton1"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Skeleton2"]);
                }
                break;
            case 8:
                EnemiesInWave = 51;
                for (int i = 0; i < EnemiesInWave / 3; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Bat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Bat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Goblin"]);
                }
                break;
            case 9:
                EnemiesInWave = 70;
                for (int i = 0; i < EnemiesInWave; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Bat"]);
                }
                break;
            case 10:
                SpawnQueue.Enqueue(EnemyDictionary["Ogre"]);
                SpawnQueue.Enqueue(EnemyDictionary["Ogre"]);
                EnemiesInWave = 40;
                for (int i = 0; i < EnemiesInWave / 2; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Bat"]);
                }
                break;
            case 11:
                EnemiesInWave = 100;
                for (int i = 0; i < EnemiesInWave / 5; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Bat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Bat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                }
                break;
            case 12:
                EnemiesInWave = 80;
                for (int i = 0; i < EnemiesInWave; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Goblin"]);
                }
                break;
            case 13:
                EnemiesInWave = 80;
                for (int i = 0; i < EnemiesInWave / 4; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Bat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Skeleton1"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Skeleton2"]);
                }
                break;
            case 14:
                EnemiesInWave = 90;
                for (int i = 0; i < EnemiesInWave / 3; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Bat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Snake"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Skeleton1"]);
                }
                break;
            case 15:
                EnemiesInWave = 90;
                SpawnQueue.Enqueue(EnemyDictionary["Ogre"]);
                SpawnQueue.Enqueue(EnemyDictionary["Ogre"]);
                for (int i = 0; i < EnemiesInWave / 3; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Bat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Goblin"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Spectre"]);
                }
                SpawnQueue.Enqueue(EnemyDictionary["Ogre"]);
                SpawnQueue.Enqueue(EnemyDictionary["Ogre"]);
                break;
            case 16:
                EnemiesInWave = 60;
                for (int i = 0; i < EnemiesInWave; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Snake"]);
                }
                break;
            case 17:
                EnemiesInWave = 120;
                for (int i = 0; i < EnemiesInWave / 3; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Bat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Skeleton2"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Spectre"]);
                }
                break;
            case 18:
                EnemiesInWave = 200;
                for (int i = 0; i < EnemiesInWave; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Goblin"]);
                }
                break;
            case 19:
                EnemiesInWave = 200;
                for (int i = 0; i < EnemiesInWave / 2; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Bat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Snake"]);
                }
                break;
            case 20:
                EnemiesInWave = 200;
                for (int i = 0; i < EnemiesInWave / 8; i++)
                {
                    SpawnQueue.Enqueue(EnemyDictionary["Rat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Bat"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Goblin"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Snake"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Ogre"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Spectre"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Skeleton1"]);
                    SpawnQueue.Enqueue(EnemyDictionary["Skeleton2"]);
                }
                SpawnQueue.Enqueue(EnemyDictionary["Boss"]);
                break;
            default:
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
