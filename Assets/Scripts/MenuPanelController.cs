using UnityEngine;

public class MenuPanelController : MonoBehaviour
{
    public GameObject menuPanel; // Referencja do panelu menu

    // Funkcja do w³¹czania panelu
    public void ShowMenuPanel()
    {
        if (menuPanel != null)
        {
            menuPanel.SetActive(true); // Ustaw panel jako aktywny
        }
        else
        {
            Debug.LogError("Menu panel nie zosta³ przypisany w inspektorze!");
        }
    }

    // Funkcja do wy³¹czania panelu (opcjonalnie)
    public void HideMenuPanel()
    {
        if (menuPanel != null)
        {
            menuPanel.SetActive(false); // Ustaw panel jako nieaktywny
        }
    }
}

    
