using UnityEngine;
using UnityEngine.SceneManagement; 

public class CollisionReset : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.CompareTag("Platform"))
        {
            
            ResetLevel();
        }
    }

    private void ResetLevel()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
