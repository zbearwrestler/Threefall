using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon {

	// Use this for initialization
	void Start () {
		clipSize = 5;
		ammo = clipSize;
		speed = 800;
		reloadTime = 4;
		shotInterval = 1.5f;
		bx = 30;
		numOfBullets = 5;
	}

}