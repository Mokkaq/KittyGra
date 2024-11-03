using UnityEngine;

public class PointTrigger : MonoBehaviour
{
    private ScoreManager scoreManager;

    void Start()
    {
        // Znajd� ScoreManager w scenie
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Sprawd�, czy obiekt, kt�ry przeszed� przez lini�, ma tag �Platform�
        if (other.gameObject.CompareTag("Platform"))
        {
            // Dodaj punkt do wyniku
            if (scoreManager != null)
            {
                scoreManager.AddPoint();
            }
        }
    }
}
