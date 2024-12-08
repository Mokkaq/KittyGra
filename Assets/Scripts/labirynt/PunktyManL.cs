using UnityEngine;
using TMPro;

public class PunktyManL : MonoBehaviour
{
    public static PunktyManL Instance; // Singleton

    public int aktualnePunkty = 0; // Aktualny wynik

    public TextMeshProUGUI punktyText; // Odwołanie do TextMeshPro dla wyświetlania punktów

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Nie niszcz obiektu podczas zmiany sceny
        }
        else
        {
            Destroy(gameObject); // Usuń dodatkowe instancje
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

    // Metoda do zwiększania wyniku
    public void DodajPunkty(int ilePunktow)
    {
        aktualnePunkty += ilePunktow;

        // Aktualizacja wyświetlanego wyniku
        if (punktyText != null)
        {
            punktyText.text = "Punkty: " + aktualnePunkty;
        }

        Debug.Log("Aktualny wynik: " + aktualnePunkty); // Informacja o wyniku w konsoli
    }
}
