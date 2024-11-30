using UnityEngine;

public class PlayerPlatformPassThroughWithoutVelocity : MonoBehaviour
{
    private Collider2D playerCollider; // Collider gracza
    private float lastYPosition;      // Pozycja gracza z poprzedniej klatki

    void Start()
    {
        // Pobierz Collider gracza
        playerCollider = GetComponent<Collider2D>();
        // Zapisz pocz¹tkow¹ pozycjê Y gracza
        lastYPosition = transform.position.y;
    }

    void Update()
    {
        // SprawdŸ, czy gracz porusza siê w górê
        if (transform.position.y > lastYPosition)
        {
            // Wy³¹cz kolizjê z platformami
            Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Platform"), true);
        }
        else
        {
            // W³¹cz kolizjê z platformami
            Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Platform"), false);
        }

        // Zaktualizuj poprzedni¹ pozycjê gracza
        lastYPosition = transform.position.y;
    }
}
