/**
 * @file PlayerPlatformPassThrough.cs
 * @brief Skrypt zarządzający kolizjami gracza z platformami.
 *
 * @details
 * Wyłącza kolizje z platformami podczas ruchu w górę, umożliwiając ich przejście.
 *
 * @dependencies
 * UnityEngine
 *
 * @note Warstwy "Player" i "Platform" muszą być poprawnie skonfigurowane.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;

/**
 * @class PlayerPlatformPassThroughWithoutVelocity
 * @brief Klasa zarządzająca przechodzeniem gracza przez platformy.
 */
public class PlayerPlatformPassThroughWithoutVelocity : MonoBehaviour
{
    private Collider2D playerCollider;
    private float lastYPosition;

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
