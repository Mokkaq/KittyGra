using UnityEngine;
using TMPro; // Obs³uga TextMeshPro
using UnityEngine.SceneManagement; // Obs³uga resetowania sceny

public class PunktyManL : MonoBehaviour
{
    public static PunktyManL Instance; // Singleton do ³atwego odwo³ywania siê do tego skryptu

    public int aktualnePunkty = 0; // Aktualny wynik
    public TextMeshProUGUI punktyText; // Obiekt TextMeshPro do wyœwietlania wyniku

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            // NIE u¿ywamy DontDestroyOnLoad, aby punkty resetowa³y siê po restarcie gry
        }
        else
        {
            Destroy(gameObject); // Usuñ dodatkowe instancje
        }
    }

    private void Start()
    {
        ResetujPunkty(); // Ustaw punkty na 0 przy starcie gry
    }

    public void DodajPunkty(int ilePunktow)
    {
        aktualnePunkty += ilePunktow; // Dodaj punkty
        AktualizujTekst(); // Zaktualizuj wyœwietlany tekst
    }

    public void ResetujPunkty()
    {
        aktualnePunkty = 0; // Ustaw punkty na 0
        AktualizujTekst(); // Zaktualizuj wyœwietlany tekst
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Prze³aduj aktualn¹ scenê
    }
}
