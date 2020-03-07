using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xfloor : MonoBehaviour {
    public int count;
    public GameObject playerbody;
    public GameObject collectBall;
    Vector3 playstart;


    // Use this for initialization
    void Start () {
        count = 0;
        playstart = playerbody.transform.position;
        
}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerExit(Collider col)
    {
         if (col.tag == "Player")
        {
            
            GetComponent<SpriteRenderer>().enabled = true;
            Debug.Log("Diagnoal");
            collectBall.GetComponent<Collectball>().DiagonalDefenseOff();
            count++;
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            if (count > 0)
            {
                col.transform.position = playstart;
                GameObject.Find("clear").SendMessage("CollectReset");
               
            }
        }
    }
}
