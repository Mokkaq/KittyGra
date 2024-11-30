using UnityEngine;

public class PlatformPassOnJumpWithoutVelocity : MonoBehaviour
{
    private float lastYPosition; // Poprzednia pozycja gracza w osi Y
    private Collider2D playerCollider; // Collider gracza

    void Start()
    {
        // Pobierz Collider gracza
        playerCollider = GetComponent<Collider2D>();
        // Zapisz pocz�tkow� pozycj� Y gracza
        lastYPosition = transform.position.y;
    }

    void Update()
    {
        // Sprawd�, czy gracz porusza si� w g�r�
        if (transform.position.y > lastYPosition)
        {
            // Wy��cz kolizj� z platformami
            Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Platform"), true);
        }
        else
        {
            // W��cz kolizj� z platformami
            Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Platform"), false);
        }

        // Zaktualizuj poprzedni� pozycj� gracza
        lastYPosition = transform.position.y;
    }
}
