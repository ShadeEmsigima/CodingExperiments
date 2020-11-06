using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this will be the basic movement script for the character in ->MVP<- form

public class MyPlayerController : MonoBehaviour
{
    [Tooltip("The speed at which this walks ya dummy")]
    public float WalkSpeed = 5;


    void Start()
    {
        Debug.Log("Game start");
    }

    
    void Update()
    {
        // if pressing 'w' > go forwards by 'walk speed'
        if (Input.GetKey("w")) {
            transform.position += transform.forward * Time.deltaTime * WalkSpeed;
        }

        // if pressing 'a' > go 'left'
        if (Input.GetKey("d")) { 
            transform.position += transform.right * Time.deltaTime * WalkSpeed;
        }

        // if pressing 'd' > go 'right'
        if (Input.GetKey("a")) {
            transform.position += transform.right * -Time.deltaTime * WalkSpeed;
        }

        // if pressing 's' > go 'backwards'
        if (Input.GetKey("s")) {
            transform.position += transform.forward * -Time.deltaTime * WalkSpeed;
        }
    }
}
