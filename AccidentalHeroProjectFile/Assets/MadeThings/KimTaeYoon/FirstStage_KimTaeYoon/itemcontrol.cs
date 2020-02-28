using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemcontrol : MonoBehaviour {

    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {//변경
            Destroy(gameObject);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
