using UnityEngine;

public class PointTrigger : MonoBehaviour
{
    private ScoreManager scoreManager;

    void Start()
    {
        // ZnajdŸ ScoreManager w scenie za pomoc¹ nowej metody
        scoreManager = Object.FindFirstObjectByType<ScoreManager>();
        if (scoreManager == null)
        {
            Debug.LogError("ScoreManager nie zosta³ znaleziony w scenie!");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // SprawdŸ, czy obiekt, który przeszed³ przez liniê, ma tag "Platform"
        if (other.gameObject.CompareTag("Platform"))
        {
            if (scoreManager != null)
            {
                scoreManager.AddPoint();
            }
        }
    }
}
