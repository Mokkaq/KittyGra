/**
 * @file tłociągłe.cs
 * @brief Skrypt obsługujący pętlę tła w grze.
 *
 * @details
 * Tło przesuwa się w osi Y z określoną prędkością i resetuje swoją pozycję,
 * gdy osiągnie określoną wysokość.
 *
 * @dependencies
 * UnityEngine
 *
 * @note Tło musi być przypisane w inspektorze Unity.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;

/**
 * @class BackgroundLoop
 * @brief Klasa obsługująca pętlę przewijania tła.
 */
public class BackgroundLoop : MonoBehaviour
{
    /// @brief Wysokość tła.
    public float backgroundHeight = 10f;

    /// @brief Prędkość przewijania tła.
    public float scrollSpeed = 2f;

    private Vector3 startPosition;

    /**
     * @brief Inicjalizuje początkową pozycję tła.
     */
    void Start()
    {
        startPosition = transform.position;
    }

    /**
     * @brief Aktualizuje pozycję tła w każdej klatce.
     */
    void Update()
    {
        transform.Translate(Vector3.up * scrollSpeed * Time.deltaTime);

        if (transform.position.y >= startPosition.y + backgroundHeight)
        {
            transform.position = startPosition;
        }
    }
}
