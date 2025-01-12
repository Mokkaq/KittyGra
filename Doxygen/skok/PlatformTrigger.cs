/**
 * @file PlatformTrigger.cs
 * @brief Skrypt obsługujący przyznawanie punktów za interakcję z platformą.
 *
 * @details
 * Dodaje punkty do wyniku gracza po kolizji gracza z platformą.
 *
 * @dependencies
 * UnityEngine
 *
 * @note Obiekt gracza i system punktacji muszą być poprawnie skonfigurowane.
 * 
 * @warning Brak przypisanego ScoreManager może prowadzić do błędów.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;

/**
 * @class PlatformScoreTrigger
 * @brief Klasa odpowiedzialna za dodawanie punktów po interakcji z platformą.
 */
public class PlatformScoreTrigger : MonoBehaviour
{
    /// @brief Flaga sprawdzająca, czy punkt został już naliczony.
    private bool hasScored = false;

    /// @brief Referencja do ScoreManager.
    public ScoreManager scoreManager;

    /**
     * @brief Obsługuje zdarzenie kolizji gracza z platformą.
     * @param collision Obiekt kolidujący.
     */
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !hasScored)
        {
            hasScored = true;
            scoreManager.AddPoint();
        }
    }
}
