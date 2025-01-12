/**
 * @file MenuPanelController.cs
 * @brief Skrypt obsługujący panel menu w grze.
 *
 * @details
 * Pozwala na wyświetlenie panelu menu oraz zatrzymanie gry.
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
 * @class MenuPanelController
 * @brief Klasa obsługująca panel menu w grze.
 */
public class MenuPanelController : MonoBehaviour
{
    /// @brief Referencja do panelu menu.
    public GameObject menuPanel;

    /**
     * @brief Wyświetla panel menu i zatrzymuje grę.
     */
    public void ShowMenuPanel()
    {
        if (menuPanel != null)
        {
            menuPanel.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            Debug.LogError("Menu panel nie został przypisany w inspektorze!");
        }
    }
}
