using UnityEngine;
using UnityEngine.SceneManagement;

public class menuDoSkok : MonoBehaviour
{
    public void doSkoku()
    {
        SceneManager.LoadSceneAsync(2);
    }

}