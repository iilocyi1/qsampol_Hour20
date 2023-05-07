using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    public float speed = .5f;

    Renderer rendererme;
    float offset;

    void Start ()
    {
        rendererme = GetComponent<Renderer>();
    }

    void Update()
    {
        offset += Time.deltaTime * speed;
        if (offset > 1)
            offset -= 1;
        rendererme.material.mainTextureOffset = new Vector2(0, offset);
    }
}
