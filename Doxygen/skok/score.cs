/**
 * @file score.cs
 * @brief Skrypt zarządzający wynikiem gracza.
 *
 * @details
 * Obsługuje aktualizację i wyświetlanie wyniku w grze.
 *
 * @dependencies
 * UnityEngine, TMPro
 *
 * @note Wymaga przypisania komponentu TextMeshProUGUI w inspektorze Unity.
 * 
 * @warning Brak przypisanego komponentu może spowodować błędy.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;
using TMPro;

/**
 * @class ScoreManager
 * @brief Klasa zarządzająca wynikiem gracza.
 */
public class ScoreManager : MonoBehaviour
{
    /// @brief Referencja do pola tekstowego wyświetlającego wynik.
    public TextMeshProUGUI scoreText;

    private int currentScore = 0;

    /**
     * @brief Inicjalizuje wynik na początku gry.
     */
    void Start()
    {
        UpdateScoreText();
    }

    /**
     * @brief Dodaje punkt do wyniku.
     */
    public void AddPoint()
    {
        currentScore++;
        UpdateScoreText();
    }

    /**
     * @brief Aktualizuje wyświetlany wynik.
     */
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + currentScore;
    }

    /**
     * @brief Resetuje wynik do zera.
     */
    public void ResetScore()
    {
        currentScore = 0;
        UpdateScoreText();
    }
}
