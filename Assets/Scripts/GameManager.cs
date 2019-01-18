using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static int EnemiesRemaining;
    public static int Score;
    public static int Level;

    private void Awake()
    {
        Instance = this;
        EnemiesRemaining = 0;
        Score = 0;
        Level = 1;
    }

    private void AddScore(int amount)
    {
        Score += amount;
    }

    private void AdvanceLevel()
    {
        Level += 1;
    }
}
