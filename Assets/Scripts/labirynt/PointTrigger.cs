using UnityEngine;

public class PointTrigger : MonoBehaviour
{
    private ScoreManager scoreManager;

    void Start()
    {
        // Znajd� ScoreManager w scenie za pomoc� nowej metody
        scoreManager = Object.FindFirstObjectByType<ScoreManager>();
        if (scoreManager == null)
        {
            Debug.LogError("ScoreManager nie zosta� znaleziony w scenie!");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Sprawd�, czy obiekt, kt�ry przeszed� przez lini�, ma tag "Platform"
        if (other.gameObject.CompareTag("Platform"))
        {
            if (scoreManager != null)
            {
                scoreManager.AddPoint();
            }
        }
    }
}
