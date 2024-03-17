using UnityEngine;

public class pMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f; // Disable gravity initially
    }

    void Update()
    {
        // Get input for movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        // Apply movement using velocity
        rb.velocity = movement * moveSpeed;
    }
}
