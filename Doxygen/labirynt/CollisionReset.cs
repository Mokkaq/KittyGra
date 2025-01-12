/**
 * @file CollisionReset.cs
 * @brief Skrypt resetujący poziom po kolizji z platformą.
 *
 * @details
 * Obsługuje wykrywanie kolizji z obiektami oznaczonymi jako "Platform"
 * i resetuje scenę po takim zdarzeniu.
 *
 * @note Wymaga tagu "Platform" przypisanego do obiektów kolizyjnych.
 *
 * @dependencies
 * UnityEngine.SceneManagement
 *
 * @warning Upewnij się, że tag "Platform" jest poprawnie przypisany.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * @class CollisionReset
 * @brief Klasa resetująca poziom po kolizji.
 *
 * @details
 * Monitoruje kolizje z platformami i w razie potrzeby przeładowuje aktualną scenę.
 */
public class CollisionReset : MonoBehaviour
{
    /// @brief Obsługa kolizji.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            ResetLevel();
        }
    }

    /// @brief Resetuje bieżącą scenę.
    private void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
