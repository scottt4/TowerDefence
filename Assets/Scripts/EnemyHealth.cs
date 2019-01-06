using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float StartingHealth = 10f;
    public Slider Slider;
    public float Defence = 0f;

    private float CurrentHealth;
    private static EnemyHealth Instance;

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

    public void TakeDamage(float amount)
    {
        if ((amount - Defence) > 0) {
            CurrentHealth -= amount;
        }

        if (CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }

        SetHealthUI();
    }

    private void SetHealthUI()
    {
        Slider.value = CurrentHealth;
    }

    //placeholder--for adding "real" damage next
    private int count = 0;
    private void Update()
    {
        count++;
        if (count % 100 == 0)
        {
            TakeDamage(.1f);
        }

    }
}
