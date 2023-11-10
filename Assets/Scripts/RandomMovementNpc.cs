using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovementNpc : MonoBehaviour
{
    public float moveSpeed = 2f;
    private float timer = 0f;
    private Vector2 randomDirection;
    private float minChangeDirectionTime = 5f;
    private float maxChangeDirectionTime = 10f;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent < SpriteRenderer>();
        GetRandomDirection();
    }

    public void Update()
    {
        timer += Time.deltaTime;

        // If the timer exceeds the time to change direction, get a new random direction
        if (timer >= Random.Range(minChangeDirectionTime, maxChangeDirectionTime))
        {
            GetRandomDirection();
            timer = 0f;
        }

        // Move the NPC in the random direction
        rb.velocity = randomDirection.normalized * moveSpeed;

        // Flip the sprite when moving left
        if (randomDirection.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }

    public void GetRandomDirection()
    {
        // Generate a random direction vector
        float randomAngle = Random.Range(0f, 360f);
        randomDirection = new Vector2(Mathf.Cos(randomAngle * Mathf.Deg2Rad), Mathf.Sin(randomAngle * Mathf.Deg2Rad));
    }
}
