using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour {
    int health = 10;
    int healthloss = 0;
    bulletscript pistolbullet;
	RifleB riflebullet;
	ShotgunB shotgunbullet;
    AudioClip breaknoise;

    void Start()
    {
       // breaknoise = Instantiate(Reasouces.Load());
    }

    void OnCollisionEnter(Collision col)
    {
		if (col.gameObject.tag == "Pistol_Bullet")
        {
            Destroy(gameObject);
            Destroy (col.gameObject);
		} else if (col.gameObject.tag == "Rifle_Bullet") {
			riflebullet = col.gameObject.GetComponent<RifleB> ();
			health -= riflebullet.dmg;
				Destroy (col.gameObject);


		} else if(col.gameObject.tag == "Shotgun_Bullet")
        {
            shotgunbullet = col.gameObject.GetComponent<ShotgunB> ();
            health -= shotgunbullet.dmg;
            Destroy (col.gameObject);
		}

		if (health <= 0) {
			Destroy (gameObject);
		}

    }

}
