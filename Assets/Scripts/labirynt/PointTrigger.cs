using UnityEngine;

public class PointTrigger : MonoBehaviour
{
    public int punktyZaPrzejscie = 1; // Liczba punktów za przejœcie platformy

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // SprawdŸ, czy obiekt, który wchodzi w pole, to platforma
        if (collision.CompareTag("Platform"))
        {
            // Dodaj punkty do wyniku
            PunktyManL.Instance.DodajPunkty(punktyZaPrzejscie);
        }
    }
}
