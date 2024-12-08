using UnityEngine;

public class PointTrigger : MonoBehaviour
{
    public int punktyZaPrzejscie = 1; // Liczba punkt�w za przej�cie platformy

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Sprawd�, czy obiekt, kt�ry wchodzi w pole, to platforma
        if (collision.CompareTag("Platform"))
        {
            // Dodaj punkty do wyniku
            PunktyManL.Instance.DodajPunkty(punktyZaPrzejscie);
        }
    }
}
