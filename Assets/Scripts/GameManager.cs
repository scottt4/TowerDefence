using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager Instance = null;
    private static int EnemiesRemaining;
    private static float Score;
    private int Level;
    private static float Gold;
    public bool Loss;
    private float ArmorPenetration;
    private float GoldMultiplier;

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
            ArmorPenetration = 0f;
            GoldMultiplier = 1f;
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
    }

    public void AddScoreAndGold(float amount)
    {
        Score += amount;
        Gold += amount * GoldMultiplier;
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

    public float GetArmorPenetration()
    {
        return ArmorPenetration;
    }

    public void IncreaseArmorPenetration()
    {
        ArmorPenetration += 0.2f;
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

    public void IncreaseGold()
    {
        GoldMultiplier += .05f;
    }

    public float GetGoldMultiplier()
    {
        return GoldMultiplier;
    }
}
