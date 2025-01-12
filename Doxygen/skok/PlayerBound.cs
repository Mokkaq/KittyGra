/**
 * @file PlayerBound.cs
 * @brief Skrypt zarządzający kolizją gracza z platformami podczas skoku.
 *
 * @details
 * Automatycznie włącza lub wyłącza kolizje z platformami w zależności od ruchu gracza w osi Y.
 *
 * @dependencies
 * UnityEngine
 *
 * @note Warstwy "Player" i "Platform" muszą być skonfigurowane w edytorze Unity.
 * 
 * @warning Nieprawidłowa konfiguracja warstw może prowadzić do błędów.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;

/**
 * @class PlatformPassOnJumpWithoutVelocity
 * @brief Klasa zarządzająca kolizjami gracza z platformami podczas skoku.
 */
public class PlatformPassOnJumpWithoutVelocity : MonoBehaviour
{
    private float lastYPosition;
    private Collider2D playerCollider;

    /**
     * @brief Inicjalizuje kolizje gracza.
     */
    void Start()
    {
        playerCollider = GetComponent<Collider2D>();
        lastYPosition = transform.position.y;
    }

    /**
     * @brief Aktualizuje stan kolizji w zależności od ruchu gracza.
     */
    void Update()
    {
        if (transform.position.y > lastYPosition)
        {
            Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Platform"), true);
        }
        else
        {
            Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Platform"), false);
        }

        lastYPosition = transform.position.y;
    }
}
