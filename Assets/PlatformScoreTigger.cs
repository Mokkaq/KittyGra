using UnityEngine;
using TMPro; // Biblioteka dla obs³ugi TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Tekst do wyœwietlania wyniku
    private int score = 0;           // Wynik gracza

    // Funkcja zwiêkszaj¹ca wynik o 1
    public void AddPoint()
    {
        score++; // Zwiêkszenie wyniku
        UpdateScoreText(); // Zaktualizowanie tekstu wyniku
    }

    // Funkcja aktualizuj¹ca wyœwietlany tekst wyniku
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score; // Wyœwietlenie wyniku na ekranie
    }
}
