using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Copy pasted from unity documentation with some extra

public class CameraLookAt : MonoBehaviour
{
    [Tooltip("Object you want the camera to look at")]
    public Transform target;

    void Update()
    {
        LookAt();
    }

    void LookAt() {
        // Rotate the camera every frame so it keeps looking at the target
        transform.LookAt(target);

        // Same as above, but setting the worldUp parameter to Vector3.left in this example turns the camera on its side
        transform.LookAt(target, Vector3.up);
    }
}
