using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapControl : MonoBehaviour {
    public AudioClip deadSound;

    public void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Monster")
        {
            AudioSource.PlayClipAtPoint(deadSound, transform.position);
            Destroy(col.gameObject);
            GameObject.Find("snowFight-J").GetComponent<FireSnow>().count++;
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
