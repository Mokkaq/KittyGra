using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void ResetGame()
    {
        // Upewnij siê, ¿e czas gry jest aktywny
        Time.timeScale = 1;

        // Ponowne za³adowanie bie¿¹cej sceny
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
