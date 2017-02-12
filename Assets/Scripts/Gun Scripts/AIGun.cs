using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIGun : Weapon {

	// Use this for initialization
	void Start () {
		clipSize = 1;
		ammo = clipSize;
		speed = 500;
		reloadTime = 0;
		shotInterval = 5;
		bx = 0;
		numOfBullets = 1;
	}

}
