/**
 * @file scroll.cs
 * @brief Skrypt obsługujący przewijanie tła w grze.
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
 * @class tło_2Scroller
 * @brief Klasa obsługująca przewijanie tła.
 */
public class tło_2Scroller : MonoBehaviour
{
    /// @brief Prędkość przewijania tła.
    public float scrollSpeed = 0.5f;

    private Renderer rend;

    /**
     * @brief Inicjalizuje komponent Renderer.
     */
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    /**
     * @brief Aktualizuje offset tekstury tła.
     */
    void Update()
    {
        float offset = Time.time * scrollSpeed;
        rend.material.mainTextureOffset = new Vector2(0, -offset);
    }
}
