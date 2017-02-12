using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShootDemo1 : MonoBehaviour {
	//public GameObject bulletPrefab;
	public GameObject bulletSpawn;
	public GameObject bulletPrefab;
	//public float shootforce;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
		{

			GameObject bullet = Instantiate (bulletPrefab, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
			Debug.Log ("bullet works");

			bullet.transform.forward = transform.forward;

			// Add velocity to the bullet
			//bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;

			bullet.GetComponent<Rigidbody> ().AddForce (transform.forward * 100);
			Debug.Log ("moving");    



			// Destroy bullet after 2 seconds
			Destroy(bullet, 2.0f);
		}
		//        if (ammo == 0) {
		//            Reload ();
		//        } else {
		//            ammo -= 1;
		//            if (ammo == 0) {
		//                Reload ();
		//            }
		//
		//        }
	}
}