using UnityEngine;

public class platformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;    // Prefab platformy
    public Transform player;             // Transform gracza do �ledzenia jego pozycji
    public float spawnHeight = 4f;       // Odleg�o�� w pionie, na jakiej pojawi� si� nowe platformy
    public float platformSpacing = 3f;   // Odleg�o�� mi�dzy kolejnymi platformami w osi Y
    public float xSpawnRange = 2.5f;     // Zakres losowego rozmieszczenia platform w osi X

    private float highestYPosition;      // Wysoko�� ostatniej wygenerowanej platformy

    void Start()
    {
        // Ustaw pocz�tkow� wysoko�� na poziomie gracza
        highestYPosition = player.position.y;

        // Generuj pocz�tkowe platformy
        GenerateInitialPlatforms();
    }

    void Update()
    {
        // Generuj now� platform�, je�li gracz zbli�y si� do najwy�ej po�o�onej platformy
        if (player.position.y > highestYPosition - spawnHeight)
        {
            SpawnPlatform(); // Tworzy now� platform�
        }
    }

    void GenerateInitialPlatforms()
    {
        // Generuj kilka pocz�tkowych platform w r�wnych odst�pach
        for (int i = 0; i < 5; i++)
        {
            Vector2 spawnPosition = new Vector2(Random.Range(-xSpawnRange, xSpawnRange), highestYPosition + (i * platformSpacing));
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }

        // Aktualizuj najwy�sz� pozycj� na podstawie ostatniej wygenerowanej platformy
        highestYPosition += 5 * platformSpacing;
    }

    void SpawnPlatform()
    {
        // Generuj now� platform� na kolejnej wysoko�ci z losowym przesuni�ciem w osi X
        Vector2 spawnPosition = new Vector2(Random.Range(-xSpawnRange, xSpawnRange), highestYPosition);
        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);

        // Aktualizuj najwy�sz� pozycj� platformy
        highestYPosition += platformSpacing;
    }
}

