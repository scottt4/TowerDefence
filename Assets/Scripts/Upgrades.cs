using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public void UpgradeDamage()
    {
        if (true)
        {
            BoardManager.GetInstance().axeDamage++;
            Debug.Log(BoardManager.GetInstance().axeDamage);
        }
    }
    public void UpgradeTower()
    {
        if (true)
        {
            TowerHealth.GetInstance().IncreaseTowerHp(10);
            Debug.Log("Max: " + TowerHealth.GetInstance().Slider.maxValue + " Value: " + TowerHealth.GetInstance().Slider.value);
        }
    }

    public void UpgradeArmorPen()
    {
        if (true)
        {
            GameManager.GetInstance().IncreaseArmorPenetration();
            Debug.Log(GameManager.GetInstance().GetArmorPenetration());
        }
    }
    public void UpgradeGoldDrops()
    {
        if (true)
        {
            GameManager.GetInstance().IncreaseGold();
            Debug.Log(GameManager.GetInstance().GetGoldMultiplier());
        }
    }
}
