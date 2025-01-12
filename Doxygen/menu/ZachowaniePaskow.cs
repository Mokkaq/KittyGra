/**
 * @file ZachowaniePaskow.cs
 * @brief Skrypt zarządzający wartościami głodu, snu i picia.
 *
 * @details
 * Implementuje singleton umożliwiający globalne zarządzanie poziomami głodu,
 * snu i picia w czasie rzeczywistym. Obsługuje automatyczne obniżanie wartości
 * oraz metody ich odnawiania.
 *
 * @dependencies
 * UnityEngine
 *
 * @note Wartości są automatycznie ograniczane do zakresu 0-100.
 *
 * @warning Upewnij się, że jest tylko jedna instancja klasy w grze.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;

/**
 * @class ZachowaniePaskow
 * @brief Klasa obsługująca globalne zarządzanie wskaźnikami potrzeb.
 */
public class ZachowaniePaskow : MonoBehaviour
{
    /// @brief Singleton klasy.
    public static ZachowaniePaskow Instance;

    /// @brief Poziom głodu gracza.
    public float poziomGlodu = 100f;

    /// @brief Poziom snu gracza.
    public float poziomSnu = 100f;

    /// @brief Poziom picia gracza.
    public float poziomPicia = 100f;

    /// @brief Czas w sekundach dla spadku wskaźników.
    public float czasSpadku = 5f;

    /// @brief Procent spadku głodu na jednostkę czasu.
    public float spadekGlodu = 5f;

    /// @brief Procent spadku snu na jednostkę czasu.
    public float spadekSnu = 3f;

    /// @brief Procent spadku picia na jednostkę czasu.
    public float spadekPicia = 4f;

    private const float MAX_POZIOM = 100f; ///< Maksymalna wartość wskaźników.

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        AktualizujPoziomy();
    }

    /**
     * @brief Aktualizuje poziomy wskaźników w czasie rzeczywistym.
     */
    public void AktualizujPoziomy()
    {
        poziomGlodu -= (spadekGlodu / czasSpadku) * Time.deltaTime;
        poziomSnu -= (spadekSnu / czasSpadku) * Time.deltaTime;
        poziomPicia -= (spadekPicia / czasSpadku) * Time.deltaTime;

        poziomGlodu = Mathf.Clamp(poziomGlodu, 0f, MAX_POZIOM);
        poziomSnu = Mathf.Clamp(poziomSnu, 0f, MAX_POZIOM);
        poziomPicia = Mathf.Clamp(poziomPicia, 0f, MAX_POZIOM);
    }

    /**
     * @brief Odnawia poziom głodu.
     * @param ile Ilość punktów do dodania.
     */
    public void OdnówGlod(float ile)
    {
        poziomGlodu = Mathf.Clamp(poziomGlodu + ile, 0f, MAX_POZIOM);
    }

    /**
     * @brief Odnawia poziom snu.
     * @param ile Ilość punktów do dodania.
     */
    public void OdnówSen(float ile)
    {
        poziomSnu = Mathf.Clamp(poziomSnu + ile, 0f, MAX_POZIOM);
    }

    /**
     * @brief Odnawia poziom picia.
     * @param ile Ilość punktów do dodania.
     */
    public void OdnówPicie(float ile)
    {
        poziomPicia = Mathf.Clamp(poziomPicia + ile, 0f, MAX_POZIOM);
    }
}
