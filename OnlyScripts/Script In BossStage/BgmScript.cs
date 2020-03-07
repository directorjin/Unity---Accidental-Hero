using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

    }


    void pattern4()
    {
        GetComponent<AudioSource>().pitch = 1.1f;
    }
}
