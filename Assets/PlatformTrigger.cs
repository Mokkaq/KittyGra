using UnityEngine;

public class PlatformScoreTrigger : MonoBehaviour
{
    private bool hasScored = false; // Zmienna, która sprawdza, czy punkt zosta³ ju¿ naliczony

    public ScoreManager scoreManager; // Referencja do ScoreManager

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Sprawdzamy, czy kolizja jest z graczem
        if (collision.gameObject.CompareTag("Player") && !hasScored)
        {
            hasScored = true; // Punkt zosta³ naliczony
            scoreManager.AddPoint(); // Dodaj punkt do wyniku
        }
    }
}
