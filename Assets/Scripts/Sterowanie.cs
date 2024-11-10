using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;       // Szybko�� poruszania si� w poziomie
    public float jumpForce = 10f;       // Si�a skoku/odbicia
    private Rigidbody2D rb;
    private bool isGrounded = false;    // Flaga okre�laj�ca, czy posta� jest na ziemi

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Ruch poziomy za pomoc� akcelerometru lub klawiszy
        float move = Input.acceleration.x; // lub np. Input.GetAxis("Horizontal") dla sterowania na klawiaturze

        // Ustawiamy si�� ruchu w poziomie
        rb.AddForce(new Vector2(move * moveSpeed * Time.deltaTime, 0), ForceMode2D.Force);

        // Skok, je�li gracz jest na ziemi
        if (isGrounded && (Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0))
        {
            Jump();
        }
    }

    private void Jump()
    {
        // Dodajemy si�� w osi Y, aby wykona� skok/odbicie
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        isGrounded = false; // Ustawiamy na false, aby unikn�� wielokrotnych skok�w
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Sprawdzamy, czy dotkn�li�my obiektu z tagiem "Ground" lub "Platform"
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = true; // Ustawiamy isGrounded na true, aby mo�na by�o ponownie skoczy�
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Gdy posta� przestaje dotyka� gruntu/platformy, ustawiamy isGrounded na false
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = false;
        }
    }
}