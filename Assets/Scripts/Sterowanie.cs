using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;       // Szybkoœæ poruszania siê w poziomie
    public float jumpForce = 10f;       // Si³a skoku/odbicia
    private Rigidbody2D rb;
    private bool isGrounded = false;    // Flaga okreœlaj¹ca, czy postaæ jest na ziemi

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Ruch poziomy za pomoc¹ akcelerometru lub klawiszy
        float move = Input.acceleration.x; // lub np. Input.GetAxis("Horizontal") dla sterowania na klawiaturze

        // Ustawiamy si³ê ruchu w poziomie
        rb.AddForce(new Vector2(move * moveSpeed * Time.deltaTime, 0), ForceMode2D.Force);

        // Skok, jeœli gracz jest na ziemi
        if (isGrounded && (Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0))
        {
            Jump();
        }
    }

    private void Jump()
    {
        // Dodajemy si³ê w osi Y, aby wykonaæ skok/odbicie
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        isGrounded = false; // Ustawiamy na false, aby unikn¹æ wielokrotnych skoków
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Sprawdzamy, czy dotknêliœmy obiektu z tagiem "Ground" lub "Platform"
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = true; // Ustawiamy isGrounded na true, aby mo¿na by³o ponownie skoczyæ
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Gdy postaæ przestaje dotykaæ gruntu/platformy, ustawiamy isGrounded na false
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = false;
        }
    }
}