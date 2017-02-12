using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPersonView : MonoBehaviour {
    private const float Y_ANGLE_MIN = -5.0f;
    private const float Y_ANGLE_MAX = 50.0f;

    public Transform lookAt;
    public Transform camTransform;

    //private Camera cam; 

    private float distance = 10.0f;
    private float currX = 0.0f;
    private float currY = 0.0f;

    private void Start()
    {
        camTransform = transform;
        //cam = Camera.main;
    }
    private void Update()
    {
        currX += Input.GetAxis("Mouse X");
        currY += Input.GetAxis("Mouse Y");

        currY = Mathf.Clamp(currY, Y_ANGLE_MIN, Y_ANGLE_MAX);
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currY, currX, 0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);
    }

}

//private float sensitivityX = 4.0f;
//private float sensitivityY = 1.0f;