using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Referencja do wy�wietlanego wyniku
    public TextMeshProUGUI highScoresText; // Referencja do wy�wietlania najlepszych wynik�w

    private int SCORE = 0; // Aktualny wynik
    private int[] highScores = new int[4]; // Tablica na 4 najlepsze wyniki

    private const string HighScoresKey = "HighScores"; // Klucz do zapisu w PlayerPrefs

    void Start()
    {
        LoadHighScores(); // �adowanie zapisanych najlepszych wynik�w
        UpdateHighScoresText(); // Aktualizowanie tekstu na ekranie
    }

    public void AddPoint()
    {
        SCORE++; // Zwi�kszamy wynik o 1
        UpdateScoreText(); // Aktualizowanie tekstu wyniku
    }

    public void SaveScore()
    {
        // Je�li wynik gracza jest lepszy ni� kt�rykolwiek z 4 wynik�w, dodaj go do tablicy
        for (int i = 0; i < highScores.Length; i++)
        {
            if (SCORE > highScores[i])
            {
                // Przesuwamy wyniki w d�, aby zrobi� miejsce na nowy wynik
                for (int j = highScores.Length - 1; j > i; j--)
                {
                    highScores[j] = highScores[j - 1];
                }
                highScores[i] = SCORE; // Wstawiamy nowy wynik
                break;
            }
        }
        SaveHighScores(); // Zapisz najlepsze wyniki
        UpdateHighScoresText(); // Aktualizuj wy�wietlane wyniki
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
            highScoresText.text += (i + 1) + ". " + highScores[i] + "\n"; // Wy�wietlanie najlepszych wynik�w
        }
    }

    private void SaveHighScores()
    {
        // Zapisujemy tablic� wynik�w jako ci�g znak�w (JSON lub ci�g liczbowy)
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
            // Je�li brak danych, inicjalizujemy tablic� zerami
            for (int i = 0; i < highScores.Length; i++)
            {
                highScores[i] = 0;
            }
        }
    }

    // Funkcja resetuj�ca wynik, aby przy ka�dej nowej grze zaczyna� od 0
    public void ResetScore()
    {
        SCORE = 0; // Resetowanie wyniku
        UpdateScoreText(); // Aktualizacja tekstu wyniku
    }
}
