using UnityEngine;

public class BalloonMovement : MonoBehaviour
{
    public float upwardSpeed = 3f; // Speed at which the balloons move upward
    private bool shouldMoveUpward = false; // Flag to indicate whether the balloons should move upward

    private Rigidbody2D rb;

    void Start()
    {
        // Get the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();

        // Disable gravity for the Rigidbody2D component
        rb.gravityScale = 0f;
    }

    void Update()
    {
        // Move the balloon upward only if the flag is set
        if (shouldMoveUpward)
        {
            transform.Translate(Vector3.up * upwardSpeed * Time.deltaTime);
        }
    }

    // Method to start moving the balloons upward
    public void StartMovingUpward()
    {
        shouldMoveUpward = true;
    }
}
