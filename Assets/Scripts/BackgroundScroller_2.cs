using UnityEngine;

public class BakgroundScroller_2 :MonoBehaviour
{
    public Transform Player;
    void Update()
    {
        if (Player.position.y > transform.position.y)
        {
            transform.position = new Vector2(transform.position.x, Player.position.y);
        }
    }

}