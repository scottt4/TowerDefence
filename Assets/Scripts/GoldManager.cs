using UnityEngine;
using UnityEngine.UI;

public class GoldManager : MonoBehaviour
{
    Text text;
    private GameManager game;

    void Start()
    {
        text = GetComponent<Text>();
        game = GameManager.GetInstance();

    }

    void Update()
    {
        text.text = "Gold: " + (int)game.GetGold();
    }
}
