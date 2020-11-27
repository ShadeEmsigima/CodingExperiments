using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyThirdPersonCamera : MonoBehaviour
{
    [Tooltip("Distance offset between player and camera")]
    public float distanceOffset = 6;
    [Tooltip("How fast one can zoom in and out")]
    public float zoomSpeed = 5;
    public float zoomMax = 8;
    public float zoomMin = 4;
    [Tooltip("The speed at which the camera tries to stick to the player")]
    public float minFollowSpeed;
    

    [Tooltip("Speed at which the camera will rotate around the player")]
    public float rotationSpeed = 500;
    private GameObject _player;

    void Start()
    {
        //transform.position += _player.transform.position;
    }

    void Update()
    {
        _player = GameObject.FindWithTag("Player"); //declare player pos
        //FollowPlayer(); //alwaysfollow player
        
        //allow zooming
        if (Input.mouseScrollDelta != new Vector2(0f,0f)) { //if you are currently scrolling
            CheckScroll();
        }

        //allow rightclick rotating
        if (Input.GetMouseButton(0)) {
            RotateAroundPlayer();
        }
    }

    void FollowPlayer() {
        //your start pos = player pos
        //you set your offsets

        transform.position += _player.transform.position - transform.position + new Vector3 (0,distanceOffset,-distanceOffset);
    }

    void CheckScroll() {

        //check if zoom in
        if (Input.mouseScrollDelta[1] > 0) { //if you scroll up
            if (distanceOffset > zoomMin) { //make sure you havent scrolled too far in
                distanceOffset -= zoomSpeed * Time.deltaTime; //zoom in
            }
        }

        //else youre zooming out
        else {
            if (distanceOffset < zoomMax) { //make sure you havent scrolled too far in
                distanceOffset += zoomSpeed * Time.deltaTime; //zoom out
            }
        }
    }

    void RotateAroundPlayer() {
        //take the rotation from the player on Y

        if (Input.GetAxis("Mouse X") > 0)
        { //if you drag to the right with the mouse
            transform.RotateAround(_player.transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetAxis("Mouse X") < 0)
        { //if you drag to the right with the mouse
            transform.RotateAround(_player.transform.position, Vector3.up, -rotationSpeed * Time.deltaTime);
        }
    }
}
