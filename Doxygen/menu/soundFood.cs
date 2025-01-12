/**
 * @file soundFood.cs
 * @brief Skrypt obsługujący odtwarzanie dźwięku przy kliknięciu przycisku.
 *
 * @details
 * Umożliwia odtwarzanie dźwięku z komponentu AudioSource przypisanego do obiektu.
 *
 * @dependencies
 * UnityEngine
 *
 * @note Wymaga przypisania komponentu AudioSource w inspektorze Unity.
 * 
 * @warning Brak przypisania AudioSource spowoduje brak odtwarzania dźwięku.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;

/**
 * @class ButtonSound
 * @brief Klasa obsługująca odtwarzanie dźwięków przy kliknięciu.
 */
public class ButtonSound : MonoBehaviour
{
    /// @brief Komponent AudioSource odpowiedzialny za dźwięk.
    private AudioSource audioSource;

    /// @brief Inicjalizuje komponent AudioSource.
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    /**
     * @brief Odtwarza przypisany dźwięk.
     */
    public void PlaySound()
    {
        audioSource.Play();
    }
}
