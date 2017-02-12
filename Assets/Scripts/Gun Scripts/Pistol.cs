using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon {

	// Use this for initialization
	void Start () {
		clipSize = 10;
		ammo = clipSize;
		speed = 500;
		reloadTime = 2;
		shotInterval = 0.5f;
		bx = 0;
		numOfBullets = 1;
	}

}
