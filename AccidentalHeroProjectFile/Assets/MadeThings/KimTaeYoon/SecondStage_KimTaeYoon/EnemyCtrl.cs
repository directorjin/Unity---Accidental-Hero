using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour {
    public Transform[] points;
    public int nextIdx = 1;

    public float speed = 10.0f;
    public float damping = 5.0f;
    public float soundTime = 0.0f;
    public bool soundOn = false;

    public AudioClip attackSound;
    public Animator goblinAnim;
    private Transform playerTr;
    
  
    private Vector3 movePos;
    private bool isAttack = false;

    private void OnTriggerEnter(Collider coll)
    {
        if(coll.tag == "WAY_POINT")
        {
            nextIdx = (++nextIdx >= points.Length) ? 1 : nextIdx;
        }
    }

    // Use this for initialization
    void Start () {
        goblinAnim = GetComponent<Animator>();
        playerTr = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        if (gameObject.name == "1")
        {
            points = GameObject.Find("WayPointGroup").GetComponentsInChildren<Transform>();
        }
        if (gameObject.name == "2")
        {
            points = GameObject.Find("WayPointGroup2").GetComponentsInChildren<Transform>();
        }
        if (gameObject.name == "3")
        {
            points = GameObject.Find("WayPointGroup3").GetComponentsInChildren<Transform>();
        }

    }
	
	// Update is called once per frame
	void Update () {
        float dist = Vector3.Distance(transform.position, playerTr.position);
        if (soundOn == true)
        {
            soundTime = soundTime + Time.deltaTime;
            if (soundTime >= 1.2f)
            {
                soundTime = 0.0f;
                soundOn = false;
            }
        }
        

        if (dist <= 1.7f)
        {
            isAttack = true;
            transform.LookAt(playerTr);
            if(soundOn == false)
            {
                GetComponent<AudioSource>().PlayOneShot(attackSound);
                soundOn = true;
            }
            

        }

        else if(dist <= 10.0f) //얼마나 접근해야 반응할지
        {
            movePos = playerTr.position;
            isAttack = false;  
        }
        else
        {
            movePos = points[nextIdx].position;
            isAttack = false;
        }
        goblinAnim.SetBool("Walk", !isAttack);
        goblinAnim.SetBool("isAttack", isAttack);



        if (!isAttack)
        {
            Quaternion rot = Quaternion.LookRotation(movePos - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, rot, Time.deltaTime * damping);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        
    }
}
