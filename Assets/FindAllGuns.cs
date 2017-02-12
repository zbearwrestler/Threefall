using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindAllGuns : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

        Shotgun[] guns = GetComponentsInChildren<Shotgun>();
        Debug.Log(guns.Length);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
