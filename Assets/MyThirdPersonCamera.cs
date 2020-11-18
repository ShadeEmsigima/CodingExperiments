using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyThirdPersonCamera : MonoBehaviour
{
    public float cameraOffset;
    public float minFollowSpeed;
    

    [Tooltip("Speed at which the camera will rotate around the player")]
    public float rotationSpeed = 20;
    private GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        _player = GameObject.FindWithTag("Player"); //declare player pos
        FollowPlayer(); //follow player
    }

    void FollowPlayer() {
        transform.position += _player.transform.position - transform.position + new Vector3 (0,10,-10);
    }
    void RotateAroundPlayer() {
        //take the rotation from the player on Y
        transform.RotateAround(_player.transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
