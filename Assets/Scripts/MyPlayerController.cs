using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this will be the basic movement script for the character in ->MVP<- form

public class MyPlayerController : MonoBehaviour
{
    [Tooltip("The speed at which this walks ya dummy")]
    public float WalkSpeed = 5;
    [Tooltip("Speed at which you rotate")]
    public float RotateSpeed = 5;


    void Start()
    {
    }

    
    void Update()
    {
        // if pressing 'w' > go forwards by 'walk speed'
        if (Input.GetKey("w")) {
            transform.position += transform.forward * Time.deltaTime * WalkSpeed;
        }

        // if pressing 'a' > rotate left
        if (Input.GetKey("a"))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * RotateSpeed);
           // transform.rotation += transform.rotation * Time.deltaTime * RotateSpeed;
        }

        // if pressing 'a' > rotate right
        if (Input.GetKey("d"))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * RotateSpeed);
            // transform.rotation += transform.rotation * Time.deltaTime * RotateSpeed;
        }

        // if pressing 'a' > go strafe 'right'
        if (Input.GetKey("e")) { 
            transform.position += transform.right * Time.deltaTime * WalkSpeed;
        }

        // if pressing 'd' > go strafe 'left'
        if (Input.GetKey("q")) {
            transform.position += transform.right * -Time.deltaTime * WalkSpeed;
        }

        // if pressing 's' > go 'backwards'
        if (Input.GetKey("s")) {
            transform.position += transform.forward * -Time.deltaTime * WalkSpeed;
        }
    }
}
