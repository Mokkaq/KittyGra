using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    public float backgroundHeight = 10f; // Wysokość tła
    public float scrollSpeed = 2f; // Prędkość przewijania

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.up * scrollSpeed * Time.deltaTime);

        if (transform.position.y >= startPosition.y + backgroundHeight)
        {
            transform.position = startPosition;
        }
    }
}


