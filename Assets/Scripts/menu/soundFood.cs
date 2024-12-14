using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // Pobierz komponent AudioSource
        audioSource = GetComponent<AudioSource>();
    }

    // Funkcja do odtwarzania dŸwiêku
    public void PlaySound()
    {
        audioSource.Play();
    }
}
