using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Invector.CharacterController;

public class ClearCheck : MonoBehaviour {
    public int collect;

    public GameObject clearplace;
    public GameObject wall;
    public float speed;
    public bool check;
    
    // Use this for initialization
    void Start () {
        collect = 0;
        speed = 10;
        check = false;

	}
	
	// Update is called once per frame
	void Update () {
        if (check == true)
        {
            clearplace.transform.position = Vector3.MoveTowards(clearplace.transform.position, new Vector3(clearplace.transform.position.x, -9, clearplace.transform.position.z), speed * Time.deltaTime);
            wall.transform.position = Vector3.MoveTowards(wall.transform.position, new Vector3(wall.transform.position.x, -9, clearplace.transform.position.z), speed * Time.deltaTime);
        }
            
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            if (collect >= 12)
            {

                Rigidbody rb = col.GetComponent<Rigidbody>();
                rb.velocity = new Vector3(0, 0, 0);
               
                vThirdPersonInput vt = col.gameObject.GetComponent<vThirdPersonInput>();
                vt.enabled = false;
                vThirdPersonController vc = col.gameObject.GetComponent<vThirdPersonController>();
                vc.enabled = false;
                check = true;

                StartCoroutine("ClearEffect");
            }
            else
            {
                vThirdPersonInput vt = col.gameObject.GetComponent<vThirdPersonInput>();
                vt.enabled = true;
                vThirdPersonController vc = col.gameObject.GetComponent<vThirdPersonController>();
                vc.enabled = true;
            }
        }
    }
    void Collectplus()
    {
        collect++;
        Debug.Log(collect);
    }
    void CollectReset()
    {
        collect = 0;
        
        
       
        for (int i = 1; i <= 12; i++)
        {
            Debug.Log("snowball" + i.ToString());
            GameObject.Find("snowball" + i.ToString()).GetComponent<MeshRenderer>().enabled = true;
            GameObject.Find("snowball" + i.ToString()).GetComponent<SphereCollider>().enabled = true;
            
        }
    }
    IEnumerator ClearEffect() {
        yield return new WaitForSeconds(2.0f);
        GameObject.Find("Image").GetComponent<Image>().enabled = true;
        GameObject.Find("Image").GetComponent<Imageskip>().enabled = true;
    }
        
    
}
