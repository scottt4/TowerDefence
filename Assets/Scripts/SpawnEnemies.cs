using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnEnemies : MonoBehaviour
{
    public float WaveDelay = 1.0f;
    public int WaveNumber;
    public int EnemiesInWave;
    public Queue Spawns = new Queue();

    private GameManager game;
    private BoardManager board;
    private GameObject[] enemies;

    // Dictionary to hold all enemies. Allows us to refer to them by name, instead of memorizing their positon in the array
    public Dictionary<string, GameObject> EnemyDictionary = new Dictionary<string, GameObject>();

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
        game = GameManager.GetInstance();
        board = BoardManager.GetInstance();
        enemies = board.enemies;

        minimumX = 1350.0f - board.GetOffset();
        maximumX = 2000.0f - board.GetOffset();

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

    }

    private void Update()
    {
        CurrentWaveTime += Time.deltaTime;

        if ((CurrentWaveTime >= WaveDelay) && (game.GetEnemiesRemaining() <= 0))
        {
            if (WaveNumber > 20)
            {
                WaveNumber = 0;
                Debug.Log("You beat level " + game.GetLevel() + "!");
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
                switch(game.GetLevel())
                {
                    case 1:
                        SummonWave.SummonWaveLevel1(Instance, WaveNumber);
                        break;
                    case 2:
                        SummonWave.SummonWaveLevel2(Instance, WaveNumber);
                        break;
                    default:
                        break;

                }
            }
        }

        if (Spawns.Count > 0 && game.GetEnemiesRemaining() < 10 * WaveNumber)
        {
            Spawn();
            game.AddEnemies(1);
        }
    }

    void Spawn()
    {
        GameObject NextEnemy = (GameObject) Spawns.Dequeue();
        Vector3 randomPos = new Vector3(UnityEngine.Random.Range(minimumX, maximumX), UnityEngine.Random.Range(minimumY, maximumY), 0);
        Instantiate(NextEnemy, randomPos, transform.rotation);
    }
}
