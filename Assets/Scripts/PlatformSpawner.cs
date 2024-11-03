using UnityEngine;
using System.Collections.Generic;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;       // Prefabrykat platformy
    public int numberOfPlatforms = 5;      // Liczba platform do wygenerowania
    public float minX = -2.5f;              // Minimalna pozycja X platformy
    public float maxX = 2.5f;               // Maksymalna pozycja X platformy
    public float spawnY = -6.0f;            // Pozycja Y pocz¹tkowego generowania platform
    public float platformSpeed = 2.0f;      // Prêdkoœæ przesuwania platform do góry
    public float verticalSpacing = 3.0f;    // Odstêp miêdzy platformami w pionie

    private List<GameObject> platforms = new List<GameObject>();

    void Start()
    {
        GenerateInitialPlatforms();
    }

    void Update()
    {
        MovePlatformsUp();
        RemovePlatformsAboveScreen();
    }

    void GenerateInitialPlatforms()
    {
        // Tworzenie okreœlonej liczby platform od do³u
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            float randomX = Random.Range(minX, maxX);
            Vector2 spawnPosition = new Vector2(randomX, spawnY + i * verticalSpacing); // U¿ycie wiêkszego odstêpu
            GameObject newPlatform = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            platforms.Add(newPlatform);
        }
    }

    void MovePlatformsUp()
    {
        // Przesuwanie ka¿dej platformy w górê
        foreach (GameObject platform in platforms)
        {
            platform.transform.Translate(Vector2.up * platformSpeed * Time.deltaTime);
        }
    }

    void RemovePlatformsAboveScreen()
    {
        // Usuwanie platform, które wychodz¹ poza ekran
        for (int i = platforms.Count - 1; i >= 0; i--)
        {
            if (platforms[i].transform.position.y > 6.0f) // Granica górna ekranu
            {
                Destroy(platforms[i]);
                platforms.RemoveAt(i);
            }
        }

        // Dodawanie nowych platform na dole, gdy inne znikaj¹
        while (platforms.Count < numberOfPlatforms)
        {
            float randomX = Random.Range(minX, maxX);
            Vector2 spawnPosition = new Vector2(randomX, spawnY);
            GameObject newPlatform = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            platforms.Add(newPlatform);
        }
    }
}