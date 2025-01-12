/**
 * @file statyManager.cs
 * @brief Skrypt zarządzający poziomami potrzeb gracza w grze.
 *
 * @details
 * Obsługuje aktualizację suwaków reprezentujących poziom głodu, snu i picia oraz
 * umożliwia ich uzupełnianie za pomocą przycisków.
 *
 * @dependencies
 * UnityEngine.UI, UnityEngine
 *
 * @note Wymaga przypisania suwaków, przycisków i dźwięków w inspektorze Unity.
 *
 * @warning Brak przypisanych komponentów może prowadzić do błędów.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;
using UnityEngine.UI;

/**
 * @class PotrzebyManager
 * @brief Klasa zarządzająca potrzebami gracza w grze.
 */
public class PotrzebyManager : MonoBehaviour
{
    public Slider pasekGlodu;
    public Slider pasekSnu;
    public Slider pasekPicia;
    public Button karmPrzycisk;
    public Button senPrzycisk;
    public Button piciePrzycisk;
    public AudioClip dzwiekKarmienia;
    public AudioClip dzwiekSpania;
    public AudioClip dzwiekPicia;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        karmPrzycisk.onClick.AddListener(() => {
            ZachowaniePaskow.Instance.OdnówGlod(5f);
            PlaySound(dzwiekKarmienia);
        });

        senPrzycisk.onClick.AddListener(() => {
            ZachowaniePaskow.Instance.OdnówSen(5f);
            PlaySound(dzwiekSpania);
        });

        piciePrzycisk.onClick.AddListener(() => {
            ZachowaniePaskow.Instance.OdnówPicie(5f);
            PlaySound(dzwiekPicia);
        });
    }

    void PlaySound(AudioClip clip)
    {
        if (audioSource != null && clip != null)
        {
            audioSource.PlayOneShot(clip);
        }
        else
        {
            Debug.LogWarning("Brak przypisanego AudioSource lub AudioClip!");
        }
    }
}
