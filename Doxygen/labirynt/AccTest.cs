/**
 * @file AccTest.cs
 * @brief Skrypt obsługujący ruch gracza na podstawie akcelerometru.
 *
 * @details
 * Ten skrypt umożliwia poruszanie się gracza w osi X za pomocą akcelerometru.
 * Ruch jest ograniczony do obszaru widocznego na ekranie.
 *
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;

/**
 * @class Update_PlayerController
 * @brief Klasa zarządzająca ruchem gracza.
 *
 * @details
 * Przesuwa obiekt gracza w lewo lub prawo na podstawie wartości z akcelerometru,
 * ograniczając jego pozycję w osi X do określonego zakresu.
 */
public class Update_PlayerController : MonoBehaviour
{
    /// @brief Prędkość ruchu gracza.
    public float moveSpeed = 5.0f;

    /// @brief Maksymalne przesunięcie w osi X.
    public float screenLimitX = 2.5f;

    /// @brief Aktualizuje pozycję gracza na podstawie akcelerometru.
    void Update()
    {
        float moveInput = Input.acceleration.x;  // Odczyt wartości akcelerometru.
        Vector3 movement = new Vector3(moveInput * moveSpeed, 0, 0);
        transform.Translate(movement * Time.deltaTime);

        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(transform.position.x, -screenLimitX, screenLimitX);
        transform.position = clampedPosition;  // Ograniczenie ruchu.
    }
}
