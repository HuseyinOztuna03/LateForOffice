using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScroll : MonoBehaviour
{
    public BoxCollider2D colliderS;
    public Rigidbody2D rb;
    private float width;
    private float scrollSpeed= -4.2f;
    void Start()
    {
        colliderS= GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        width = colliderS.size.x;
        colliderS.enabled = true;

        rb.velocity = new Vector2(scrollSpeed, 0);
    }
    void Update()
    {
        if (transform.position.x < -5.75)
        {
           Destroy(gameObject);
        }
    }
}
