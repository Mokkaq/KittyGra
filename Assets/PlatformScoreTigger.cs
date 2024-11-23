using UnityEngine;
using TMPro; // Biblioteka dla obs�ugi TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Tekst do wy�wietlania wyniku
    private int score = 0;           // Wynik gracza

    // Funkcja zwi�kszaj�ca wynik o 1
    public void AddPoint()
    {
        score++; // Zwi�kszenie wyniku
        UpdateScoreText(); // Zaktualizowanie tekstu wyniku
    }

    // Funkcja aktualizuj�ca wy�wietlany tekst wyniku
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score; // Wy�wietlenie wyniku na ekranie
    }
}
