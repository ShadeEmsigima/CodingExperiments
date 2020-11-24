using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public float var;
    private GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _player = GameObject.FindWithTag("Player"); //declare player pos
        transform.RotateAround(_player.transform.position, Vector3.up, var * Time.deltaTime);
    }
}
