using UnityEngine;
using System.Collections.Generic;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;       // Prefabrykat platformy
    public int numberOfPlatforms = 5;       // Liczba platform do wygenerowania
    public float minX = -2.5f;              // Minimalna pozycja X platformy
    public float maxX = 2.5f;               // Maksymalna pozycja X platformy
    public float spawnY = -6.0f;            // Pozycja Y pocz�tkowego generowania platform
    public float platformSpeed = 2.0f;      // Pr�dko�� przesuwania platform do g�ry
    public float verticalSpacing = 3.0f;    // Odst�p mi�dzy platformami w pionie
    public float speedIncreaseInterval = 5.0f; // Czas (w sekundach) co ile zwi�ksza si� pr�dko��
    public float speedIncreaseFactor = 1.1f;  // Wsp�czynnik zwi�kszenia pr�dko�ci (10%)

    private List<GameObject> platforms = new List<GameObject>();
    private float timeSinceLastIncrease = 0.0f;

    void Start()
    {
        GenerateInitialPlatforms();
    }

    void Update()
    {
        MovePlatformsUp();
        RemovePlatformsAboveScreen();

        // Liczenie czasu i zwi�kszanie pr�dko�ci
        timeSinceLastIncrease += Time.deltaTime;
        if (timeSinceLastIncrease >= speedIncreaseInterval)
        {
            IncreasePlatformSpeed();
            timeSinceLastIncrease = 0.0f; // Reset czasu od ostatniego zwi�kszenia pr�dko�ci
        }
    }

    void GenerateInitialPlatforms()
    {
        // Tworzenie okre�lonej liczby platform od do�u
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            float randomX = Random.Range(minX, maxX);
            Vector2 spawnPosition = new Vector2(randomX, spawnY + i * verticalSpacing); // U�ycie wi�kszego odst�pu
            GameObject newPlatform = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            platforms.Add(newPlatform);
        }
    }

    void MovePlatformsUp()
    {
        // Przesuwanie ka�dej platformy w g�r�
        foreach (GameObject platform in platforms)
        {
            platform.transform.Translate(Vector2.up * platformSpeed * Time.deltaTime);
        }
    }

    void RemovePlatformsAboveScreen()
    {
        // Usuwanie platform, kt�re wychodz� poza ekran
        for (int i = platforms.Count - 1; i >= 0; i--)
        {
            if (platforms[i].transform.position.y > 6.0f) // Granica g�rna ekranu
            {
                Destroy(platforms[i]);
                platforms.RemoveAt(i);
            }
        }

        // Dodawanie nowych platform na dole, gdy inne znikaj�
        while (platforms.Count < numberOfPlatforms)
        {
            float randomX = Random.Range(minX, maxX);
            Vector2 spawnPosition = new Vector2(randomX, spawnY);
            GameObject newPlatform = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            platforms.Add(newPlatform);
        }
    }

    void IncreasePlatformSpeed()
    {
        // Zwi�ksz pr�dko�� platform o 10%
        platformSpeed *= speedIncreaseFactor;
    }
}
