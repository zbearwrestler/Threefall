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
    public GameObject GUI;

    // Use this for initialization
    void Start()
    {
        Debug.Log(GUI);
        switchGun = GameObject.FindWithTag("Gun");
        switchGun.GetComponent<Rifle>().enabled = false;
        switchGun.GetComponent<Shotgun>().enabled = false;
        switchGun.GetComponent<Pistol>().enabled = true;
    }


    void OnCollisionEnter(Collision col)
    {
        Debug.Log(GUI);
        if (col.gameObject.tag == "Middle")
        {
            Debug.Log(GUI);
            GUI.GetComponent<KeyboardGUI>().newgun(1);
            switchGun = GameObject.FindWithTag("Gun");
            switchGun.GetComponent<Rifle>().enabled = false;
            switchGun.GetComponent<Shotgun>().enabled = true;
            switchGun.GetComponent<Pistol>().enabled = false;
        }
        else if (col.gameObject.tag == "High")
        {
            Debug.Log(GUI);
            GUI.GetComponent<KeyboardGUI>().newgun(2);
            switchGun = GameObject.FindWithTag("Gun");
            switchGun.GetComponent<Rifle>().enabled = true;
            switchGun.GetComponent<Shotgun>().enabled = false;
            switchGun.GetComponent<Pistol>().enabled = false;
        }
        else if (col.gameObject.tag == "Bottom")
        {
            Debug.Log(GUI);
            GUI.GetComponent<KeyboardGUI>().newgun(0);
            switchGun = GameObject.FindWithTag("Gun");
            switchGun.GetComponent<Rifle>().enabled = false;
            switchGun.GetComponent<Shotgun>().enabled = false;
            switchGun.GetComponent<Pistol>().enabled = true;
        }
    }
}