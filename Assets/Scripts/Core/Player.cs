using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    Vector2 velocity;

    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;

    // Variables
    public bool isFlip = false;

    void Start()
    {
        velocity.x = speed;
        rb.velocity = velocity;
    }

    void OnTriggerEnter2D()
    {
        velocity.x *= -1;
        rb.velocity = velocity;
        isFlip = !isFlip;
        spriteRenderer.flipX = isFlip;
    }
}
