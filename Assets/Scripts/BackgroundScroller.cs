using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed = 0.5f; // Prêdkoœæ przewijania t³a
    private Renderer rend; // Referencja do komponentu Renderer, który obs³uguje materia³

    void Start()
    {
        // Pobierz komponent Renderer z obiektu t³a
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        // Oblicz przesuniêcie tekstury na podstawie czasu
        float offset = Time.time * scrollSpeed;

        // Przesuñ teksturê w osi Y
        rend.material.mainTextureOffset = new Vector2(0, -offset);
    }
}
