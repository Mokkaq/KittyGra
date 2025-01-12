/**
 * @file labDoMenu.cs
 * @brief Skrypt obsługujący przejście z bieżącej sceny do menu głównego.
 *
 * @details
 * Umożliwia załadowanie sceny menu głównego (o indeksie 0 w Build Settings).
 *
 * @dependencies
 * UnityEngine.SceneManagement
 *
 * @note Scena menu głównego musi być przypisana w Build Settings.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * @class labDoMenu
 * @brief Klasa obsługująca przejście do menu głównego.
 */
public class labDoMenu : MonoBehaviour
{
    /**
     * @brief Ładuje scenę menu głównego.
     */
    public void doMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
