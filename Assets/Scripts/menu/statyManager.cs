using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PotrzebyManager : MonoBehaviour
{
    public Slider pasekGlodu; // Pasek g�odu
    public Slider pasekSnu; // Pasek snu
    public Slider pasekPicia; // Pasek picia
    public Button karmPrzycisk; // Przycisk karmienia
    public Button senPrzycisk; // Przycisk snu
    public Button piciePrzycisk; // Przycisk picia

    private float poziomGlodu = 100f; // Pocz�tkowy poziom g�odu
    private float poziomSnu = 100f; // Pocz�tkowy poziom snu
    private float poziomPicia = 100f; // Pocz�tkowy poziom picia

    private float spadekGlodu = 5f; // Ile % g�odu spada co interwa�
    private float spadekSnu = 3f; // Ile % snu spada co interwa�
    private float spadekPicia = 4f; // Ile % picia spada co interwa�

    private float czasSpadku = 5f; // Co ile sekund potrzeby spadaj�

    public AudioClip dzwiekKarmienia; // D�wi�k karmienia
    public AudioClip dzwiekSpania; // D�wi�k spania
    public AudioClip dzwiekPicia; // D�wi�k picia

    private AudioSource audioSource; // Komponent AudioSource

    void Start()
    {
        // Pobierz komponent AudioSource
        audioSource = GetComponent<AudioSource>();

        // Ustaw warto�ci maksymalne slider�w
        pasekGlodu.maxValue = 100f;
        pasekSnu.maxValue = 100f;
        pasekPicia.maxValue = 100f;

        // Dodanie funkcji do przycisk�w
        karmPrzycisk.onClick.AddListener(() => {
            ZachowaniePaskow.Instance.poziomGlodu += 5f;
            PlaySound(dzwiekKarmienia); // Odtw�rz d�wi�k karmienia
        });

        senPrzycisk.onClick.AddListener(() => {
            ZachowaniePaskow.Instance.poziomSnu += 5f;
            PlaySound(dzwiekSpania); // Odtw�rz d�wi�k spania
        });

        piciePrzycisk.onClick.AddListener(() => {
            ZachowaniePaskow.Instance.poziomPicia += 5f;
            PlaySound(dzwiekPicia); // Odtw�rz d�wi�k picia
        });
    }

    void Update()
    {
        // Pobierz aktualne dane z ZachowaniePaskow i zaktualizuj suwaki
        pasekGlodu.value = ZachowaniePaskow.Instance.poziomGlodu;
        pasekSnu.value = ZachowaniePaskow.Instance.poziomSnu;
        pasekPicia.value = ZachowaniePaskow.Instance.poziomPicia;
    }

    IEnumerator ZmniejszPotrzeby()
    {
        while (true)
        {
            yield return new WaitForSeconds(czasSpadku);

            // Zmniejsz poziomy potrzeb
            OdejmijGlod(spadekGlodu);
            OdejmijSen(spadekSnu);
            OdejmijPicie(spadekPicia);
        }
    }

    void OdejmijGlod(float ile)
    {
        poziomGlodu -= ile;
        if (poziomGlodu < 0f) poziomGlodu = 0f;
        pasekGlodu.value = poziomGlodu;
    }

    void OdejmijSen(float ile)
    {
        poziomSnu -= ile;
        if (poziomSnu < 0f) poziomSnu = 0f;
        pasekSnu.value = poziomSnu;
    }

    void OdejmijPicie(float ile)
    {
        poziomPicia -= ile;
        if (poziomPicia < 0f) poziomPicia = 0f;
        pasekPicia.value = poziomPicia;
    }

    void PlaySound(AudioClip clip)
    {
        if (audioSource != null && clip != null)
        {
            audioSource.PlayOneShot(clip); // Odtw�rz jednorazowy d�wi�k
        }
        else
        {
            Debug.LogWarning("Brak przypisanego AudioSource lub AudioClip!");
        }
    }
}
