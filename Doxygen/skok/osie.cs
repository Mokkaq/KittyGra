/**
 * @file osie.cs
 * @brief Skrypt obsługujący ruch gracza w osi X za pomocą akcelerometru.
 *
 * @details
 * Przesuwa obiekt w lewo lub prawo w zależności od wychylenia urządzenia.
 * Ruch jest ograniczony do widocznego obszaru ekranu.
 *
 * @dependencies
 * UnityEngine
 *
 * @note Urządzenie musi obsługiwać akcelerometr.
 * 
 * @warning Należy dostosować ograniczenia ekranu do rozdzielczości gry.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;

/**
 * @class Update_playerController
 * @brief Klasa zarządzająca ruchem gracza za pomocą akcelerometru.
 */
public class Update_playerController : MonoBehaviour
{
    /// @brief Prędkość ruchu gracza.
    public float moveSpeed = 5.0f;

    /// @brief Maksymalne przesunięcie w osi X.
    public float screenLimitX = 2.5f;

    /**
     * @brief Aktualizuje pozycję gracza na podstawie akcelerometru.
     */
    void Update()
    {
        float moveInput = Input.acceleration.x;
        Vector3 movement = new Vector3(moveInput * moveSpeed, 0, 0);
        transform.Translate(movement * Time.deltaTime);

        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(transform.position.x, -screenLimitX, screenLimitX);
        transform.position = clampedPosition;
    }
}
