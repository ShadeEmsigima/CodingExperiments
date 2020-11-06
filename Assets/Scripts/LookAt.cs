using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This might be a nice script for when you talk to someone and they turn to see you (if theyre interested)
public class LookAt : MonoBehaviour
{
    bool IsPiqued = true;
    public GameObject Target = GameObject.FindGameObjectWithTag("Player");

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {

        
    }

    //void WhenTheyStartTalking()
    //            if (IsPiqued == true) {
    //       //rotate NPC towards the player
    //      transform.LookAt(Target.transform);
    //    }

}
