using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    public GameObject PauseMenu; // Referencja do panelu PauseMenu

    public void TogglePauseMenu()
    {
        if (PauseMenu == null)
        {
            Debug.LogError("PauseMenu nie zosta³o przypisane w inspektorze!");
            return;
        }

        // Sprawdzamy, czy panel jest aktywny, i prze³¹czamy jego widocznoœæ
        bool isActive = PauseMenu.activeSelf;
        PauseMenu.SetActive(!isActive);
    }

    public void ShowPauseMenu()
    {
        if (PauseMenu != null)
        {
            PauseMenu.SetActive(true); // W³¹cz panel
        }
        else
        {
            Debug.LogError("PauseMenu nie zosta³o przypisane w inspektorze!");
        }
    }

    public void HidePauseMenu()
    {
        if (PauseMenu != null)
        {
            PauseMenu.SetActive(false); // Wy³¹cz panel
        }
    }
}
