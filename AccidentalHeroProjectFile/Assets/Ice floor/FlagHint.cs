using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlagHint : MonoBehaviour {

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
            GameObject.Find("Hintbox").GetComponent<Image>().enabled = true;
            GameObject.Find("condition").GetComponent<Image>().enabled = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
            GameObject.Find("Hintbox").GetComponent<Image>().enabled = false;
            GameObject.Find("condition").GetComponent<Image>().enabled = false;
    }

     void OnTriggerStay(Collider col)
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
        {
            GameObject.Find("Hintbox").GetComponent<Image>().enabled = false;
            GameObject.Find("condition").GetComponent<Image>().enabled = true;
        }
    }
}