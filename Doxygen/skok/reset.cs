/**
 * @file reset.cs
 * @brief Skrypt resetujący bieżącą scenę gry.
 *
 * @details
 * Pozwala na ponowne załadowanie aktualnej sceny w celu zresetowania stanu gry.
 *
 * @dependencies
 * UnityEngine, UnityEngine.SceneManagement
 *
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * @class GameManager
 * @brief Klasa obsługująca reset gry.
 */
public class GameManager : MonoBehaviour
{
    /**
     * @brief Resetuje bieżącą scenę.
     */
    public void ResetGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
