using UnityEngine;

public class Platformspawner : MonoBehaviour
{
    public GameObject platformPrefab;    // Prefab platformy, kt�r� chcemy generowa�
    public Transform player;             // Transform gracza, aby �ledzi� jego wysoko��
    public float spawnHeight = 5f;       // Odleg�o�� w pionie, na jakiej pojawi� si� nowe platformy
    public float platformSpacing = 2f;   // Odleg�o�� mi�dzy kolejnymi platformami
    private float highestYPosition;      // Najwy�sza pozycja platform, do kt�rej ju� stworzyli�my platformy

    void Start()
    {
        highestYPosition = player.position.y;
        GenerateInitialPlatforms();
    }

    void Update()
    {
        // Sprawdzamy, czy gracz si� zbli�a do najwy�szej pozycji, i tworzymy nowe platformy
        if (player.position.y > highestYPosition - spawnHeight)
        {
            SpawnPlatformRow();
        }
    }

    void GenerateInitialPlatforms()
    {
        // Tworzymy pocz�tkowe platformy w scenie
        for (int i = 0; i < 5; i++)
        {
            // Ustawiamy platformy na pocz�tku na ustalonych pozycjach z losowym przesuni�ciem X
            Vector2 spawnPosition = new Vector2(Random.Range(-1.5f, 1.5f), i * platformSpacing);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }

        // Ustawiamy najwy�sz� pozycj� dla nowych platform
        highestYPosition = 5 * platformSpacing;
    }

    void SpawnPlatformRow()
    {
        // Generujemy now� lini� platform w przypadkowych pozycjach poziomych
        for (int i = 0; i < 1; i++) // Tworzymy 3 platformy na jednej wysoko�ci
        {
            // Ograniczamy zakres X, aby platformy pojawia�y si� w odpowiednich miejscach na ekranie
            Vector2 spawnPosition = new Vector2(Random.Range(-1.5f, 1.5f), highestYPosition + platformSpacing);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }

        // Aktualizujemy najwy�sz� pozycj�
        highestYPosition += platformSpacing;
    }
}