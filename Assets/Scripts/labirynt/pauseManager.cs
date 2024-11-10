using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenuPanel; // Panel menu pauzy
    public Text rankingText;          // Tekst na ranking 

    void Start()
    {
        // Ukryj menu pauzy na pocz¹tku gry
        pauseMenuPanel.SetActive(false);
    }

    public void TogglePause()
    {
        // W³¹cz menu pauzy i zatrzymaj czas gry
        pauseMenuPanel.SetActive(true);
        Time.timeScale = 0; 
        UpdateRanking();
    }



    // Funkcja do wznowienia gry
    public void ResumeGame()
    {
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1; 
    }

    // Funkcja do powrotu do menu g³ównego
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Menu"); 
    }




    //do ogarniecia

    // Funkcja do aktualizacji rankingu
    private void UpdateRanking()
    {
        // Przyk³adowe wyniki rankingu
        int[] lastScores = { 100, 95, 90, 85, 80 };

        // Wyœwietlanie wyników rankingu w polu tekstowym
        rankingText.text = "Ranking:\n";
        for (int i = 0; i < lastScores.Length; i++)
        {
            rankingText.text += (i + 1) + ". " + lastScores[i] + "\n";
        }
    }

  
}
