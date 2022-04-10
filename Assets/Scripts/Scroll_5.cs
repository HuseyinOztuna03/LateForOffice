using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll_5 : MonoBehaviour
{
    public BoxCollider2D colliderS;
    public Rigidbody2D rb;
    private float width;
    private float scrollSpeed= -0.140f;
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
        if (transform.position.x < -5.65)
        {
            Vector2 resetPosition= new Vector2(width * 0.56f, 0);
            transform.position = (Vector2)transform.position + resetPosition;
        }
    }
}
