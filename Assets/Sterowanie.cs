using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Prêdkoœæ poziomego ruchu bazuj¹ca na akcelerometrze
    public float jumpForce = 5.0f; // Si³a skoku (wysokoœæ)
    public float screenLimitX = 2.5f; // Ograniczenie pozycji w osi X (poziomo)
    private bool isGrounded; // Sprawdzenie, czy gracz jest na ziemi lub platformie

    void Update()
    {
        // Poziomy ruch wykorzystuj¹cy wejœcie z akcelerometru
        float moveInput = Input.acceleration.x;
        Vector3 horizontalMovement = new Vector3(moveInput * this.moveSpeed * Time.deltaTime, 0, 0);
        transform.Translate(horizontalMovement);

        // Ograniczenie pozycji gracza do granic ekranu
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -this.screenLimitX, this.screenLimitX);
        transform.position = clampedPosition;

        // Sprawdzenie, czy gracz jest na ziemi i mo¿e skoczyæ
        if (isGrounded)
        {
            Jump();
        }
    }

    private void Jump()
    {
        // Dodanie ruchu w górê, aby zasymulowaæ skok
        Vector3 jumpMovement = new Vector3(0, this.jumpForce * Time.deltaTime, 0);
        transform.Translate(jumpMovement);
        isGrounded = false; // Ustawienie isGrounded na false po skoku
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Sprawdzenie, czy gracz koliduje z ziemi¹
        if (collision.gameObject.CompareTag("deska"))
        {
            isGrounded = true; // Pozwól graczowi ponownie skakaæ
        }
    }
}
