using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Invector.CharacterController;
using UnityEngine.SceneManagement;


public class FireSnow : MonoBehaviour {
    public GameObject bulletPre;
    public Text trapText;
    public Text trapText2;
    public static bool on = false;
    public static float onTime = 0.0f;

    Vector3 charForm;

    public int count = 0;

    private float textTime = 0.0f;
    public AudioClip getSound;
    public AudioClip dontSound;
    
    bool bulletOn = false; //상자를 먹어야 활성화
    bool bulletReroad = false; //던지고 있는 도중
    float bulletTime = 0.0f;

    public void Normalize()
    {
        vThirdPersonInput vt = gameObject.GetComponentInParent<vThirdPersonInput>();

        vt.enabled = true;
        vThirdPersonController vc = gameObject.GetComponentInParent<vThirdPersonController>();
        vc.enabled = true;
        trapText2.enabled = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "chest")
        {
            if(bulletOn==false)
            {
                GetComponent<AudioSource>().PlayOneShot(getSound);
                Destroy(other.gameObject);
                bulletOn = true;
                
                //////////////////////////////////


            }
            else if(bulletOn==true)
            {
                GetComponent<AudioSource>().PlayOneShot(dontSound);
                trapText.enabled = true;
            }
            
        }
    }
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(on==true)
        {
            trapText2.enabled = true;
            vThirdPersonInput vt = gameObject.GetComponentInParent<vThirdPersonInput>();
            
            vt.enabled = false;
            vThirdPersonController vc = gameObject.GetComponentInParent<vThirdPersonController>();
            vc.enabled = false;

            GameObject.Find("male").transform.position = charForm;
            

            onTime = onTime + Time.deltaTime;
            if(onTime > 2.0f)
            {
                GameObject bullet = Instantiate(bulletPre, transform.position, transform.rotation);
                bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 10.0f);
                on = false;
                onTime = 0.0f;
                GameObject.Find("male").transform.position = charForm;
                vt.enabled = true;
                vc.enabled = true;
                trapText2.enabled = false;
                bulletOn = false;
                bulletReroad = false;
            }
        }

        if (trapText.enabled == true)
        {
            textTime = textTime + Time.deltaTime;

            if(textTime >= 3.0f)
            {
                trapText.enabled = false;
                textTime = 0;
            }
        }

        if(bulletReroad == false)
        {
            bulletTime = bulletTime + Time.deltaTime;


            if (bulletTime >= 2.0f)
            {
                bulletReroad = true;
                bulletTime = 0;
            }

        }
        

        if (Input.GetButtonDown("Fire1") && bulletReroad == true && bulletOn == true)
        {
            charForm = GameObject.Find("male").gameObject.transform.position;

            on = true;
            
            
        }
        
        if (count == 3)
        {
            GameObject.Find("blackgo").GetComponent<Image>().enabled = true;
            GameObject.Find("blackgo").GetComponent<Imageskip>().enabled = true;
        }
    }
}
