using UnityEngine;
using UnityEngine.SceneManagement; // Dodaj, aby obs�ugiwa� resetowanie sceny

public class PlayerBounce : MonoBehaviour
{
    public float bounceForce = 10f; // Si�a odbicia
    public float fallLimit = -10f;  // Wysoko��, przy kt�rej gra si� resetuje

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Sprawdzenie, czy obiekt spad� poza ekran
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
            // Dodanie impulsu si�y w g�r�, aby uzyska� efekt odbicia
            rb.AddForce(Vector2.up * bounceForce, ForceMode2D.Impulse);
        }
    }
}
