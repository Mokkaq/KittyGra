/**
 * @file cam.cs
 * @brief Skrypt obsługujący reset gry po upadku gracza poza ekran.
 *
 * @details
 * Oblicza dolną granicę widocznego obszaru kamery i resetuje scenę,
 * jeśli gracz opuści ekran.
 *
 * @dependencies
 * UnityEngine, UnityEngine.SceneManagement
 *
 * @note Gracz musi być odpowiednio oznaczony i widoczny w kamerze.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * @class PlayerFallReset
 * @brief Klasa resetująca grę po upadku gracza poza ekran.
 */
public class PlayerFallReset : MonoBehaviour
{
    private Camera mainCamera;
    private float screenBottomY;

    /**
     * @brief Inicjalizuje główną kamerę.
     */
    void Start()
    {
        mainCamera = Camera.main;
    }

    /**
     * @brief Sprawdza, czy gracz znajduje się poniżej dolnej granicy ekranu.
     */
    void Update()
    {
        screenBottomY = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, mainCamera.nearClipPlane)).y;

        if (transform.position.y < screenBottomY)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
