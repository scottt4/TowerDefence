using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    // Set enemy's max health
    public float StartingHealth = 10f;
    public Slider Slider;

    // Set defence of enemy. Allows us to reduce damage taken.
    public float Defence = 0f;

    // Keep track of current health
    private float CurrentHealth;
    private static EnemyHealth Instance;

    // Same as other files, create an instance that any references will use and be able to update.
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
    }

    // Take damage. Update count of enemies if enemies are destroyed.
    public void TakeDamage(float amount)
    {
        if ((amount - Defence) > 0) {
            CurrentHealth -= amount;
        }

        if (CurrentHealth <= 0)
        {
            GameManager.EnemiesRemaining--;
            GameManager.Score++; //adjust later for different units
            Debug.Log(GameManager.Score);

            Destroy(gameObject);
        }

        SetHealthUI();
    }

    private void SetHealthUI()
    {
        Slider.value = CurrentHealth;
    }
}
