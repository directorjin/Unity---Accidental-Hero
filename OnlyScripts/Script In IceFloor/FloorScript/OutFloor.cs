using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Invector.CharacterController;

public class OutFloor : MonoBehaviour {
    
    
    // Use this for initialization
    void Start () {
        
       
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    void OnTriggerEnter(Collider col)
    {

      
    }
   
    void OnTriggerStay(Collider col)
    {
            if (col.tag == "Player")
            {
                
                {
                    vThirdPersonInput vt = col.gameObject.GetComponent<vThirdPersonInput>();
                    vt.enabled = true;
                    vThirdPersonController vc = col.gameObject.GetComponent<vThirdPersonController>();
                    vc.enabled = true;
                
                }
                
                    
             }
            
    }
    void OnTriggerExit(Collider col)
    {
       
            
    }






}
