using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    public GameObject PauseMenu; // Referencja do panelu PauseMenu

    public void TogglePauseMenu()
    {
        if (PauseMenu == null)
        {
            Debug.LogError("PauseMenu nie zosta�o przypisane w inspektorze!");
            return;
        }

        // Sprawdzamy, czy panel jest aktywny, i prze��czamy jego widoczno��
        bool isActive = PauseMenu.activeSelf;
        PauseMenu.SetActive(!isActive);
    }

    public void ShowPauseMenu()
    {
        if (PauseMenu != null)
        {
            PauseMenu.SetActive(true); // W��cz panel
        }
        else
        {
            Debug.LogError("PauseMenu nie zosta�o przypisane w inspektorze!");
        }
    }

    public void HidePauseMenu()
    {
        if (PauseMenu != null)
        {
            PauseMenu.SetActive(false); // Wy��cz panel
        }
    }
}
