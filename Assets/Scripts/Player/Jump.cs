using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            moveDirection.y = jumpSpeed;
        }

        //if (controller.isGrounded)
        //{
        //    // Jump if the player is on the ground and the jump button is pressed

        //}

        // Apply gravity to the movement vector
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the player
        controller.Move(moveDirection * Time.deltaTime);
    }
}
