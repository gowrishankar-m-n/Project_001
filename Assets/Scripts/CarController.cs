using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    // Left/Right or A/D for car rotation
    // Up/Down or W/S for car movement in forward and backward
    public float rotationSpeed, moveSpeed;

    public Transform carTransform;


    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Debug.Log("Horizontal: " + horizontalMovement + "Vertical: " + verticalMovement);

        if (Math.Abs(horizontalMovement) > 0.01f)
        {
            carTransform.Rotate(0f, 0f, -1 * rotationSpeed * horizontalMovement);
        }

        if (Math.Abs(verticalMovement) > 0.01f)
        {
            carTransform.Translate(0f, moveSpeed * verticalMovement, 0f);
        }
    }
}
