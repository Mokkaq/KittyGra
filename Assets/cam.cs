using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFallReset : MonoBehaviour
{
    private Camera mainCamera;
    private float screenBottomY;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        // Oblicz pozycjê Y dolnej krawêdzi ekranu
        screenBottomY = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, mainCamera.nearClipPlane)).y;

        // SprawdŸ, czy pozycja Y bohatera jest mniejsza ni¿ dolna granica ekranu
        if (transform.position.y < screenBottomY)
        {
            // Zresetuj scenê
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}