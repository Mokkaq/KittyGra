using UnityEngine;
using UnityEngine.SceneManagement; // Obs�uga resetowania sceny

public class PlayerBounce : MonoBehaviour
{
    public float bounceForce = 10f; // Si�a odbicia
    public float fallLimit = -10f;  // Wysoko��, przy kt�rej gra si� resetuje

    private Rigidbody2D rb;

    // Referencja do mened�era punktacji
    public ScoreManager scoreManager;

    void Start()
    {
        // Pobieramy komponent Rigidbody2D przypisany do gracza
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Sprawdzenie, czy obiekt spad� poni�ej okre�lonego poziomu
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
            // Dodanie si�y w g�r�, aby posta� si� odbi�a
            rb.AddForce(Vector2.up * bounceForce, ForceMode2D.Impulse);

            // Je�li kolizja jest z platform�, zwi�ksz wynik
            if (collision.gameObject.CompareTag("Platform"))
            {
                scoreManager.AddPoint();
            }
        }
    }
}
