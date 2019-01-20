using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
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
        text.text = "Score: " + (int) game.GetScore();
    }
}