using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    public Text ScoreText;
    public int score = 0;
    public void IncrementScore()
    {
        score++;
        ScoreText.text = "Score: " + score;
        Destroy(gameObject);
        print(score);
    }
}