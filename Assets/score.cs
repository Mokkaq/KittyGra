using UnityEngine;
using TMPro; // Obsługa tekstu dla TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Referencja do tekstu na ekranie
    private int SCORE = 0;            // Aktualny wynik

    // Funkcja do zwiększania wyniku
    public void AddPoint()
    {
        SCORE++; // Zwiększamy wynik o 1
        UpdateScoreText();
    }

    // Aktualizacja wyświetlanego wyniku
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + SCORE; // Ustawiamy tekst wyniku
    }
}
