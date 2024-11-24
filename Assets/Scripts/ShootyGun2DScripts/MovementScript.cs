using System;
using UnityEngine;
using UnityEngine.UIElements;

public class MovementScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isGrounded;
    [SerializeField] private String groundTag = "Ground";
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void SetHorizontalVelocity(float velocity)
    {
        Vector2 newVelocity = rb.velocity;
        newVelocity.x = velocity;
        rb.velocity = newVelocity;
    }

    public void Jump(float force)
    {
        if (isGrounded)
        {
            rb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag(groundTag))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag(groundTag))
        {
            isGrounded = false;
        }
    }

    public bool IsGrounded()
    {
        return isGrounded;
    }
}