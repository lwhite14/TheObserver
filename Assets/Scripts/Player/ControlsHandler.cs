using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlsHandler : MonoBehaviour
{
    MasterControls controls;
    InputAction look;
    InputAction forwardBackward;
    InputAction lateral;

    void OnEnable()
    {
        controls = new MasterControls();

        look = controls.Player.Look;
        look.Enable();
        forwardBackward = controls.Player.Move_ForwardBackward;
        forwardBackward.Enable();
        lateral = controls.Player.Move_Laterally;
        lateral.Enable();

        controls.Player.Jump.performed += JumpPerformed;
        controls.Player.Jump.Enable();
    }

    void OnDisable()
    {
        look.Disable();
        forwardBackward.Disable();
        lateral.Disable();

        controls.Player.Jump.performed -= JumpPerformed;
        controls.Player.Jump.Disable();
    }

    private void JumpPerformed(InputAction.CallbackContext obj)
    {
        if (FindObjectOfType<PlayerMovement>() != null) 
        {
            FindObjectOfType<PlayerMovement>().JumpInput();
        }
    }

    void Update()
    {
        PlayerMovement playerMovement = FindObjectOfType<PlayerMovement>();
        MouseLook mouseLook = FindObjectOfType<MouseLook>();

        playerMovement.MovementSlideX(lateral.ReadValue<float>());
        playerMovement.MovementSlideZ(forwardBackward.ReadValue<float>());
        mouseLook.SetMouseX(look.ReadValue<Vector2>().x);
        mouseLook.SetMouseY(look.ReadValue<Vector2>().y);
    }
}