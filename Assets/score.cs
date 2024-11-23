using UnityEngine;
using TMPro; // Obs³uga tekstu dla TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Referencja do tekstu na ekranie
    private int SCORE = 0;            // Aktualny wynik

    // Funkcja do zwiêkszania wyniku
    public void AddPoint()
    {
        SCORE++; // Zwiêkszamy wynik o 1
        UpdateScoreText();
    }

    // Aktualizacja wyœwietlanego wyniku
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + SCORE; // Ustawiamy tekst wyniku
    }
}
