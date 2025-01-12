/**
 * @file BackgroundScroller_2.cs
 * @brief Skrypt do przewijania tła w grze.
 *
 * @details
 * Przesuwa teksturę tła w osi Y, tworząc efekt ruchu.
 *
 * @dependencies
 * UnityEngine
 *
 * @note Wymaga komponentu Renderer przypisanego do obiektu tła.
 * 
 * @warning Brak przypisanego materiału w Rendererze może spowodować błędy.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;

/**
 * @class backgroundScroller
 * @brief Klasa obsługująca przewijanie tła w grze.
 */
public class backgroundScroller : MonoBehaviour
{
    /// @brief Prędkość przewijania tła.
    public float scrollSpeed;

    private Vector2 offset;

    /**
     * @brief Aktualizuje offset tekstury tła.
     */
    void Update()
    {
        offset = new Vector2(0, Time.time * scrollSpeed);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
