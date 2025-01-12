/**
 * @file Spawn.cs
 * @brief Skrypt do generowania platform w grze.
 *
 * @details
 * Dynamicznie generuje platformy w określonej odległości od gracza.
 *
 * @dependencies
 * UnityEngine
 *
 * @note Wymaga przypisania prefabrykatu platformy i transformu gracza w inspektorze Unity.
 * 
 * @warning Brak przypisanego prefabrykatu lub gracza może prowadzić do błędów.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;

/**
 * @class platformSpawner
 * @brief Klasa obsługująca generowanie platform.
 */
public class platformSpawner : MonoBehaviour
{
    /// @brief Prefab platformy.
    public GameObject platformPrefab;

    /// @brief Transform gracza.
    public Transform player;

    /// @brief Odległość w pionie, na jakiej pojawiają się nowe platformy.
    public float spawnHeight = 4f;

    /// @brief Odległość między platformami w osi Y.
    public float platformSpacing = 3f;

    /// @brief Zakres losowego rozmieszczenia platform w osi X.
    public float xSpawnRange = 2.5f;

    private float highestYPosition;

    /**
     * @brief Inicjalizuje platformy na początku gry.
     */
    void Start()
    {
        highestYPosition = player.position.y;
        GenerateInitialPlatforms();
    }

    /**
     * @brief Generuje nowe platformy w zależności od pozycji gracza.
     */
    void Update()
    {
        if (player.position.y > highestYPosition - spawnHeight)
        {
            SpawnPlatform();
        }
    }

    /**
     * @brief Tworzy początkowe platformy.
     */
    void GenerateInitialPlatforms()
    {
        for (int i = 0; i < 5; i++)
        {
            Vector2 spawnPosition = new Vector2(Random.Range(-xSpawnRange, xSpawnRange), highestYPosition + (i * platformSpacing));
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
        highestYPosition += 5 * platformSpacing;
    }

    /**
     * @brief Tworzy nową platformę.
     */
    void SpawnPlatform()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-xSpawnRange, xSpawnRange), highestYPosition);
        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        highestYPosition += platformSpacing;
    }
}
