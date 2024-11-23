using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBounce : MonoBehaviour
{
    public float bounceForce = 12f; // Si�a odbicia
    public float fallLimit = -10f;  // Wysoko��, przy kt�rej gra si� resetuje

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Pobierz komponent Rigidbody2D przypisany do gracza
    }

    void Update()
    {
        // Reset gry, je�li gracz spadnie poni�ej okre�lonego poziomu
        if (transform.position.y < fallLimit)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Sprawd�, czy gracz dotkn�� "Ground" lub "Platform"
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Platform"))
        {
            // Dodaj si�� w g�r�, aby gracz si� odbi�
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, bounceForce);
        }
    }
}
