/**
 * @file PunktyManL.cs
 * @brief Skrypt zarządzający punktacją w grze.
 *
 * @details
 * Obsługuje aktualizację i wyświetlanie wyniku na ekranie, a także resetowanie
 * punktów i restart gry. Implementuje wzorzec singleton do łatwego odwoływania się.
 *
 * @note Do prawidłowego działania wymaga obiektu TextMeshPro przypisanego w edytorze Unity.
 *
 * @dependencies
 * - TextMeshPro (Unity TextMeshPro package)
 * - UnityEngine.SceneManagement (do restartowania gry).
 *
 * @warning Skrypt nie jest odporny na brak przypisania TextMeshPro w inspektorze.
 *
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;
using TMPro; // Obsługa TextMeshPro
using UnityEngine.SceneManagement; // Obsługa resetowania sceny

/**
 * @class PunktyManL
 * @brief Klasa zarządzająca punktacją w grze.
 *
 * @details
 * Przechowuje i zarządza liczbą punktów zdobytych przez gracza,
 * aktualizuje tekst na ekranie i umożliwia resetowanie wyniku.
 */
public class PunktyManL : MonoBehaviour
{
    /// @brief Singleton do łatwego dostępu do instancji klasy.
    public static PunktyManL Instance;

    /// @brief Aktualny wynik gracza.
    public int aktualnePunkty = 0;

    /// @brief Komponent TextMeshPro wyświetlający wynik.
    public TextMeshProUGUI punktyText;

    /**
     * @brief Inicjalizuje singleton i ustawia początkowy stan gry.
     */
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject); // Usuń nadmiarowe instancje.
        }
    }

    /**
     * @brief Resetuje punkty do zera po uruchomieniu gry.
     */
    private void Start()
    {
        ResetujPunkty();
    }

    /**
     * @brief Dodaje punkty do aktualnego wyniku.
     * @param ilePunktow Liczba punktów do dodania.
     */
    public void DodajPunkty(int ilePunktow)
    {
        aktualnePunkty += ilePunktow;
        AktualizujTekst();
    }

    /**
     * @brief Resetuje aktualną liczbę punktów do zera.
     */
    public void ResetujPunkty()
    {
        aktualnePunkty = 0;
        AktualizujTekst();
    }

    /**
     * @brief Aktualizuje tekst wyświetlany na ekranie.
     *
     * @details
     * Jeśli komponent TextMeshPro został przypisany, aktualizuje jego tekst
     * do bieżącej liczby punktów.
     */
    private void AktualizujTekst()
    {
        if (punktyText != null)
        {
            punktyText.text = "Punkty: " + aktualnePunkty;
        }
    }

    /**
     * @brief Resetuje grę i przywraca liczbę punktów do zera.
     */
    public void ResetujGre()
    {
        ResetujPunkty();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
