using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraBoundaryReset : MonoBehaviour
{
    public Transform player; // Referencja do gracza lub obiektu do œledzenia

    void Update()
    {
        // Pobierz widoczny obszar kamery w wspó³rzêdnych œwiata
        Vector3 screenBottomLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));
        Vector3 screenTopRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, Camera.main.nearClipPlane));

        // SprawdŸ, czy gracz znajduje siê poza widocznym obszarem kamery
        if (player.position.x < screenBottomLeft.x || player.position.x > screenTopRight.x ||
            player.position.y < screenBottomLeft.y || player.position.y > screenTopRight.y)
        {
            // Zresetuj scenê, jeœli gracz jest poza kamer¹
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
