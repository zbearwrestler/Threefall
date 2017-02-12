using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour {
    int health = 10;
    int healthloss = 0;
    bulletscript pistolbullet;
	RifleB riflebullet;
	ShotgunB shotgunbullet;

    void OnCollisionEnter(Collision col)
    {
		if (col.gameObject.tag == "Pistol_Bullet") {
			pistolbullet = col.gameObject.GetComponent<bulletscript> ();
			healthloss = health - pistolbullet.dmg;
			pistolbullet.dmg -= health;
			health -= healthloss;
			if (pistolbullet.dmg <= 0) {
				Destroy (col.gameObject);
			}
				

		} else if (col.gameObject.tag == "Rifle_Bullet") {
			riflebullet = col.gameObject.GetComponent<RifleB> ();
			healthloss = health - riflebullet.dmg;
			riflebullet.dmg -= health;
			health -= healthloss;
			if (riflebullet.dmg <= 0) {
				Destroy (col.gameObject);
			}


		} else {
			shotgunbullet = col.gameObject.GetComponent<ShotgunB> ();
			healthloss = health - shotgunbullet.dmg;
			shotgunbullet.dmg -= health;
			health -= healthloss;
			if (shotgunbullet.dmg <= 0) {
				Destroy (col.gameObject);
			}
		}

		if (health <= 0) {
			Destroy (gameObject);
		}

    }

}
