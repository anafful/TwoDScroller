
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 10.0f;
    //public float jumpHeight;
    public float gravity = 14.0f;

    private CharacterController controller;
    //private Rigidbody rb;
    private Animator anim;

    private Vector3 moveDirection = Vector3.zero;

    private Vector3 playerVelocity;

    //public float rotationSpeed = 90f;

    bool facingRight;

    //public float jumpForce = 10f;
    //public float maxJumpTime = 0.5f;
    //public bool isJumping = false;
    //private float jumpTimer = 0f;

 
    //public float verticalVeloctiy;
    //public float jumpForce = 10f;
    public float jumpSpeed = 8.0f;

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



        if (Input.GetKeyDown(KeyCode.Space))
        {
            moveDirection.y = jumpSpeed;
            anim.SetBool("Jump", true);
        }
        else
        {
            moveDirection.y -= gravity * Time.deltaTime;
            anim.SetBool("Jump", false);
        }

        controller.Move(moveDirection * Time.deltaTime);





        //if (controller.isGrounded)
        //{
        //    // moveDirection = transform.up * moveSpeed * verInput;
        //    verticalVeloctiy = -gravity * Time.deltaTime;


        //    if (Input.GetKeyDown(KeyCode.Space))
        //    {
        //        verticalVeloctiy = jumpForce;
        //        //moveDirection.y = jumpHeight;
        //        Debug.Log("Jump");

        //    }
        //}

        //else
        //{
        //    //verticalVeloctiy -= gravity * Time.deltaTime;
        //    moveDirection.y -= gravity * Time.deltaTime;
        //}





        ////moveDirection.y += gravity * Time.deltaTime;
        //controller.Move(moveDirection * Time.deltaTime);
        ////transform.Rotate(playerVelocity * Time.deltaTime);


        if (horInput < 0 && facingRight)
        {
            FlipPlayer();
        }

        else if (horInput > 0 && !facingRight)
        {
            FlipPlayer();
        }



    }


void FlipPlayer()
{
    facingRight = !facingRight;
    transform.Rotate(0f, 180f, 0f);


}










      
    }





// Detect jump input
//if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
//{
//    isJumping = true;
//    jumpTimer = 0f;
//    GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
//}

//// Limit jump time
//if (isJumping)
//{
//    jumpTimer += Time.deltaTime;
//    if (jumpTimer >= maxJumpTime)
//    {
//        isJumping = false;
//        Debug.Log("Jumping");
//    }

//private void OnCollisionEnter(Collision collision)
//        {
//            // Reset jump flag when landing
//            if (collision.gameObject.CompareTag("Ground"))
//            {
//                isJumping = false;
//            }

//        }