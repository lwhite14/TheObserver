using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public float speed = 5f;
    public float movementSliding = 4f;
    public Transform groundCheck;
    public float groundDistance;
    public LayerMask groundMask;

    CharacterController controller;
    Vector3 move;
    float x = 0;
    float z = 0;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        if (CheckGrounded())
        {
            move = transform.right * x + transform.forward * z;
        }
        controller.Move(move * speed * Time.deltaTime);
    }

    public void JumpInput() 
    {
        Debug.Log("I am jumping!");
    }

    public bool CheckGrounded()
    {
        if (groundCheck != null)
        {
            return Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        }
        return true;
    }

    public void MovementSlideX(float newX)
    {
        if (CheckGrounded())
        {
            x = Mathf.Lerp(x, newX, movementSliding * Time.deltaTime);
            if (x < newX)
            {
                if ((x + 0.05) > newX)
                {
                    SetX(newX);
                }
            }
            if (x > newX)
            {
                if ((x - 0.05) < newX)
                {
                    SetX(newX);
                }
            }
        }
    }

    public void MovementSlideZ(float newZ)
    {
        if (CheckGrounded())
        {
            z = Mathf.Lerp(z, newZ, movementSliding * Time.deltaTime);
            if (z < newZ)
            {
                if ((z + 0.05) > newZ)
                {
                    SetZ(newZ);
                }
            }
            if (z > newZ)
            {
                if ((z - 0.05) < newZ)
                {
                    SetZ(newZ);
                }
            }
        }
    }

    public void SetX(float newX)
    {
        x = newX;
    }

    public void SetZ(float newZ)
    {
        z = newZ;
    }
}
