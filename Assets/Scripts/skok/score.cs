using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Referencja do pola tekstowego wyświetlającego wynik
    private int currentScore = 0;    // Aktualny wynik

    void Start()
    {
        UpdateScoreText(); // Zaktualizuj tekst na starcie
    }

    // Funkcja dodająca punkt do wyniku
    public void AddPoint()
    {
        currentScore++;       // Zwiększ wynik o 1
        UpdateScoreText();    // Zaktualizuj wyświetlany tekst
    }

    // Funkcja aktualizująca wyświetlany tekst wyniku
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + currentScore; // Wyświetl aktualny wynik
    }

    // Opcjonalna funkcja do resetowania wyniku
    public void ResetScore()
    {
        currentScore = 0;     // Ustaw wynik na 0
        UpdateScoreText();    // Zaktualizuj wyświetlany tekst
    }
}
