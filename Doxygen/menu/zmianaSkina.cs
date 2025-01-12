/**
 * @file zmianaSkina.cs
 * @brief Skrypt zmieniający wygląd obiektu w zależności od poziomu głodu.
 *
 * @details
 * Dynamicznie zmienia aktywne obiekty w scenie w zależności od poziomu głodu.
 * Jeśli poziom głodu spadnie poniżej określonego progu, zmienia widoczny obiekt.
 *
 * @dependencies
 * UnityEngine
 *
 * @note Oba obiekty muszą być przypisane w inspektorze Unity.
 *
 * @warning Nieprzypisanie obiektów może spowodować błędy.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;

/**
 * @class zmianaSkina
 * @brief Klasa zmieniająca wygląd obiektu w zależności od poziomu głodu.
 */
public class zmianaSkina : MonoBehaviour
{
    /// @brief Obiekt reprezentujący normalny wygląd.
    public GameObject kotNormalny;

    /// @brief Obiekt reprezentujący wygląd przy niskim poziomie głodu.
    public GameObject kotGlodny;

    /// @brief Próg głodu, poniżej którego zmienia się wygląd.
    public float prógGlodu = 30f;

    private void Start()
    {
        if (kotNormalny == null || kotGlodny == null)
        {
            Debug.LogError("Nie przypisano obiektów KotNormalny lub KotGlodny!");
            return;
        }

        kotNormalny.SetActive(true);
        kotGlodny.SetActive(false);
    }

    private void Update()
    {
        float poziomGlodu = ZachowaniePaskow.Instance.poziomGlodu;

        if (poziomGlodu < prógGlodu)
        {
            PokazGlodnegoKota();
        }
        else
        {
            PokazNormalnegoKota();
        }
    }

    private void PokazNormalnegoKota()
    {
        if (!kotNormalny.activeSelf)
        {
            kotNormalny.SetActive(true);
            kotGlodny.SetActive(false);
        }
    }

    private void PokazGlodnegoKota()
    {
        if (!kotGlodny.activeSelf)
        {
            kotNormalny.SetActive(false);
            kotGlodny.SetActive(true);
        }
    }
}
