using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followTarget;
    //public Vector3 offsetDistance;
    //public float damp;

    //private Vector3 followVelocity = Vector3.zero;

    private void Update()
    {
        //Vector3 position = followTarget.position + offsetDistance;
        transform.position = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
    }
}
