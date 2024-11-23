using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance; // Statyczna instancja dostępna globalnie

    public TextMeshProUGUI scoreText; // Referencja do tekstu wyświetlającego wynik
    private int score = 0;           // Aktualny wynik

    private void Awake()
    {
        // Ustaw statyczną instancję
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Funkcja zwiększająca wynik o 1
    public void AddPoint()
    {
        score++; // Zwiększ wynik
        UpdateScoreText();
    }

    // Funkcja aktualizująca wyświetlany tekst wyniku
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}

