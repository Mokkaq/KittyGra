using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Prêdkoœæ ruchu kota
    public float screenLimitX = 2.5f; // Maksymalne przesuniêcie w osi X (dostosuj do ekranu)

    void Update()
    {
        // Odczytanie wartoœci akcelerometru w osi X
        float moveInput = Input.acceleration.x;

        // Przesuniêcie kota w lewo/prawo na podstawie wartoœci z akcelerometru
        Vector3 movement = new Vector3(moveInput * moveSpeed, 0, 0);
        transform.Translate(movement * Time.deltaTime);

        // Ograniczenie ruchu kota do widocznego obszaru ekranu
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(transform.position.x, -screenLimitX, screenLimitX);
        transform.position = clampedPosition;
    }
}
