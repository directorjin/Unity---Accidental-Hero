using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HedraScript : MonoBehaviour {


    public float rotationspeed;
    public float hydraspeed;

    // Use this for initialization
    void Start()
    {
        rotationspeed = 100.0f;
        hydraspeed = 30.0f;
    }
	// Update is called once per frame
	void Update ()
    {

        transform.Rotate(new Vector3(0,0 , rotationspeed * Time.deltaTime));

       transform.position += transform.forward * Time.deltaTime * -10 ;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        { 
            col.transform.SendMessage("playerDamage");
            Destroy(gameObject);
        }
    }
}
