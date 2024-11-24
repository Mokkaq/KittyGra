using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Referencja do pola tekstowego wy�wietlaj�cego wynik
    private int currentScore = 0;    // Aktualny wynik

    void Start()
    {
        UpdateScoreText(); // Zaktualizuj tekst na starcie
    }

    // Funkcja dodaj�ca punkt do wyniku
    public void AddPoint()
    {
        currentScore++;       // Zwi�ksz wynik o 1
        UpdateScoreText();    // Zaktualizuj wy�wietlany tekst
    }

    // Funkcja aktualizuj�ca wy�wietlany tekst wyniku
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + currentScore; // Wy�wietl aktualny wynik
    }

    // Opcjonalna funkcja do resetowania wyniku
    public void ResetScore()
    {
        currentScore = 0;     // Ustaw wynik na 0
        UpdateScoreText();    // Zaktualizuj wy�wietlany tekst
    }
}
