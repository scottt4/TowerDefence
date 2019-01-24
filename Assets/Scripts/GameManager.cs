using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager Instance = null;
    private static int EnemiesRemaining;
    private static float Score;
    private int Level;
    private static float Gold;
    public bool Loss;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            EnemiesRemaining = 0;
            Score = 0f;
            Gold = 0f;
            Level = 0;
            Loss = false;
        }
        DontDestroyOnLoad(gameObject);
    }

    public static GameManager GetInstance()
    {
        return Instance;
    }

    public void AddScore(float amount)
    {
        Score += amount;
        Gold += amount;
    }

    public float GetScore()
    {
        return Score;
    }

    public float GetGold()
    {
        return Gold;
    }

    public void AddEnemies(int number)
    {
        EnemiesRemaining += number;
    }

    public void EnemyDeath()
    {
        EnemiesRemaining--;
    }

    public int GetEnemiesRemaining()
    {
        return EnemiesRemaining;
    }

    public int GetLevel()
    {
        return Level;
    }

    public void AdvanceLevel()
    {
        Level++;
    }

    public void ResetScore()
    {
        Score = 0f;
        Loss = true;
    }

    public void ResetLevel()
    {
        Level = 0;
    }
}
