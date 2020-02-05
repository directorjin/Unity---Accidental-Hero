using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

public class Collectball : MonoBehaviour {

    public AudioClip pickupsound;

	// Use this for initialization
	void Start () {
        
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        { 
                GameObject.Find("clear").SendMessage("Collectplus");
                GetComponent<MeshRenderer>().enabled = false;
                GetComponent<SphereCollider>().enabled = false;

            GetComponent<AudioSource>().PlayOneShot(pickupsound);
                
        }
    }
}
