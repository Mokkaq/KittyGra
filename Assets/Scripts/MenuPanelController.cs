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
            Time.timeScale = 0f;       // Zatrzymaj czas gry
        }
        else
        {
            Debug.LogError("Menu panel nie zosta� przypisany w inspektorze!");
        }
    }
}
  