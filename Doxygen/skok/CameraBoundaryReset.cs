/**
 * @file CameraBoundaryReset.cs
 * @brief Skrypt resetujący grę, jeśli gracz opuści widoczny obszar kamery.
 *
 * @details
 * Oblicza granice widocznego obszaru kamery i resetuje scenę, gdy gracz wyjdzie poza te granice.
 *
 * @dependencies
 * UnityEngine, UnityEngine.SceneManagement
 *
 * @note Gracz musi być przypisany w inspektorze Unity.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * @class CameraBoundaryReset
 * @brief Klasa obsługująca reset gry w przypadku opuszczenia kamery przez gracza.
 */
public class CameraBoundaryReset : MonoBehaviour
{
    /// @brief Transform gracza.
    public Transform player;

    /**
     * @brief Sprawdza, czy gracz znajduje się w widocznym obszarze kamery.
     */
    void Update()
    {
        Vector3 screenBottomLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));
        Vector3 screenTopRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, Camera.main.nearClipPlane));

        if (player.position.x < screenBottomLeft.x || player.position.x > screenTopRight.x ||
            player.position.y < screenBottomLeft.y || player.position.y > screenTopRight.y)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
