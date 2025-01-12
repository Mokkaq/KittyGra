/**
 * @file PointTrigger.cs
 * @brief Skrypt obsługujący przyznawanie punktów za przejście platformy.
 *
 * @details
 * Ten skrypt wykrywa kolizję z obiektami oznaczonymi jako "Platform" i
 * przyznaje graczowi punkty, wykorzystując singleton PunktyManL.
 *
 * @note Obiekt, do którego przypisany jest ten skrypt, musi posiadać komponent Collider2D
 * ustawiony jako trigger.
 *
 * @dependencies
 * UnityEngine
 *
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;

/**
 * @class PointTrigger
 * @brief Klasa odpowiedzialna za dodawanie punktów po przekroczeniu platformy.
 */
public class PointTrigger : MonoBehaviour
{
    /// @brief Liczba punktów za przejście jednej platformy.
    public int punktyZaPrzejscie = 1;

    /**
     * @brief Obsługuje zdarzenie wejścia w pole triggera.
     * @param collision Obiekt, który wszedł w pole triggera.
     *
     * @details
     * Dodaje punkty do wyniku, jeśli obiekt, który wszedł w trigger,
     * posiada tag "Platform".
     */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Platform"))
        {
            PunktyManL.Instance.DodajPunkty(punktyZaPrzejscie);
        }
    }
}
