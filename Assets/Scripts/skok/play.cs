using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    public GameObject pauseMenu; // Referencja do panelu PauseMenu

    // Funkcja do pokazywania panelu PauseMenu
    public void ShowPauseMenu()
    {
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(true); // W³¹cz panel
        }
        else
        {
            Debug.LogError("PauseMenu nie zosta³o przypisane w inspektorze!");
        }
    }

    // Funkcja do ukrywania panelu PauseMenu
    public void HidePauseMenu()
    {
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(false); // Wy³¹cz panel
        }
        else
        {
            Debug.LogError("PauseMenu nie zosta³o przypisane w inspektorze!");
        }
    }

    // Funkcja do ukrycia panelu i wznowienia gry
    public void ResumeGame()
    {
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(false); // Wy³¹cz panel
        }
        Time.timeScale = 1f; // Wznowienie czasu gry
    }
}
