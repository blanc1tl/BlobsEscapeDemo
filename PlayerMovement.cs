using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Author: Collin Van Brabant

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;    //Script for handling movement of player
    public Animator animator;                   //Animator for player sprite

    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;


    // Update is called once per frame
    void Update(){
        //Gets horizontal movement value
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        //Sets animation parameter "Speed" to players movement value
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        //Sets jump and animation parameter "isJumping" to true
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("isJumping", true);
        }
    }

    //When player lands, sets animation parameter "isJumping" to false
    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
    }

    void FixedUpdate()
    {
        //Sends players movement and whether or not they are jumping to CharacterController2D script
        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
    }
}
