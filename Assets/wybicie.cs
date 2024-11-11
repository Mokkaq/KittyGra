using UnityEngine;
using UnityEngine.SceneManagement; // Dodaj, aby obs³ugiwaæ resetowanie sceny

public class PlayerBounce : MonoBehaviour
{
    public float bounceForce = 10f; // Si³a odbicia
    public float fallLimit = -10f;  // Wysokoœæ, przy której gra siê resetuje

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Sprawdzenie, czy obiekt spad³ poza ekran
        if (transform.position.y < fallLimit)
        {
            // Reset sceny
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Sprawdzenie, czy kolizja jest z ground lub platform
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Platform"))
        {
            // Dodanie impulsu si³y w górê, aby uzyskaæ efekt odbicia
            rb.AddForce(Vector2.up * bounceForce, ForceMode2D.Impulse);
        }
    }
}
