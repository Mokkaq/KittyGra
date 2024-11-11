using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Referencja do gracza
    public float offset = 2f; // Odleg³oœæ kamery od gracza w osi Y

    void Update()
    {
        if (player.position.y > transform.position.y - offset)
        {
            transform.position = new Vector3(transform.position.x, player.position.y + offset, transform.position.z);
        }
    }
}
