using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MMCamera : MonoBehaviour
{
    private float speedMod = 20f;

    void Start()
    {
        transform.LookAt(new Vector3(0,0,0));
    }

    void Update()
    {
        //spin
        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(180,90,0), Time.deltaTime * speedMod);

        //rotate around
        transform.RotateAround(Vector3.zero, Vector3.up, Time.deltaTime * speedMod);
    }
}