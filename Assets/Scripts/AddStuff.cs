using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddStuff : MonoBehaviour
{
    public int level;
	// Use this for initialization
	void Start () {

        MeshRenderer[] meshes = GetComponentsInChildren<MeshRenderer>();

        for (int i = 0; i < meshes.Length; i++)
        {
            AddStuffToObject(meshes[i]);
        }
		
	}

    void AddStuffToObject(MeshRenderer mesh)
    {
        if (mesh.GetComponentInChildren<Collider>() == null)
        {
            if(level == 0)
            {
                mesh.gameObject.tag = "Bottom";
            }
            if(level == 1)
            {
                mesh.gameObject.tag = "Middle";
            }
            if(level == 2)
            {
                mesh.gameObject.tag = "High";
            }
            BoxCollider boxColl = mesh.gameObject.AddComponent<BoxCollider>();
            boxColl.size = mesh.bounds.size * 10f;

            mesh.gameObject.AddComponent<FloorScript>();
        }
    }
	
}
