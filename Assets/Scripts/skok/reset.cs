using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void ResetGame()
    {
        // Upewnij si�, �e czas gry jest aktywny
        Time.timeScale = 1;

        // Ponowne za�adowanie bie��cej sceny
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
