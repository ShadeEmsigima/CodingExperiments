using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyThirdPersonCamera : MonoBehaviour
{
    [Tooltip("Distance offset between player and camera")]
    public float cameraOffset = 6;
    [Tooltip("How fast one can zoom in and out")]
    public float zoomSpeed = 5;
    public float zoomMax = 8;
    public float zoomMin = 4;
    [Tooltip("The speed at which the camera tries to stick to the player")]
    public float minFollowSpeed;
    

    [Tooltip("Speed at which the camera will rotate around the player")]
    public float rotationSpeed = 20;
    private GameObject _player;

    void Start()
    {
       
    }

    void Update()
    {
        _player = GameObject.FindWithTag("Player"); //declare player pos
        FollowPlayer(); //alwaysfollow player

        //allow zooming
        if (Input.mouseScrollDelta != new Vector2(0f,0f)) { //if you are currently scrolling
            CheckScroll();
        }
        
    }

    void FollowPlayer() {
        transform.position += _player.transform.position - transform.position + new Vector3 (0,cameraOffset,-cameraOffset);
    }

    void CheckScroll() {

        //check if zoom in
        if (Input.mouseScrollDelta[1] > 0) { //if you scroll up
            if (cameraOffset > zoomMin) { //make sure you havent scrolled too far in
                cameraOffset -= zoomSpeed * Time.deltaTime; //zoom in
            }
        }

        else {
            if (cameraOffset < zoomMax) { //make sure you havent scrolled too far in
                cameraOffset += zoomSpeed * Time.deltaTime; //zoom in
            }
        }
    }

    void RotateAroundPlayer() {
        //take the rotation from the player on Y
       //transform.RotateAround(_player.transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
