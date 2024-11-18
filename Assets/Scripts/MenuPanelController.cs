using UnityEngine;

public class MenuPanelController : MonoBehaviour
{
    public GameObject menuPanel; // Referencja do panelu menu

    // Funkcja do w��czania panelu
    public void ShowMenuPanel()
    {
        if (menuPanel != null)
        {
            menuPanel.SetActive(true); // Ustaw panel jako aktywny
        }
        else
        {
            Debug.LogError("Menu panel nie zosta� przypisany w inspektorze!");
        }
    }

    // Funkcja do wy��czania panelu (opcjonalnie)
    public void HideMenuPanel()
    {
        if (menuPanel != null)
        {
            menuPanel.SetActive(false); // Ustaw panel jako nieaktywny
        }
    }
}

    
