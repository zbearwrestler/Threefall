﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoystickMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public float gravity = 30.0f;
    public float jumping = 10.0f;
    public float camSpeed = 10.0f;
    Animator anim;
    public Vector3 move;
    //True if on the ceiling, ie. upside down
    public bool isUpsideDown = false;
    //How fast you rotate when flipping gravity
    public float rotatoSpeed = 2f;

    //Quaternion representing how far to rotate
    private Quaternion rotateTo;
    //Distance from bottom of the collider to the ground

    public Weapon Gun;
    private float groundDist;
    public Camera mine;

    private CapsuleCollider capsule;
    private CharacterController controller;

    // Use this for initialization
    void Start()
    {
        move = Vector3.zero;
        anim = GetComponent<Animator>();
        capsule = GetComponent<CapsuleCollider>();
        controller = gameObject.GetComponent<CharacterController>();
        //Set groundDist to be the edge of the y-axis
        groundDist = capsule.bounds.extents.y;

        Gun = gameObject.GetComponent<Weapon>();
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        float moveX = (Input.GetAxis("Horizontal_Joystick")) * speed;
        float moveZ = (Input.GetAxis("Vertical_Joystick")) * speed;


        if (controller.isGrounded)
        {
            anim.SetBool("Falling", false);
            //Initialize the new posiiton...
            move = new Vector3(moveX, 0.0f, moveZ);

            //Set the direction, based on the camera.. And move it.
            move = mine.transform.TransformDirection(move);
            anim.SetFloat("Speed", move.z);
           

            if (Input.GetButtonDown("Fire1_Joystick"))
            {
                Gun.Shoot();
            }
        }
        else
        {
            anim.SetBool("Falling", true);
        }

        move.y -= gravity * Time.deltaTime;
        controller.Move(move * Time.deltaTime);

    }
    void FixedUpdate()
    {
        //Rotate gravity only if user wants to jump and is touching the ground
        if (Input.GetButtonDown("Jump_Joystick") && IsGrounded())
        {
            move.y = 0;
            anim.SetTrigger("Jump");
            isUpsideDown = !isUpsideDown;
            gravity *= -1;
            StartCoroutine("flipBody");
        }
    }
    //True if object is touching the ground (in this case, either ceiling or floor)
    bool IsGrounded()
    {
        Vector3 dir;
        //Set the right side to detect where to fire a raycast based on orientation
        dir = isUpsideDown ? transform.up : -transform.up;
        //You're grounded if the raycast hits the floor within 0.1 units
        return Physics.Raycast(transform.position, dir, groundDist + 1f);
    }
    //Coroutine to flip the body. In coroutine so it can run over multiple frames
    IEnumerator flipBody()
    {
        Debug.Log("Coroutine started");
        //Initialize time so lerp is smooth over given time
        float elapsedTime = 0f;
        Quaternion startPos = transform.rotation;
        //Set rotation to upside down or right side up based on current orientation
        rotateTo = transform.rotation;
        rotateTo.eulerAngles = isUpsideDown ? new Vector3(0f, transform.eulerAngles.y, 180f) : new Vector3(0f, transform.eulerAngles.y, 360f);
        //Flip the body
        while (elapsedTime < rotatoSpeed)
        {
            transform.rotation = Quaternion.Lerp(startPos, rotateTo, (elapsedTime / rotatoSpeed));
            elapsedTime += Time.deltaTime;
            yield return 0;
        }
    }


}
