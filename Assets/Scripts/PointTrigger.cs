using UnityEngine;

public class PointTrigger : MonoBehaviour
{
    private ScoreManager scoreManager;

    void Start()
    {
        // ZnajdŸ ScoreManager w scenie
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // SprawdŸ, czy obiekt, który przeszed³ przez liniê, ma tag „Platform”
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
