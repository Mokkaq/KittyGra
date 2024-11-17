using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;           

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
