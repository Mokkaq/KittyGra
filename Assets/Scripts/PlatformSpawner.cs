using UnityEngine;

public class Platformspawner : MonoBehaviour
{
    public GameObject platformPrefab;    // Prefab platformy, któr¹ chcemy generowaæ
    public Transform player;             // Transform gracza, aby œledziæ jego wysokoœæ
    public float spawnHeight = 5f;       // Odleg³oœæ w pionie, na jakiej pojawi¹ siê nowe platformy
    public float platformSpacing = 2f;   // Odleg³oœæ miêdzy kolejnymi platformami
    private float highestYPosition;      // Najwy¿sza pozycja platform, do której ju¿ stworzyliœmy platformy

    void Start()
    {
        highestYPosition = player.position.y;
        GenerateInitialPlatforms();
    }

    void Update()
    {
        // Sprawdzamy, czy gracz siê zbli¿a do najwy¿szej pozycji, i tworzymy nowe platformy
        if (player.position.y > highestYPosition - spawnHeight)
        {
            SpawnPlatformRow();
        }
    }

    void GenerateInitialPlatforms()
    {
        // Tworzymy pocz¹tkowe platformy w scenie
        for (int i = 0; i < 5; i++)
        {
            // Ustawiamy platformy na pocz¹tku na ustalonych pozycjach z losowym przesuniêciem X
            Vector2 spawnPosition = new Vector2(Random.Range(-1.5f, 1.5f), i * platformSpacing);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }

        // Ustawiamy najwy¿sz¹ pozycjê dla nowych platform
        highestYPosition = 5 * platformSpacing;
    }

    void SpawnPlatformRow()
    {
        // Generujemy now¹ liniê platform w przypadkowych pozycjach poziomych
        for (int i = 0; i < 1; i++) // Tworzymy 3 platformy na jednej wysokoœci
        {
            // Ograniczamy zakres X, aby platformy pojawia³y siê w odpowiednich miejscach na ekranie
            Vector2 spawnPosition = new Vector2(Random.Range(-1.5f, 1.5f), highestYPosition + platformSpacing);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }

        // Aktualizujemy najwy¿sz¹ pozycjê
        highestYPosition += platformSpacing;
    }
}