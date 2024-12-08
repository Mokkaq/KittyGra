using UnityEngine;
using TMPro; // Obs�uga TextMeshPro
using UnityEngine.SceneManagement; // Obs�uga resetowania sceny

public class PunktyManL : MonoBehaviour
{
    public static PunktyManL Instance; // Singleton do �atwego odwo�ywania si� do tego skryptu

    public int aktualnePunkty = 0; // Aktualny wynik
    public TextMeshProUGUI punktyText; // Obiekt TextMeshPro do wy�wietlania wyniku

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            // NIE u�ywamy DontDestroyOnLoad, aby punkty resetowa�y si� po restarcie gry
        }
        else
        {
            Destroy(gameObject); // Usu� dodatkowe instancje
        }
    }

    private void Start()
    {
        ResetujPunkty(); // Ustaw punkty na 0 przy starcie gry
    }

    public void DodajPunkty(int ilePunktow)
    {
        aktualnePunkty += ilePunktow; // Dodaj punkty
        AktualizujTekst(); // Zaktualizuj wy�wietlany tekst
    }

    public void ResetujPunkty()
    {
        aktualnePunkty = 0; // Ustaw punkty na 0
        AktualizujTekst(); // Zaktualizuj wy�wietlany tekst
    }

    private void AktualizujTekst()
    {
        if (punktyText != null)
        {
            punktyText.text = "Punkty: " + aktualnePunkty; // Zaktualizuj tekst w TextMeshPro
        }
    }

    public void ResetujGre()
    {
        ResetujPunkty(); // Zresetuj punkty
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Prze�aduj aktualn� scen�
    }
}
