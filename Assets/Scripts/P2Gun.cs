using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Gun : Weapon
{
    GameObject switchGun2;
    // Use this for initialization
    void Start()
    {
        switchGun2 = GameObject.FindWithTag("Gun2");
        switchGun2.GetComponent<Rifle>().enabled = false;
        switchGun2.GetComponent<Shotgun>().enabled = false;
        switchGun2.GetComponent<Pistol>().enabled = true;
    }


    void OnCollisionEnter(Collision col)
    {
        Debug.Log("here");

        if (col.gameObject.tag == "Middle")
        {
            Debug.Log("Hit Middle");
            switchGun2 = GameObject.FindWithTag("Gun2");
            switchGun2.GetComponent<Rifle>().enabled = false;
            switchGun2.GetComponent<Shotgun>().enabled = true;
            switchGun2.GetComponent<Pistol>().enabled = false;
            
        }
        else if (col.gameObject.tag == "High")
        {
            switchGun2 = GameObject.FindWithTag("Gun2");
            switchGun2.GetComponent<Rifle>().enabled = true;
            switchGun2.GetComponent<Shotgun>().enabled = false;
            switchGun2.GetComponent<Pistol>().enabled = false;
        }
        else if (col.gameObject.tag == "Bottom")
        {
            switchGun2 = GameObject.FindWithTag("Gun2");
            switchGun2.GetComponent<Rifle>().enabled = false;
            switchGun2.GetComponent<Shotgun>().enabled = false;
            switchGun2.GetComponent<Pistol>().enabled = true;
        }
    }
}