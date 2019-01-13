using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static int EnemiesRemaining;

    private void Awake()
    {
        Instance = this;
        EnemiesRemaining = 0;
    }
}
