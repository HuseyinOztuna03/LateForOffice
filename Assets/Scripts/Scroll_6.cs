using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll_6 : MonoBehaviour
{
    public BoxCollider2D colliderS;
    public Rigidbody2D rb;
    private float width;
    private float scrollSpeed= -0.060f;
    void Start()
    {
        colliderS= GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        width = colliderS.size.x;
        colliderS.enabled = false;

        rb.velocity = new Vector2(scrollSpeed, 0);
    }
    void Update()
    {
        if (transform.position.x < -8.615)
        {
            Vector2 resetPosition= new Vector2(width * 0.9f, 0);
            transform.position = (Vector2)transform.position + resetPosition;
        }
    }
}
