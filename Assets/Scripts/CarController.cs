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

    public float boostSpeed;
    public float boostTime;
    public float currentSpeed;
    public float boostEndTime;  // Time when boost should end

    void Start()
    {
        currentSpeed = moveSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        // Check boost timer
        if (boostEndTime > 0 && Time.time >= boostEndTime)
        {
            moveSpeed = currentSpeed; // Reset speed
            boostEndTime = 0f;
        }

        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Debug.Log("Horizontal: " + horizontalMovement + "Vertical: " + verticalMovement);

        if (Math.Abs(horizontalMovement) > 0.01f)
        {
            carTransform.Rotate(0f, 0f, -1 * rotationSpeed * horizontalMovement * Time.deltaTime);
        }

        if (Math.Abs(verticalMovement) > 0.01f)
        {
            carTransform.Translate(0f, moveSpeed * verticalMovement * Time.deltaTime, 0f);
        }

    }

    // Method to trigger nitro boost
    public void ApplyNitroBoost()
    {
        moveSpeed = currentSpeed * boostSpeed;     // Double speed
        boostEndTime = Time.time + boostTime;     // Boost lasts 5 seconds
    }
        

    

 
}
