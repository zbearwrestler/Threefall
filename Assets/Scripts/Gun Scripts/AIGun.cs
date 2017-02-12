using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIGun : Weapon {
    //make sure ai bullets are very big so players can dodge them
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
