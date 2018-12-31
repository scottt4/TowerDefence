using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class EnemyHealth : MonoBehaviour
{
    public float StartingHealth = 10f;
    private float CurrentHealth;
    public Slider Slider;
    public float Defence = 0f;

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
            //death animation
            //delete animation
            //incriment score or gold
        }

        SetHealthUI();
    }

    private void SetHealthUI()
    {
        Slider.value = CurrentHealth;
    }
}
