using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TowerHealth : MonoBehaviour
{
    public float StartingHealth = 100f;
    public Slider Slider;
    private float CurrentHealth;

    private static TowerHealth Instance;

    private void Awake()
    {
        Instance = this;
    }
    public static TowerHealth GetInstance()
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
        CurrentHealth -= amount;

        if (CurrentHealth <= 0)
        {
            Debug.Log("Game over, man");
            Application.Quit();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

        SetHealthUI();
    }

    private void SetHealthUI()
    {
        Debug.Log("Set Health to " + CurrentHealth);
        Slider.value = CurrentHealth;
    }

}

