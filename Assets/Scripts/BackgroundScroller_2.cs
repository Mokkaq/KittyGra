
using UnityEngine;

public class backgroundScroller : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    private Vector2 offset;
    private Material mat;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
        offset = new Vector2(0, scrollSpeed);
    }

    void Update()
    {
        mat.mainTextureOffset += offset * Time.deltaTime;
    }
}