using UnityEngine;

public class PersistentManager : MonoBehaviour
{
    void Awake()
    {
        // Upewnij si�, �e obiekt nie zostanie zniszczony przy zmianie sceny
        DontDestroyOnLoad(gameObject);
    }
}

