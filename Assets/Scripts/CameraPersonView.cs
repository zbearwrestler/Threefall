using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPersonView : MonoBehaviour {
    private const float Y_ANGLE_MIN = -70.0f;
    private const float Y_ANGLE_MAX = 70.0f;
    private const float Y_PANGLE_MIN = -40.0f;
    private const float Y_PANGLE_MAX = 40.0f;

    public Transform lookAt;
    public Transform camTransform;
    public Transform player;
    public float currentangley = 0;
    public float currentanglex = 0;

    //private Camera cam; 

    private float distance = 10.0f;
    private float currX = 0.0f;
    private float currY = 0.0f;
    public float turnspeed = 10.0f;
    float newX;
    float newY;

    private void Start()
    {
        camTransform = transform;
        //cam = Camera.main;
    }
    private void Update()
    {
        currX += Input.GetAxis("Mouse X");
        currY += Input.GetAxis("Mouse Y");
        newX += Input.GetAxis("Mouse X");
        currY = Mathf.Clamp(currY, Y_ANGLE_MIN, Y_ANGLE_MAX);
        newY += Input.GetAxis("Mouse Y");
    }

    private void LateUpdate()
    {

        currentangley = newY + currentangley;
        currentangley = Mathf.Clamp(currentangley, Y_ANGLE_MIN, Y_ANGLE_MAX);
        player.transform.rotation = Quaternion.Euler(currentangley, player.transform.rotation.eulerAngles.y, player.transform.rotation.eulerAngles.z);
        player.transform.Rotate(0, newX, 0, Space.World);
        camTransform.RotateAround(player.transform.position, Vector3.up,   currX * turnspeed * Time.deltaTime);
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currY, currX, 0);
        Mathf.Clamp(camTransform.rotation.eulerAngles.y, Y_ANGLE_MIN, Y_ANGLE_MAX);
        

        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);
        newX = 0;
        newY = 0;
   }

}

//private float sensitivityX = 4.0f;
//private float sensitivityY = 1.0f;