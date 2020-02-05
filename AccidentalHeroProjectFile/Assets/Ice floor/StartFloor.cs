using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Invector.CharacterController;
public class StartFloor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            vThirdPersonInput vt = col.gameObject.GetComponent<vThirdPersonInput>();
            vt.enabled = true;
            vThirdPersonController vc = col.gameObject.GetComponent<vThirdPersonController>();
            vc.enabled = true;
            GameObject.Find("clear").SendMessage("CollectReset");
            for (int i = 1; i <= 12; i++)
            {
                GameObject.Find("xmark"+i.ToString()).GetComponent<SpriteRenderer>().enabled = false;
                GameObject.Find("xmark"+i.ToString()).GetComponent<Xfloor>().count = 0;
            }
        }
    }
}
