/**
 * @file platform_2.cs
 * @brief Skrypt do generowania platform w grze.
 *
 * @details
 * Obsługuje dynamiczne generowanie platform w oparciu o pozycję gracza.
 * Nowe platformy są tworzone w określonej odległości, aby gracz zawsze miał gdzie się poruszać.
 *
 * @dependencies
 * UnityEngine
 *
 * @note Wymaga przypisania prefabrykatu platformy i transformu gracza w inspektorze.
 * 
 * @warning Brak przypisanego prefabrykatu lub gracza może prowadzić do błędów.
 * 
 * @author [Twój Autor]
 * @date [Data]
 */

using UnityEngine;

/**
 * @class Platformspawner
 * @brief Klasa generująca platformy w grze.
 */
public class Platformspawner : MonoBehaviour
{
    /// @brief Prefab platformy.
    public GameObject platformPrefab;

    /// @brief Transform gracza do śledzenia jego pozycji.
    public Transform player;

    /// @brief Odległość w pionie, na jakiej pojawiają się nowe platformy.
    public float spawnHeight = 4f;

    /// @brief Odległość między kolejnymi platformami w osi Y.
    public float platformSpacing = 3f;

    /// @brief Zakres losowego rozmieszczenia platform w osi X.
    public float xSpawnRange = 2.5f;

    private float highestYPosition;

    /**
     * @brief Inicjalizuje początkowe platformy.
     */
    void Start()
    {
        highestYPosition = player.position.y;
        GenerateInitialPlatforms();
    }

    /**
     * @brief Tworzy nowe platformy w zależności od pozycji gracza.
     */
    void Update()
    {
        if (player.position.y > highestYPosition - spawnHeight)
        {
            SpawnPlatform();
        }
    }

    /**
     * @brief Generuje początkowe platformy.
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
     * @brief Tworzy nową platformę na podstawie aktualnej pozycji.
     */
    void SpawnPlatform()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-xSpawnRange, xSpawnRange), highestYPosition);
        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        highestYPosition += platformSpacing;
    }
}
