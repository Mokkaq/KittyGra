using UnityEngine;

public class PlatformScoreTrigger : MonoBehaviour
{
    private bool hasScored = false; // Zmienna, kt�ra sprawdza, czy punkt zosta� ju� naliczony

    public ScoreManager scoreManager; // Referencja do ScoreManager

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Sprawdzamy, czy kolizja jest z graczem
        if (collision.gameObject.CompareTag("Player") && !hasScored)
        {
            hasScored = true; // Punkt zosta� naliczony
            scoreManager.AddPoint(); // Dodaj punkt do wyniku
        }
    }
}
