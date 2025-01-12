/**
 * @file PlatformSpawner.cs
 * @brief Skrypt obsługujący generowanie i przesuwanie platform w grze.
 *
 * @details
 * Tworzy platformy w losowych pozycjach w osi X, przesuwa je w osi Y oraz zarządza
 * ich ponownym generowaniem po opuszczeniu ekranu. Zwiększa prędkość platform w określonych odstępach czasu.
 *
 * @dependencies
 * UnityEngine
 *
 * @note Wymaga prefabrykatu platformy przypisanego w edytorze Unity.
 *
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;
using System.Collections.Generic;

/**
 * @class PlatformSpawner
 * @brief Klasa odpowiedzialna za zarządzanie platformami w grze.
 */
public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;
    public int numberOfPlatforms = 5;
    public float minX = -2.5f;
    public float maxX = 2.5f;
    public float spawnY = -6.0f;
    public float platformSpeed = 2.0f;
    public float verticalSpacing = 3.0f;
    public float speedIncreaseInterval = 5.0f;
    public float speedIncreaseFactor = 1.1f;

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

        timeSinceLastIncrease += Time.deltaTime;
        if (timeSinceLastIncrease >= speedIncreaseInterval)
        {
            IncreasePlatformSpeed();
            timeSinceLastIncrease = 0.0f;
        }
    }

    void GenerateInitialPlatforms()
    {
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            float randomX = Random.Range(minX, maxX);
            Vector2 spawnPosition = new Vector2(randomX, spawnY + i * verticalSpacing);
            GameObject newPlatform = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            platforms.Add(newPlatform);
        }
    }

    void MovePlatformsUp()
    {
        foreach (GameObject platform in platforms)
        {
            platform.transform.Translate(Vector2.up * platformSpeed * Time.deltaTime);
        }
    }

    void RemovePlatformsAboveScreen()
    {
        for (int i = platforms.Count - 1; i >= 0; i--)
        {
            if (platforms[i].transform.position.y > 6.0f)
            {
                Destroy(platforms[i]);
                platforms.RemoveAt(i);
            }
        }

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
        platformSpeed *= speedIncreaseFactor;
    }
}
