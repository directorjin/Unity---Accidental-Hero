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

    public AudioClip shakeSound; //new
    public Camera MainCamera; //new

    float dartspeed;
    float timertime;
    float rotationSpeed;
    public bool rotate_to_p;
    public bool run_to_p;
    

    float timer;
    
    int sequence;

    bool isdie;
    bool halfblood;
    float runspeed;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        sequence = 0;
        timer = 0f;
        dartspeed = 5f;
        timertime = 5f;
        rotationSpeed = 5f;
        rotate_to_p = true;
        run_to_p = false;
        isdie = false;
        halfblood = true;
        runspeed = 10f;
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
                    StartCoroutine("BlowpipeRangeAttack");
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

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Enter " + col.transform);

        if (col.transform.tag == "BossMap")
        {
            
            run_to_p = false;
            Instantiate(drop_it, transform.position + new Vector3(0, 13.0f, 0), transform.rotation);
            animator.SetBool("Run", false);
            StartCoroutine("BossDamage");
            
            //animator.SetTrigger("Take Damage");
            //GetComponent<AudioSource>().PlayOneShot(bosshit);
            //bosshpbar.fillAmount -= 0.15f;
        }

        if(col.transform.tag == "Player")
        {
            col.transform.SendMessage("playerDamage");
        }


    }

    IEnumerator BlowpipeRangeAttack()
    {
        float blowFirstWating = 0.5f;
        float blowLastWating = 0.3f;
        float blowLastWatingDart2 = 0.3f;
        
        animator.SetFloat("PipeAttackSpeed", 2f);

        yield return StartCoroutine(BlowpipeRangeAttackAction(blowFirstWating, blowLastWating, 0));
        yield return StartCoroutine(BlowpipeRangeAttackAction(blowFirstWating, blowLastWating, blowLastWatingDart2));
        yield return StartCoroutine(BlowpipeRangeAttackAction(blowFirstWating, blowLastWating, 0));

        if(!halfblood)
        {
            var temp = Random.Range(0, 3);
            while (temp == 0)
            {
                temp = Random.Range(0, 3);
            }
            sequence = temp;
            //Rage Mode is Random
        }
        else
        {
            sequence = 1;
        }

        rotate_to_p = true;
    }

    IEnumerator BlowpipeRangeAttackAction(float blowFirstWating, float blowLastWating, float blowLastWatingDart2)
    {
        Debug.Log("ee");
        rotate_to_p = true;
        animator.SetTrigger("Blowpipe Attack");
        yield return new WaitForSeconds(blowFirstWating);
        GameObject newdart = Instantiate(Dart, BlowPipe.transform.position, BlowPipe.transform.rotation) as GameObject;
        GetComponent<AudioSource>().PlayOneShot(blowpipesound);
        newdart.GetComponent<Rigidbody>().velocity = (Player_prefab.transform.position - newdart.transform.position) * dartspeed;
        rotate_to_p = false;
        yield return new WaitForSeconds(blowLastWating + blowLastWatingDart2);
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



        if (!halfblood)
        {

            var temp = Random.Range(0, 3);
            while (temp == 1)
            {
                temp = Random.Range(0, 3);
            }
            sequence = temp;
            
            //Rage Mode is Random
        }
        else
        {
            sequence = 2;
        }
        rotate_to_p = true;
    }

    IEnumerator RuntoPlayer()
    {
        

        GetComponent<AudioSource>().PlayOneShot(roaring);

        if (!halfblood)
        {
            runspeed = 20f;
        }

        rotate_to_p = false;
        animator.SetBool("Run", true);

        run_to_p = true;

        yield return new WaitForSeconds(2.5f);
        run_to_p = false;
        rotate_to_p = true;
        animator.SetBool("Run", false);

        if (!halfblood)
        {
            var temp = Random.Range(0, 3);
            while(temp==2)
            {
                temp = Random.Range(0, 3);
            }
            sequence = temp;
            //Rage Mode is Random
        }
        else
        {
            sequence = 0;
        }
        
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

    IEnumerator BossDamage()
    {
        MainCamera.GetComponent<CameraShaker>().ShakeCamera(0.8f);
        GetComponent<AudioSource>().PlayOneShot(shakeSound);
        
        yield return new WaitForSeconds(1.3f);
        animator.SetTrigger("Take Damage");
        GetComponent<AudioSource>().PlayOneShot(bosshit);
        bosshpbar.fillAmount -= 0.15f;
    }

}