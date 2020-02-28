using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Invector.CharacterController;

public class Pattern2 : MonoBehaviour {

    GameObject player;

    // Use this for initialization
    void Start () {
        StartCoroutine("DestroyPattern2");
        player = GameObject.Find("male");

    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<vThirdPersonController>().freeRunningSpeed = 1.5f;
            col.gameObject.GetComponent<vThirdPersonController>().freeSprintSpeed = 2.25f;
            Debug.Log("in");

        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<vThirdPersonController>().freeRunningSpeed = 3f;
            col.gameObject.GetComponent<vThirdPersonController>().freeSprintSpeed = 4.5f;
            Debug.Log("out");
            
        }
    }

    IEnumerator DestroyPattern2()
    {
        
        yield return new WaitForSeconds(7f);
        player.GetComponent<vThirdPersonController>().freeRunningSpeed = 3f;
        player.GetComponent<vThirdPersonController>().freeSprintSpeed = 4.5f;
        Debug.Log("compelete");
        Destroy(gameObject);
    }
}
