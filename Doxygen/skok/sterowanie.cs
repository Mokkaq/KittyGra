/**
 * @file sterowanie.cs
 * @brief Skrypt obsługujący ruch gracza za pomocą akcelerometru.
 *
 * @details
 * Gracz przesuwa się w osi X na podstawie wychylenia urządzenia.
 *
 * @dependencies
 * UnityEngine
 *
 * @note Urządzenie musi obsługiwać akcelerometr.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;

/**
 * @class PlayerMovement
 * @brief Klasa obsługująca ruch gracza za pomocą akcelerometru.
 */
public class PlayerMovement : MonoBehaviour
{
    /// @brief Prędkość przesuwania gracza.
    public float speed = 5f;

    /**
     * @brief Aktualizuje pozycję gracza na podstawie akcelerometru.
     */
    void Update()
    {
        float move = Input.acceleration.x;
        transform.position += new Vector3(move * speed * Time.deltaTime, 0, 0);
    }
}
