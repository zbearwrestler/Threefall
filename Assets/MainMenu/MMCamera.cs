using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MMCamera : MonoBehaviour
{
    
    private float speedMod = 50.0f;

    void Start()
    {
        transform.LookAt(new Vector3(0,0,0));
    }

    void Update()
    {
        //while (elapsedTime < rotationSpeed)
        //{
        //    Quaternion startPos = transform.rotation;
        //    Quaternion endPos = transform.rotation;
        //    endPos.eulerAngles = new Vector3(transform.eulerAngles.x, 360, transform.eulerAngles.z);
        //    transform.rotation = Quaternion.Lerp(startPos, rotateTo, (elapsedTime / rotationSpeed));
        //    elapsedTime += Time.deltaTime;
        //}
        //  transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0,0,0), 20 * Time.deltaTime * speedMod);
        //Quaternion rotation = Quaternion.LookRotation(new Vector3(0, 0, 0));
        // transform.rotation = rotation;

        transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime * speedMod);
    }
}