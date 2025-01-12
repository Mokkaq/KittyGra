/**
 * @file menuDoLab.cs
 * @brief Skrypt obsługujący przejście do sceny labiryntu.
 *
 * @details
 * Umożliwia załadowanie sceny o indeksie 1 z bieżącej sceny.
 *
 * @dependencies
 * UnityEngine.SceneManagement
 *
 * @note Scena labiryntu musi być przypisana w Build Settings.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * @class menuDoLab
 * @brief Klasa obsługująca przejście do sceny labiryntu.
 */
public class menuDoLab : MonoBehaviour
{
    /**
     * @brief Ładuje scenę labiryntu.
     */
    public void doLabiryntu()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
