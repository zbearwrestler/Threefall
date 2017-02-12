using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Script : AIGun {

    public GameObject player;
    public GameObject floor;
    public float playerDistance;
    public float rotationDamping;
    public float moveSpeed;

	// Use this for initialization
	void Start () {
        //clipSize = 1;
        //ammo = clipSize;
        //speed = 500;
        //reloadTime = 0;
        //shotInterval = 5f;
        //bx = 0;
        //numOfBullets = 1;

        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        if(floor == null)
        {
            floor = GameObject.FindWithTag("Floor");
        }
    }
	
	// Update is called once per frame
	void Update () {
            playerDistance = Vector3.Distance(player.transform.position, transform.position);

            if (playerDistance < 25f)
            {
                lookAtPlayer();
            }
            if (playerDistance < 20f)
            {
                if (playerDistance > 12f)
                {
                    chase();
                }
                else if (playerDistance < 15f)
                {
                    attack();
                }
            }
	}

    void lookAtPlayer()
    {
        Quaternion rotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationDamping);
    }

    void chase()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    void attack()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward - new Vector3(0, 0 ,0), out hit))
        {
            if (hit.collider.gameObject.tag == "Player")
            {
                Shoot();
                }
            }
        }
    }
