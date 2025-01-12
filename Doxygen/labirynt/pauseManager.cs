/**
 * @file pauseManager.cs
 * @brief Skrypt obsługujący funkcjonalność pauzy w grze.
 *
 * @details
 * Umożliwia zatrzymanie gry, wznowienie jej oraz powrót do menu głównego.
 * Obsługuje panel graficzny wyświetlany podczas pauzy.
 *
 * @note Wymaga przypisania GameObject dla panelu pauzy w edytorze Unity.
 *
 * @dependencies
 * UnityEngine.SceneManagement
 *
 * @warning Sprawdź, czy wszystkie komponenty są poprawnie przypisane.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * @class PauseManager
 * @brief Klasa zarządzająca funkcjami pauzy w grze.
 */
public class PauseManager : MonoBehaviour
{
    /// @brief Panel menu pauzy.
    public GameObject pauseMenuPanel;

    /// @brief Ustawia panel pauzy jako nieaktywny przy starcie gry.
    void Start()
    {
        pauseMenuPanel.SetActive(false);
    }

    /**
     * @brief Przełącza stan pauzy w grze.
     */
    public void TogglePause()
    {
        if (pauseMenuPanel.activeSelf)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }

    /**
     * @brief Zatrzymuje grę i wyświetla panel pauzy.
     */
    public void PauseGame()
    {
        pauseMenuPanel.SetActive(true);
        Time.timeScale = 0;
    }

    /**
     * @brief Wznawia grę i ukrywa panel pauzy.
     */
    public void ResumeGame()
    {
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1;
    }

    /**
     * @brief Przechodzi do menu głównego gry.
     */
    public void GoToMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
