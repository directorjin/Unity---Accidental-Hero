using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bill : MonoBehaviour {
    private Transform camTr;

	// Use this for initialization
	void Start () {
        camTr = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(camTr.position);
	}
}
