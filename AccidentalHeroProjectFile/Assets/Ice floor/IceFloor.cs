using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Invector.CharacterController;

public class IceFloor : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        
    }
        
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            
            if (Mathf.Abs(col.transform.forward.x) >= Mathf.Abs(col.transform.forward.z))
                col.transform.position = new Vector3(col.transform.position.x, 0, transform.position.z);
            else
                col.transform.position = new Vector3(transform.position.x, 0, col.transform.position.z);

            /* if (Mathf.Abs(transform.position.x - col.transform.position.x) >= Mathf.Abs(transform.position.z - col.transform.position.z))
             {
                 col.transform.position = new Vector3(col.transform.position.x, 0, transform.position.z);
                 if(transform.position.x-col.transform.position.x >0)
                 rb.velocity = new Vector3(9, 0, 0);
                 else
                     rb.velocity = new Vector3(-9, 0, 0);
             }
             else
             {
                 col.transform.position = new Vector3(transform.position.x, 0, col.transform.position.z);
                 if(transform.position.z-col.transform.position.z>0)
                 rb.velocity = new Vector3(0, 0, 9);
                 else
                     rb.velocity = new Vector3(0, 0, -9);

             }*/
        }
    }
    void OnTriggerExit(Collider other)
    {
       
    }
    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            


            vThirdPersonInput vt = col.gameObject.GetComponent<vThirdPersonInput>();
            vt.enabled = false;
            vThirdPersonController vc = col.gameObject.GetComponent<vThirdPersonController>();
            vc.enabled = false;
            Rigidbody rb = col.GetComponent<Rigidbody>();
            if (Mathf.Abs(col.transform.forward.x) >= Mathf.Abs(col.transform.forward.z))
                rb.velocity = new Vector3(col.transform.forward.x *10, 0, 0);
            else
                rb.velocity = new Vector3(0, 0, col.transform.forward.z*10 );
           /*
            if (rb.velocity == new Vector3(0, 0, 9))
                rb.velocity = new Vector3(0, 0, 9);
            else if (rb.velocity == new Vector3(0, 0, -9))
                rb.velocity = new Vector3(0, 0, -9);
            else if (rb.velocity == new Vector3(9, 0, 0))
                rb.velocity = new Vector3(9, 0, 0);
            else if (rb.velocity == new Vector3(-9, 0, 0))
                rb.velocity = new Vector3(-9, 0, 0);*/










        }

    }
    

}
