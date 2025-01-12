/**
 * @file labDoMenuL.cs
 * @brief Skrypt obsługujący przejście do głównego menu gry.
 *
 * @details
 * Udostępnia metodę umożliwiającą załadowanie sceny głównego menu
 * z bieżącej sceny w grze.
 *
 * @note Scena głównego menu musi znajdować się pod indeksem 0 w Build Settings.
 *
 * @dependencies
 * UnityEngine.SceneManagement
 * 
 * @warning Upewnij się, że scena głównego menu istnieje.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * @class labDoMenuL
 * @brief Klasa obsługująca powrót do menu głównego.
 */
public class labDoMenuL : MonoBehaviour
{
    /**
     * @brief Ładuje scenę głównego menu.
     */
    public void doMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
