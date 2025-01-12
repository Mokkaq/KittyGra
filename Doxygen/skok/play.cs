/**
 * @file play.cs
 * @brief Skrypt zarządzający menu pauzy w grze.
 *
 * @details
 * Oferuje funkcje do wyświetlania, ukrywania i wznawiania gry poprzez panel pauzy.
 *
 * @dependencies
 * UnityEngine
 *
 * @note Wymaga przypisania obiektu PauseMenu w inspektorze Unity.
 *
 * @warning Brak przypisanego panelu może prowadzić do błędów w działaniu.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;

/**
 * @class PauseMenuController
 * @brief Klasa obsługująca panel pauzy w grze.
 */
public class PauseMenuController : MonoBehaviour
{
    /// @brief Referencja do panelu pauzy.
    public GameObject pauseMenu;

    /**
     * @brief Wyświetla panel pauzy.
     */
    public void ShowPauseMenu()
    {
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(true);
        }
        else
        {
            Debug.LogError("PauseMenu nie zostało przypisane w inspektorze!");
        }
    }

    /**
     * @brief Ukrywa panel pauzy.
     */
    public void HidePauseMenu()
    {
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(false);
        }
        else
        {
            Debug.LogError("PauseMenu nie zostało przypisane w inspektorze!");
        }
    }

    /**
     * @brief Wznawia grę i ukrywa panel pauzy.
     */
    public void ResumeGame()
    {
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(false);
        }
        Time.timeScale = 1f;
    }
}
