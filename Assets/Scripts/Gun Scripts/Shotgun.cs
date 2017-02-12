using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon {

	// Use this for initialization
	void Start () {
		clipSize = 8;
		ammo = clipSize;
		speed = 1600;
		reloadTime = 2;
		shotInterval = 1f;
		bx = 40;
		numOfBullets = 6;
	}

}