using System;
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
        controls.Player.WeaponPrimaryAction.performed += EquipedFunctionPerformed;
        controls.Player.WeaponPrimaryAction.Enable();
        controls.UI.Start.performed += StartPerformed;
        controls.UI.Start.Enable();
    }


    void OnDisable()
    {
        look.Disable();
        forwardBackward.Disable();
        lateral.Disable();

        controls.Player.Jump.performed -= JumpPerformed;
        controls.Player.Jump.Disable();
        controls.Player.WeaponPrimaryAction.performed -= EquipedFunctionPerformed;
        controls.Player.WeaponPrimaryAction.Disable();
        controls.UI.Start.performed -= StartPerformed;
        controls.UI.Start.Disable();
    }

    private void JumpPerformed(InputAction.CallbackContext obj)
    {
        if (FindObjectOfType<PlayerMovement>() != null) 
        {
            FindObjectOfType<PlayerMovement>().JumpInput();
        }
    }

    private void StartPerformed(InputAction.CallbackContext obj)
    {
        if (!Application.isEditor)
        {
            StatePanel.instance.EndGame();
        }
    }    
    
    private void EquipedFunctionPerformed(InputAction.CallbackContext obj)
    {
        if (FindObjectOfType<Viewmodel>() != null) 
        {
            FindObjectOfType<Viewmodel>().TurnOnOff();
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
