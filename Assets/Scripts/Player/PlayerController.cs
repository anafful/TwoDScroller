
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 10.0f;
    public float jumpHeight;
    public float gravity = 20.0f;

    private CharacterController controller;
    //private Rigidbody rb;
    private Animator anim;

    private Vector3 moveDirection = Vector3.zero;

    private Vector3 playerVelocity;

    bool facingRight;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        //rb = GetComponent<Rigidbody>();
        facingRight = true;
        anim = GetComponent<Animator>();


    }

    void Update()
    {
        float horInput = Input.GetAxis("Horizontal");
        float verInput = Input.GetAxis("Vertical");

        moveDirection = new Vector3(horInput, 0, verInput);

        moveDirection *= moveSpeed;

        controller.Move(moveDirection * Time.deltaTime);


        if (moveDirection != Vector3.zero)
        {
            anim.SetBool("Move", true);


        }
        else
        {
            anim.SetBool("Move", false);

        }


        Jump();

        if (horInput < 0 && facingRight)
        {
            FlipPlayer();
        }

        else if (horInput > 0 && !facingRight)
        {
            FlipPlayer();
        }

        

        //if (controller.isGrounded && Input.GetKeyDown(KeyCode.Space))
        //{ 
        //playerVelocity.y = jumpHeight * Time.deltaTime;

        //}


    }


    public void Jump() //version1
    {
        playerVelocity.y += gravity * Time.deltaTime;

        controller.Move(playerVelocity);

        if (controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {

                playerVelocity.y = jumpHeight;
                Debug.Log("Jump");

            }


        }




        //}

        //public void Jump()
        //{
        //    if (controller.isGrounded)
        //    {
        //        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //        moveDirection *= moveSpeed;

        //        if (Input.GetKeyDown(KeyCode.Space))
        //        {
        //            moveDirection.y = jumpHeight;
        //            Debug.Log("jump");
        //        }
        //    }

        //    moveDirection.y -= gravity * Time.deltaTime;
        //    controller.Move(moveDirection * Time.deltaTime);
        //}

       


    }
    void FlipPlayer()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);


    }
}




