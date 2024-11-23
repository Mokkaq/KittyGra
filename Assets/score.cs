using UnityEngine;
using TMPro; // Obs�uga tekstu dla TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Referencja do tekstu na ekranie
    private int SCORE = 0;            // Aktualny wynik

    // Funkcja do zwi�kszania wyniku
    public void AddPoint()
    {
        SCORE++; // Zwi�kszamy wynik o 1
        UpdateScoreText();
    }

    // Aktualizacja wy�wietlanego wyniku
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + SCORE; // Ustawiamy tekst wyniku
    }
}
