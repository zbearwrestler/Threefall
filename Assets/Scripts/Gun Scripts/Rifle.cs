using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Weapon {

	// Use this for initialization
	void Start () {
		clipSize = 25;
		ammo = clipSize;
		speed = 800;
		reloadTime = 3;
		shotInterval = 0.1f;
		bx = 10;
		numOfBullets = 1;
	}
		
}