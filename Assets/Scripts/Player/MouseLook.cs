using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform playerBody;
    float mouseSensitivity = 30f;
    float xRotation = 0f;
    float mouseX = 0f;
    float mouseY = 0f;

    void Update()
    {
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);  
    }

    public void SetMouseSensitivity(float newSens)
    {
        mouseSensitivity = newSens;
    }

    public void SetMouseX(float newX)
    {
        mouseX = newX * mouseSensitivity * Time.deltaTime;
    }

    public void SetMouseY(float newY)
    {
        mouseY = newY * mouseSensitivity * Time.deltaTime;
    }
}
