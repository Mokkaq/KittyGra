/**
 * @file BackgroundScroller.cs
 * @brief Skrypt do przewijania tła w grze.
 *
 * @details
 * Umożliwia ciągłe przesuwanie tekstury tła w osi Y, co tworzy efekt ruchu w grze.
 *
 * @note Wymaga komponentu Renderer w obiekcie tła.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;

/**
 * @class BackgroundScroller
 * @brief Klasa obsługująca przewijanie tekstury tła.
 *
 * @details
 * Steruje offsetem tekstury, aby symulować ruch tła w osi Y.
 */
public class BackgroundScroller : MonoBehaviour
{
    /// @brief Prędkość przewijania tła.
    public float scrollSpeed = 0.5f;

    /// @brief Komponent Renderer obsługujący teksturę.
    private Renderer rend;

    /// @brief Inicjalizacja komponentów.
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    /// @brief Aktualizacja offsetu tekstury.
    void Update()
    {
        float offset = Time.time * scrollSpeed;
        rend.material.mainTextureOffset = new Vector2(0, -offset);
    }
}
