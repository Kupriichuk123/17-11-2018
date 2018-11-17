using System.Collections;
using System.Collections.Generic;
using UnityEngine;
   
public class Camera : MonoBehaviour {
    public Transform cube;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3 (cube.position.x, cube.position.y, transform.position.z);
	}
}
