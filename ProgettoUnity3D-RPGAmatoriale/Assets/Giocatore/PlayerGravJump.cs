using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravJump : MonoBehaviour
{
    private CharacterController controller;

    private float verticalVelocity;
    private float gravity = 14.0F;
    private float jumpForce = 10.0F;

    void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        if(controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;
            if(Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpForce;
            }
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        Vector3 moveVector = new Vector3(0, verticalVelocity, 0);
        controller.Move(moveVector * Time.deltaTime);
    }
}