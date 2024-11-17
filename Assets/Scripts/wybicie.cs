using UnityEngine;
using UnityEngine.SceneManagement; // Obs³uga resetowania sceny

public class PlayerBounce : MonoBehaviour
{
    public float bounceForce = 10f; // Si³a odbicia
    public float fallLimit = -10f;  // Wysokoœæ, przy której gra siê resetuje

    private Rigidbody2D rb;

    // Referencja do mened¿era punktacji
    public ScoreManager scoreManager;

    void Start()
    {
        // Pobieramy komponent Rigidbody2D przypisany do gracza
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Sprawdzenie, czy obiekt spad³ poni¿ej okreœlonego poziomu
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
            // Dodanie si³y w górê, aby postaæ siê odbi³a
            rb.AddForce(Vector2.up * bounceForce, ForceMode2D.Impulse);

            // Jeœli kolizja jest z platform¹, zwiêksz wynik
            if (collision.gameObject.CompareTag("Platform"))
            {
                scoreManager.AddPoint();
            }
        }
    }
}
