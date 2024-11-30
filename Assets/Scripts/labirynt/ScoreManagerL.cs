using UnityEngine;
using TMPro; 

public class ScoreManagerL : MonoBehaviour
{
    public TMP_Text scoreText;    
    private int score = 0;

    void Start()
    {
        UpdateScoreText();
    }

    public void AddPoint()
    {
        score++;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
