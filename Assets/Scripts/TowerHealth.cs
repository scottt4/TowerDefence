using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TowerHealth : MonoBehaviour
{
    // Healthbar is a slider, can be set manually in game
    public Slider Slider;
    public float StartingHealth = 100f;

    private GameManager game;

    // Keep track of current health. If it drops to 0, player loses!
    private float CurrentHealth;

    // Create an instance of our TowerHealth class. Every reference will use this same instance.
    private static TowerHealth Instance;

    // Order of execution is Awake > OnEnable > Start. We probably could use Start here and keep it consistent, but this doesn't hurt anything and is sure to make events happen in order
    private void Awake()
    {
        Instance = this;
    }

    private void OnEnable()
    {
        CurrentHealth = StartingHealth;

        SetHealthUI();

        game = GameManager.GetInstance();
    }

    // Before any class can call public functions or variables, they need the instance in use in the game
    public static TowerHealth GetInstance()
    {
        return Instance;
    }

    // Take damage to tower. Game over when zero.
    public void TakeDamage(float amount)
    { 
        CurrentHealth -= amount;

        if (CurrentHealth <= 0)
        {
            Debug.Log("Game over, man. Final Score: " + (int) game.GetScore());
            Application.Quit();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - game.GetLevel());
        }

        SetHealthUI();
    }

    // Every time health is updated, update on UI
    private void SetHealthUI()
    {
        Slider.value = CurrentHealth;
    }
}

