using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour {
    public float force = 5.0f;
    public float speed = 5.0f;
	// Use this for initialization
	void Start () {
        force = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(transform.up * force);
            force = 5;
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        else
        {

            gameObject.GetComponent<Rigidbody>().AddForce(transform.up * -force);
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
	}
}
