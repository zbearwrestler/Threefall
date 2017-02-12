using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 10.0f;
    public float gravity = 30.0f;
    public float jumping = 10.0f;
    public float camSpeed = 10.0f;

    public Vector3 move;

	// Use this for initialization
	void Start () {
        move = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
        CharacterController controller = gameObject.GetComponent<CharacterController>();
        float moveX = (Input.GetAxis("Horizontal")) * speed;
        float moveZ = (Input.GetAxis("Vertical")) * speed;

        if (controller.isGrounded)
        {
            //Initialize the new posiiton...
            move = new Vector3(moveX, 0.0f, moveZ);

            //Set the direction, based on the camera.. And move it.
            move = Camera.main.transform.TransformDirection(move);

            // If they click jump, then the player will jump.
            if (Input.GetButtonDown("Jump"))
            {
                move.y = jumping;
            }
        }

        move.y -= gravity * Time.deltaTime;
        controller.Move(move * Time.deltaTime);
    }
}
