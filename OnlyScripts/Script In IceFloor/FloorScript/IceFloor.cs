using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Invector.CharacterController;

public class IceFloor : MonoBehaviour {

    
    public GameObject playerbody;
    Vector3 playstart;
    
    

    // Use this for initialization
    void Start()
    {
        playerbody = GameObject.Find("male");
        playstart = playerbody.transform.position;
    }
        
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            #region 追加ソース
            float playerRotation = col.transform.rotation.y; 
            
            Rigidbody rb = col.GetComponent<Rigidbody>();
            if (Mathf.Abs(col.transform.forward.x) >= Mathf.Abs(col.transform.forward.z))
            {
  
                    col.transform.position = new Vector3(col.transform.position.x, 0, transform.position.z);
                    rb.AddForce(new Vector3(0, 0, 0.1f));//追加ソース
 
            }
            else
            { 
                    col.transform.position = new Vector3(transform.position.x, 0, col.transform.position.z);
                    rb.AddForce(new Vector3(0.1f, 0, 0));//追加ソース

            }
            #endregion

        }
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

        }

    }



}
