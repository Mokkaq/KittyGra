using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Pr�dko�� przesuwania w lewo i prawo

    void Update()
    {
        // Pobierz dane z akcelerometru
        float move = Input.acceleration.x;

        // Przesu� obiekt w osi X na podstawie akcelerometru i pr�dko�ci
        transform.position += new Vector3(move * speed * Time.deltaTime, 0, 0);
    }
}
