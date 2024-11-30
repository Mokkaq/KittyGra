using UnityEngine;

public class platformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;    // Prefab platformy
    public Transform player;             // Transform gracza do œledzenia jego pozycji
    public float spawnHeight = 4f;       // Odleg³oœæ w pionie, na jakiej pojawi¹ siê nowe platformy
    public float platformSpacing = 3f;   // Odleg³oœæ miêdzy kolejnymi platformami w osi Y
    public float xSpawnRange = 2.5f;     // Zakres losowego rozmieszczenia platform w osi X

    private float highestYPosition;      // Wysokoœæ ostatniej wygenerowanej platformy

    void Start()
    {
        // Ustaw pocz¹tkow¹ wysokoœæ na poziomie gracza
        highestYPosition = player.position.y;

        // Generuj pocz¹tkowe platformy
        GenerateInitialPlatforms();
    }

    void Update()
    {
        // Generuj now¹ platformê, jeœli gracz zbli¿y siê do najwy¿ej po³o¿onej platformy
        if (player.position.y > highestYPosition - spawnHeight)
        {
            SpawnPlatform(); // Tworzy now¹ platformê
        }
    }

    void GenerateInitialPlatforms()
    {
        // Generuj kilka pocz¹tkowych platform w równych odstêpach
        for (int i = 0; i < 5; i++)
        {
            Vector2 spawnPosition = new Vector2(Random.Range(-xSpawnRange, xSpawnRange), highestYPosition + (i * platformSpacing));
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }

        // Aktualizuj najwy¿sz¹ pozycjê na podstawie ostatniej wygenerowanej platformy
        highestYPosition += 5 * platformSpacing;
    }

    void SpawnPlatform()
    {
        // Generuj now¹ platformê na kolejnej wysokoœci z losowym przesuniêciem w osi X
        Vector2 spawnPosition = new Vector2(Random.Range(-xSpawnRange, xSpawnRange), highestYPosition);
        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);

        // Aktualizuj najwy¿sz¹ pozycjê platformy
        highestYPosition += platformSpacing;
    }
}

