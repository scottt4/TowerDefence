using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    // Set enemy's max health
    public float StartingHealth = 10f;
    public Slider Slider;

    // Set defence of enemy. Allows us to reduce damage taken.
    public float Defence = 0f;
    public float Value = 1f;

    // Keep track of current health
    private float CurrentHealth;
    private static EnemyHealth Instance;

    private GameManager game;

    private void Awake()
    {
        Instance = this;
    }
    public static EnemyHealth GetInstance()
    {
        return Instance;
    }

    private void OnEnable()
    {
        CurrentHealth = StartingHealth;

        SetHealthUI();
        game = GameManager.GetInstance();
    }

    public void TakeDamage(float amount)
    {
        if ((amount - Defence + game.GetArmorPenetration()) > 0) {
            if (game.GetArmorPenetration() >= Defence)
            {
                CurrentHealth -= amount;
            }
            else
            {
                CurrentHealth -= amount - Defence + game.GetArmorPenetration();
            }
        }

        if (CurrentHealth <= 0)
        {
            game.EnemyDeath();
            game.AddScoreAndGold(Value);
            Destroy(gameObject);
        }

        SetHealthUI();
    }

    private void SetHealthUI()
    {
        Slider.value = CurrentHealth;
    }
}
