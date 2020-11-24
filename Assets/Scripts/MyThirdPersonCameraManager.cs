using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script sits on the cameraSystem, or manager object
//It takes the player, camera can camera boom in account to create a hacky 3d person controler that can:
//Avoid obstacles, zoom in and out, etc.

public class MyThirdPersonCameraManager : MonoBehaviour
{
    [Tooltip("Insert the camera that will face the player, and sit on the boom")]
    public Camera playerCamera;
    [Tooltip("Insert the boom that will be attatched to the player's center on one end, and have the camera will sit on the other")]
    public GameObject cameraBoom;
    [Tooltip("The player object or parent to follow")]
    public GameObject player;

    public float maxOffset;
    public float yAngle;
    public float distOffset;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
