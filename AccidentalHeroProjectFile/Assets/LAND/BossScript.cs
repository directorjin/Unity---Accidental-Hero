using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossScript : MonoBehaviour {

    private Animator animator;

    public GameObject BlowPipe;
    public GameObject Dart;
    public GameObject Player_prefab;
    public GameObject Spell;
    public GameObject patt2;
    public GameObject drop_it;
    public GameObject bgm_;

    public Image bosshpbar;

    public AudioClip Magic;
    public AudioClip bosshit;
    public AudioClip bossdie;
    public AudioClip roaring;
    public AudioClip blowpipesound;

    float dartspeed = 15f;
    float timertime = 5f;
    float rotationSpeed = 5f;
    public bool rotate_to_p = true;
    public bool run_to_p = false;
    

    float timer = 0f;
    
    int sequence = 0;

    bool isdie = false;
    bool halfblood = true;
    float runspeed = 10f;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (rotate_to_p)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Player_prefab.transform.position - transform.position), rotationSpeed * Time.deltaTime);
        }

        if(run_to_p)
        {
            transform.position += transform.forward * Time.deltaTime * runspeed;
        }

        if (halfblood)
        {
            if (timer >= timertime && isdie == false)
            {
                if (sequence == 0)
                    StartCoroutine("BlowpipeRangeAttack");
                else if (sequence == 1)
                    StartCoroutine("CastSpell");
                else if (sequence == 2)
                    StartCoroutine("RuntoPlayer");

                timer = 0f;
            }
        }

        if(!halfblood)
        {
            if (timer >= timertime && isdie == false)
            {
                if (sequence == 0)
                    StartCoroutine("CastSpell");
                else if (sequence == 1)
                    StartCoroutine("CastSpell");
                else if (sequence == 2)
                    StartCoroutine("RuntoPlayer");

                timer = 0f;
            }
        }

        if (bosshpbar.fillAmount <= 0 && isdie == false) 
        {
            run_to_p = false;
            StartCoroutine("isDie");
            
        }

        if (bosshpbar.fillAmount <= 0.5f && halfblood)
        {
            timertime = 3f;
            halfblood = false;
            bgm_.transform.SendMessage("pattern4");
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        Debug.Log("Enter " + coll.transform);

        if (coll.transform.tag == "BossMap")
        {
            //Debug.Log("bump!");
            run_to_p = false;
            Instantiate(drop_it, transform.position + new Vector3(0, 13.0f, 0), transform.rotation);
            animator.SetBool("Run", false);
            animator.SetTrigger("Take Damage");
            GetComponent<AudioSource>().PlayOneShot(bosshit);
            bosshpbar.fillAmount -= 0.1f;
        }

        if(coll.transform.tag == "Player")
        {
            coll.transform.SendMessage("playerDamage");
        }


    }
   
    IEnumerator BlowpipeRangeAttack()
    {
        rotate_to_p = false;


        animator.SetTrigger("Blowpipe Range Attack");

        yield return new WaitForSeconds(0.9f);
        GameObject newdart = Instantiate(Dart, BlowPipe.transform.position, BlowPipe.transform.rotation ) as GameObject;
        GetComponent<AudioSource>().PlayOneShot(blowpipesound);
        newdart.GetComponent<Rigidbody>().velocity = ((BlowPipe.transform.up * 5.5f) + (BlowPipe.transform.right * -1f)) * dartspeed;

        yield return new WaitForSeconds(0.7f);
        GameObject newdart2 = Instantiate(Dart, BlowPipe.transform.position, BlowPipe.transform.rotation) as GameObject;
        GetComponent<AudioSource>().PlayOneShot(blowpipesound);
        newdart2.GetComponent<Rigidbody>().velocity = ((BlowPipe.transform.up * 5.5f) + (BlowPipe.transform.right * -1f)) * dartspeed;

        yield return new WaitForSeconds(0.3f);
        GameObject newdart3 = Instantiate(Dart, BlowPipe.transform.position, BlowPipe.transform.rotation) as GameObject;
        GetComponent<AudioSource>().PlayOneShot(blowpipesound);
        newdart3.GetComponent<Rigidbody>().velocity = ((BlowPipe.transform.up * 5.5f) + (BlowPipe.transform.right * -1f)) * dartspeed;


        bosshpbar.fillAmount -= 0.03f;
        rotate_to_p = true;

        sequence = 1;
    }

    IEnumerator CastSpell()
    {
        animator.SetTrigger("Cast Spell");
        GetComponent<AudioSource>().PlayOneShot(Magic);
        yield return new WaitForSeconds(0.6f);

        Instantiate(Spell, BlowPipe.transform.position, BlowPipe.transform.rotation);
        yield return new WaitForSeconds(0.4f);
        Instantiate(patt2, Player_prefab.transform.position, Player_prefab.transform.rotation);


        if(!halfblood)
        {
            yield return new WaitForSeconds(0.5f);
            Instantiate(patt2, Player_prefab.transform.position, Player_prefab.transform.rotation);
        }

        bosshpbar.fillAmount -= 0.03f;

        sequence = 2;
        
    }

    IEnumerator RuntoPlayer()
    {
        //if (true)
        //    animator.SetBool("Run", true);

        GetComponent<AudioSource>().PlayOneShot(roaring);

        if (!halfblood)
            runspeed = 20f;

        rotate_to_p = false;
        animator.SetBool("Run", true);

        run_to_p = true;

        yield return new WaitForSeconds(3.0f);
        run_to_p = false;
        rotate_to_p = true;
        animator.SetBool("Run", false);

        bosshpbar.fillAmount -= 0.03f;

        sequence = 0;
    }
        
    IEnumerator isDie()
    {

        isdie = true;
       

        animator.SetBool("Die", true);
        run_to_p = false;
        GetComponent<AudioSource>().PlayOneShot(bossdie);
        Destroy(gameObject, 4.0f);

        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("ending");

    }
}