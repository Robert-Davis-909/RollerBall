using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{

    public Text showScore;
    public Text showHighScore;
    private int score;
    private int highscore;

    void Start()
    {
        score = PlayerPrefs.GetInt("Score");
        highscore = PlayerPrefs.GetInt("HighScore");
        showScore.text = "Score: " + score;
        showHighScore.text = "High Score: " + highscore;
    }

    void Update()
    {

    }
}
