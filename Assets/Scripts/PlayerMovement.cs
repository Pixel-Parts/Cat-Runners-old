using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float jumpForce = 5f;
    public float forwardForce = 0f;
    private Rigidbody2D myRB;
    private bool canJump;

    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    // Jump Funktion
    public void Jump()
    {
        // Can the Player Jump?
        if (canJump)
        {
            canJump = false;

            // Is Player in middle?
            if (transform.position.x < 0)
            {
                // Player is not in middle
                forwardForce = 1f;
            }
            else
            {
                // Player in in middle
                forwardForce = 0f;
            }
            myRB.velocity = new Vector2(forwardForce, jumpForce);
        }
    }
void OnCollisionEnter2D(Collision2D other)
    {
        canJump = true;
    }
}