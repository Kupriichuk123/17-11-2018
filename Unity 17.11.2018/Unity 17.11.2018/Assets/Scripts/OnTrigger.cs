using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour {

    // Use this for initialization
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            Application.LoadLevel(Application.loadedLevel);
    }
}
