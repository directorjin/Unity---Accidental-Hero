using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowDart : MonoBehaviour {




	// Use this for initialization
	void Start () {
        Destroy(gameObject, 4.0f);
        transform.Rotate(-90.0f, 10f, 0);
        
    }
	
	// Update is called once per frame
	void Update () {

    }
}
