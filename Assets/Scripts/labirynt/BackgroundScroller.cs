using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed = 0.5f; // Pr�dko�� przewijania t�a
    private Renderer rend; // Referencja do komponentu Renderer, kt�ry obs�uguje materia�

    void Start()
    {
        // Pobierz komponent Renderer z obiektu t�a
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        // Oblicz przesuni�cie tekstury na podstawie czasu
        float offset = Time.time * scrollSpeed;

        // Przesu� tekstur� w osi Y
        rend.material.mainTextureOffset = new Vector2(0, -offset);
    }
}
