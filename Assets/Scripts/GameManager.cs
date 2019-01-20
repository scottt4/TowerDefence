using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager Instance;
    private static int EnemiesRemaining;
    private static float Score;
    private static int Level;
    private static float Gold;

    private void Awake()
    {
        Instance = this;
        EnemiesRemaining = 0;
        Score = 0f;
        Gold = 0f;
        Level = 1;
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
        Level += 1;
    }
}
