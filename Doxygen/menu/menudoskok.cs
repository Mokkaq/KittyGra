/**
 * @file menudoskok.cs
 * @brief Skrypt obsługujący przejście do sceny skoku.
 *
 * @details
 * Umożliwia załadowanie sceny o indeksie 2 z bieżącej sceny.
 *
 * @dependencies
 * UnityEngine.SceneManagement
 *
 * @note Scena skoku musi być przypisana w Build Settings.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * @class menuDoSkok
 * @brief Klasa obsługująca przejście do sceny skoku.
 */
public class menuDoSkok : MonoBehaviour
{
    /**
     * @brief Ładuje scenę skoku.
     */
    public void doSkoku()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
