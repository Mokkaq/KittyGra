using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Referencja do wyœwietlanego wyniku
    public TextMeshProUGUI highScoresText; // Referencja do wyœwietlania najlepszych wyników

    private int SCORE = 0; // Aktualny wynik
    private int[] highScores = new int[4]; // Tablica na 4 najlepsze wyniki

    private const string HighScoresKey = "HighScores"; // Klucz do zapisu w PlayerPrefs

    void Start()
    {
        LoadHighScores(); // £adowanie zapisanych najlepszych wyników
        UpdateHighScoresText(); // Aktualizowanie tekstu na ekranie
    }

    public void AddPoint()
    {
        SCORE++; // Zwiêkszamy wynik o 1
        UpdateScoreText(); // Aktualizowanie tekstu wyniku
    }

    public void SaveScore()
    {
        // Jeœli wynik gracza jest lepszy ni¿ którykolwiek z 4 wyników, dodaj go do tablicy
        for (int i = 0; i < highScores.Length; i++)
        {
            if (SCORE > highScores[i])
            {
                // Przesuwamy wyniki w dó³, aby zrobiæ miejsce na nowy wynik
                for (int j = highScores.Length - 1; j > i; j--)
                {
                    highScores[j] = highScores[j - 1];
                }
                highScores[i] = SCORE; // Wstawiamy nowy wynik
                break;
            }
        }
        SaveHighScores(); // Zapisz najlepsze wyniki
        UpdateHighScoresText(); // Aktualizuj wyœwietlane wyniki
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + SCORE; // Ustawiamy tekst wyniku
    }

    private void UpdateHighScoresText()
    {
        highScoresText.text = "High Scores:\n";
        for (int i = 0; i < highScores.Length; i++)
        {
            highScoresText.text += (i + 1) + ". " + highScores[i] + "\n"; // Wyœwietlanie najlepszych wyników
        }
    }

    private void SaveHighScores()
    {
        // Zapisujemy tablicê wyników jako ci¹g znaków (JSON lub ci¹g liczbowy)
        string highScoresString = string.Join(",", highScores);
        PlayerPrefs.SetString(HighScoresKey, highScoresString);
        PlayerPrefs.Save(); // Zapisz zmiany w PlayerPrefs
    }

    private void LoadHighScores()
    {
        if (PlayerPrefs.HasKey(HighScoresKey))
        {
            // Wczytaj zapisane wyniki
            string highScoresString = PlayerPrefs.GetString(HighScoresKey);
            string[] scores = highScoresString.Split(',');
            for (int i = 0; i < scores.Length; i++)
            {
                highScores[i] = int.Parse(scores[i]);
            }
        }
        else
        {
            // Jeœli brak danych, inicjalizujemy tablicê zerami
            for (int i = 0; i < highScores.Length; i++)
            {
                highScores[i] = 0;
            }
        }
    }

    // Funkcja resetuj¹ca wynik, aby przy ka¿dej nowej grze zaczynaæ od 0
    public void ResetScore()
    {
        SCORE = 0; // Resetowanie wyniku
        UpdateScoreText(); // Aktualizacja tekstu wyniku
    }
}
