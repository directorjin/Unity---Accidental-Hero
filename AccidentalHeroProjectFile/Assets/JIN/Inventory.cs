using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    public static int itemwooden = 0;
    public static int itemmatch = 0;
    public Image woodImage;
    public Animator woodOn;

    public Image matchImage;
    public Animator matchOn;

    public AudioClip itemget;

    public void OnTriggerEnter(Collider col)
    {
        if(col.tag == "itemWooden")
        {
            itemwooden++;
            woodOn.SetInteger("itemwooden", 1);
            GetComponent<AudioSource>().PlayOneShot(itemget);
            

        }
        else if(col.tag == "itemMatch")
        {
            itemmatch++;
            matchOn.SetInteger("itemmatch", 1);
            GetComponent<AudioSource>().PlayOneShot(itemget);
            
        }

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
