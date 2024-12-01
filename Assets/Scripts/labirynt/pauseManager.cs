using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenuPanel; // Panel menu pauzy

    void Start()
    {
        // Ustaw panel menu pauzy jako nieaktywny na pocz�tku gry
        pauseMenuPanel.SetActive(false);
    }

    public void TogglePause()
    {
        if (pauseMenuPanel.activeSelf)
        {
            // Je�li panel pauzy jest w��czony, wznowienie gry
            ResumeGame();
        }
        else
        {
            // W��czenie pauzy
            PauseGame();
        }
    }

    public void PauseGame()
    {
        // Aktywuj panel pauzy i zatrzymaj czas gry
        pauseMenuPanel.SetActive(true);
        Time.timeScale = 0; // Zatrzymanie czasu gry
    }

    public void ResumeGame()
    {
        // Ukryj panel pauzy i wznow czas gry
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1; // Wznowienie czasu gry
    }

    public void GoToMainMenu()
    {
        // Powr�t do menu g��wnego (nale�y upewni� si�, �e scena o nazwie "Menu" istnieje)
        Time.timeScale = 1; // Wznowienie czasu przed zmian� sceny
        SceneManager.LoadScene("Menu");
    }
}
