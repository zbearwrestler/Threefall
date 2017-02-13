using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * PlayerGun should be attached to Player object with Gun child.
 * Gun child should have Rifle, Shotgun, and Pistol scripts attached with respective bullet types.
 * 
 * FindWithTag should be the gun TAG.
 * col.gameObject.name should be the floor NAME.
 *          you may switch 'name' with 'tag' if necessary.
 */
public class PlayerGun : Weapon
{
    GameObject switchGun;
    // Use this for initialization
    void Start()
    {
        switchGun = GameObject.FindWithTag("Gun");
        switchGun.GetComponent<Rifle>().enabled = false;
        switchGun.GetComponent<Shotgun>().enabled = false;
        switchGun.GetComponent<Pistol>().enabled = true;
    }


    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Middle")
        {
            Debug.Log("Hit Middle");
            switchGun = GameObject.FindWithTag("Gun");
            switchGun.GetComponent<Rifle>().enabled = false;
            switchGun.GetComponent<Shotgun>().enabled = true;
            switchGun.GetComponent<Pistol>().enabled = false;
        }
        else if (col.gameObject.tag == "High")
        {
            switchGun = GameObject.FindWithTag("Gun");
            switchGun.GetComponent<Rifle>().enabled = true;
            switchGun.GetComponent<Shotgun>().enabled = false;
            switchGun.GetComponent<Pistol>().enabled = false;
        }
        else if (col.gameObject.tag == "Bottom")
        {
            switchGun = GameObject.FindWithTag("Gun");
            switchGun.GetComponent<Rifle>().enabled = false;
            switchGun.GetComponent<Shotgun>().enabled = false;
            switchGun.GetComponent<Pistol>().enabled = true;
        }
    }
}