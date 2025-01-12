/**
 * @file wybicie.cs
 * @brief Skrypt obsługujący odbijanie się gracza od powierzchni.
 *
 * @details
 * Gracz odbija się od obiektów oznaczonych jako "Ground" lub "Platform".
 * Gra resetuje się, jeśli gracz spadnie poniżej określonego poziomu.
 *
 * @dependencies
 * UnityEngine, UnityEngine.SceneManagement
 *
 * @note Obiekty muszą mieć odpowiednie tagi ("Ground", "Platform").
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * @class PlayerBounce
 * @brief Klasa obsługująca odbijanie się gracza.
 */
public class PlayerBounce : MonoBehaviour
{
    /// @brief Siła odbicia gracza.
    public float bounceForce = 12f;

    /// @brief Poziom, poniżej którego gra się resetuje.
    public float fallLimit = -10f;

    private Rigidbody2D rb;

    /**
     * @brief Inicjalizuje komponent Rigidbody2D gracza.
     */
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    /**
     * @brief Sprawdza pozycję gracza i resetuje grę w razie potrzeby.
     */
    void Update()
    {
        if (transform.position.y < fallLimit)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    /**
     * @brief Obsługuje odbicie gracza po kolizji.
     * @param collision Obiekt kolizji.
     */
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Platform"))
        {
            rb.velocity = new Vector2(rb.velocity.x, bounceForce);
        }
    }
}
