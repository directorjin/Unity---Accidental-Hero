using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropField : MonoBehaviour
{
    public GameObject playerbody;
    Vector3 playstart;
    // Use this for initialization
    void Start()
    {

        playstart = playerbody.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player" )
        {
            col.transform.position = playstart;
            GameObject.Find("clear").SendMessage("CollectReset");
            
        }
    }
}
