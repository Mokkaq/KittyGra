using UnityEngine;

public class PlayButtonController : MonoBehaviour
{
    public GameObject menuPanel; // Referencja do panelu menu

    public void OnPlayButtonPressed()
    {
        if (menuPanel != null)
        {
            menuPanel.SetActive(false); // Wy³¹cz panel menu
            Time.timeScale = 1f;        // Wznów czas gry
        }
        else
        {
            Debug.LogError("Menu panel nie zosta³ przypisany w inspektorze!");
        }
    }
}
