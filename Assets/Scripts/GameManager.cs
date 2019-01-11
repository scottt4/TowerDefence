using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static int EnemiesRemaining;

    void Awake()
    {
        Instance = this;
        EnemiesRemaining = 0;
    }
}
