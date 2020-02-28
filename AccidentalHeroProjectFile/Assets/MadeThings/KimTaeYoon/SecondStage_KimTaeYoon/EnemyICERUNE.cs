using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyICERUNE : MonoBehaviour {

    int count = 0;

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            count++;
            if(count == 2)
            {
                GameObject.FindGameObjectWithTag("Player").SendMessage("playerDamage");
                count = 0;
            }
        }
    }
          // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
