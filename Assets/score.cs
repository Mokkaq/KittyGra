using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Referencja do pola tekstowego wyœwietlaj¹cego wynik
    private int currentScore = 0;    // Aktualny wynik

    void Start()
    {
        UpdateScoreText(); // Zaktualizuj tekst na starcie
    }

    // Funkcja dodaj¹ca punkt do wyniku
    public void AddPoint()
    {
        currentScore++;       // Zwiêksz wynik o 1
        UpdateScoreText();    // Zaktualizuj wyœwietlany tekst
    }

    // Funkcja aktualizuj¹ca wyœwietlany tekst wyniku
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + currentScore; // Wyœwietl aktualny wynik
    }

    // Opcjonalna funkcja do resetowania wyniku
    public void ResetScore()
    {
        currentScore = 0;     // Ustaw wynik na 0
        UpdateScoreText();    // Zaktualizuj wyœwietlany tekst
    }
}
