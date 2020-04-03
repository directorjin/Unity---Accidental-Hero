using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

public class Collectball : MonoBehaviour {

    public AudioClip pickupsound;
    public GameObject playerbody;
    Vector3 playstart;

    // Use this for initialization
    void Start () {
        playstart = playerbody.transform.position;

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
                GetComponent<BoxCollider>().enabled = false;
                transform.GetChild(0).gameObject.SetActive(true);
                
            GetComponent<AudioSource>().PlayOneShot(pickupsound);
                
        }
    }

    public void DiagonalDefenseOff()
    {
        Debug.Log("DiagnoalDefense");
        transform.GetChild(0).gameObject.SetActive(false);
    }
}
