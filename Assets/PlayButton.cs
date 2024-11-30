using UnityEngine;

public class PlayButtonController : MonoBehaviour
{
    public GameObject menuPanel; // Referencja do panelu menu

    public void OnPlayButtonPressed()
    {
        if (menuPanel != null)
        {
            menuPanel.SetActive(false); // Wy��cz panel menu
            Time.timeScale = 1f;        // Wzn�w czas gry
        }
        else
        {
            Debug.LogError("Menu panel nie zosta� przypisany w inspektorze!");
        }
    }
}
