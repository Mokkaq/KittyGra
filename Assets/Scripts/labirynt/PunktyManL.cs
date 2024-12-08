using UnityEngine;
using TMPro;

public class PunktyManL : MonoBehaviour
{
    public static PunktyManL Instance; // Singleton

    public int aktualnePunkty = 0; // Aktualny wynik

    public TextMeshProUGUI punktyText; // Odwo�anie do TextMeshPro dla wy�wietlania punkt�w

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Nie niszcz obiektu podczas zmiany sceny
        }
        else
        {
            Destroy(gameObject); // Usu� dodatkowe instancje
        }
    }

    private void Start()
    {
        // Aktualizacja tekstu na start
        if (punktyText != null)
        {
            punktyText.text = "Punkty: " + aktualnePunkty;
        }
    }

    // Metoda do zwi�kszania wyniku
    public void DodajPunkty(int ilePunktow)
    {
        aktualnePunkty += ilePunktow;

        // Aktualizacja wy�wietlanego wyniku
        if (punktyText != null)
        {
            punktyText.text = "Punkty: " + aktualnePunkty;
        }

        Debug.Log("Aktualny wynik: " + aktualnePunkty); // Informacja o wyniku w konsoli
    }
}
