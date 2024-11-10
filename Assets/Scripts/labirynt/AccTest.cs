using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Pr�dko�� ruchu kota
    public float screenLimitX = 2.5f; // Maksymalne przesuni�cie w osi X (dostosuj do ekranu)

    void Update()
    {
        // Odczytanie warto�ci akcelerometru w osi X
        float moveInput = Input.acceleration.x;

        // Przesuni�cie kota w lewo/prawo na podstawie warto�ci z akcelerometru
        Vector3 movement = new Vector3(moveInput * moveSpeed, 0, 0);
        transform.Translate(movement * Time.deltaTime);

        // Ograniczenie ruchu kota do widocznego obszaru ekranu
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(transform.position.x, -screenLimitX, screenLimitX);
        transform.position = clampedPosition;
    }
}
