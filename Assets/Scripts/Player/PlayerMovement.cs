using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static bool canMove = true;

    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public float maxSpeed = 5f;
    public float movementSliding = 4f;
    public Transform groundCheck;
    public float groundDistance;
    public LayerMask groundMask;

    Animator anim;
    CharacterController controller;
    Vector3 velocity;
    Vector3 move;
    float x = 0;
    float z = 0;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Ground();
        Move();
        Fall();
        Animations();
    }

    void Ground()
    {
        if (CheckGrounded() && velocity.y < 0)
        {
            velocity.y = -2f;
        }
    }

    void Move()
    {
        if (canMove)
        {
            if (CheckGrounded())
            {
                move = transform.right * x + transform.forward * z;
            }
            move = Vector3.ClampMagnitude(move, 1.0f);
            controller.Move(move * maxSpeed * Time.deltaTime);
        }
    }

    void Fall()
    {
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    public void JumpInput()
    {
        if (canMove)
        {
            Jump();
        }
    }

    void Jump()
    {
        if (CheckGrounded())
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            anim.Play("Jump");
        }
    }

    void Animations() 
    {
        anim.SetFloat("x", x);
        anim.SetFloat("z", z);
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
