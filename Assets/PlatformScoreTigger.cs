using UnityEngine;
using TMPro; // Biblioteka dla obsługi TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Tekst do wyświetlania wyniku
    private int score = 0;           // Wynik gracza

    // Funkcja zwiększająca wynik o 1
    public void AddPoint()
    {
        score++; // Zwiększenie wyniku
        UpdateScoreText(); // Zaktualizowanie tekstu wyniku
    }

    // Funkcja aktualizująca wyświetlany tekst wyniku
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score; // Wyświetlenie wyniku na ekranie
    }
}
