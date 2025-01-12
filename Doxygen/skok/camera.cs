/**
 * @file camera.cs
 * @brief Skrypt obsługujący podążanie kamery za graczem.
 *
 * @details
 * Kamera przesuwa się w osi Y, aby śledzić ruch gracza, zapewniając odpowiedni widok.
 *
 * @dependencies
 * UnityEngine
 *
 * @note Gracz musi być przypisany w inspektorze Unity.
 * 
 * @warning Brak przypisanego gracza spowoduje błędy.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;

/**
 * @class CameraFollow
 * @brief Klasa obsługująca ruch kamery w grze.
 */
public class CameraFollow : MonoBehaviour
{
    /// @brief Transform gracza do śledzenia.
    public Transform player;

    /// @brief Odległość kamery od gracza w osi Y.
    public float offset = 2f;

    /**
     * @brief Aktualizuje pozycję kamery w osi Y.
     */
    void Update()
    {
        if (player.position.y > transform.position.y - offset)
        {
            transform.position = new Vector3(transform.position.x, player.position.y + offset, transform.position.z);
        }
    }
}
