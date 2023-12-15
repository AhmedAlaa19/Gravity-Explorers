using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    CharacterController characterController;


    public float moveSpeed = 5f;                // Speed of horizontal movement
    public float gravity = -9.81f;              // Earth's gravity force
    public float jumpSpeedMultiplier = 1f;      // Multiplier for jump speed
    public float jumpHeight = 4f;               // Height of the jump
    float verticalVelocity;                     // Vertical velocity for jumping and falling

    void Start()
    {
        characterController = GetComponent<CharacterController>(); // Reference to the CharacterController component       
    }

    void Update()
    {
      
        float horizontalInput = Input.GetAxis("Horizontal"); // Get horizontal input (-1 to 1)
        Vector3 moveDirection = new Vector3(horizontalInput * moveSpeed, 0f, 0f); // Create movement vector
       
        if (characterController.isGrounded) // Check if the character is on the ground
        {
            if (Input.GetKeyDown(KeyCode.Space)) // Check if Space key is pressed
            {
                // Calculate jump velocity using the jumpHeight, gravity, and jumpSpeedMultiplier
                verticalVelocity = Mathf.Sqrt(jumpHeight * -2f * gravity * jumpSpeedMultiplier);


            }
        }
        else
        {
            // Apply gravity over time when the character is not grounded
            verticalVelocity += gravity * jumpSpeedMultiplier * Time.deltaTime;
        }

        moveDirection.y = verticalVelocity; // Assign the vertical velocity to the y component of moveDirection
        characterController.Move(moveDirection * Time.deltaTime); // Move the character using the CharacterController
    }
}
