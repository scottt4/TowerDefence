using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    Text text;
    private GameManager game;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        game = GameManager.GetInstance();

    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + game.GetScore();
    }
}
