using UnityEngine;

public class PersistentManager : MonoBehaviour
{
    void Awake()
    {
        // Upewnij siê, ¿e obiekt nie zostanie zniszczony przy zmianie sceny
        DontDestroyOnLoad(gameObject);
    }
}

