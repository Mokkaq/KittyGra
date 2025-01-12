/**
 * @file PlayButton.cs
 * @brief Skrypt obsługujący działanie przycisku "Play".
 *
 * @details
 * Ukrywa panel menu i wznawia grę po naciśnięciu przycisku.
 *
 * @dependencies
 * UnityEngine
 *
 * @note Panel menu musi być przypisany w inspektorze Unity.
 * 
 * @warning Brak przypisanego panelu menu spowoduje błędy.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;

/**
 * @class PlayButtonController
 * @brief Klasa obsługująca działanie przycisku "Play".
 */
public class PlayButtonController : MonoBehaviour
{
    /// @brief Referencja do panelu menu.
    public GameObject menuPanel;

    /**
     * @brief Obsługuje zdarzenie naciśnięcia przycisku "Play".
     */
    public void OnPlayButtonPressed()
    {
        if (menuPanel != null)
        {
            menuPanel.SetActive(false);
            Time.timeScale = 1f;
        }
        else
        {
            Debug.LogError("Menu panel nie został przypisany w inspektorze!");
        }
    }
}
