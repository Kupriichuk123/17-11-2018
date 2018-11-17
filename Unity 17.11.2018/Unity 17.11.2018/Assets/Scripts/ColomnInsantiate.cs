using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColomnInsantiate : MonoBehaviour {
    public Transform CubePrefabs;
    public Transform CylinderPrefabs;
	// Use this for initialization
	void Start () {
        for(int i=0; i < 10; i++)
        {
            Instantiate(CubePrefabs, new Vector3(i* 10.0F, 0), Quaternion.identity);
            Instantiate(CylinderPrefabs, new Vector3(i * 12.5F, 5.2F), Quaternion.identity);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
