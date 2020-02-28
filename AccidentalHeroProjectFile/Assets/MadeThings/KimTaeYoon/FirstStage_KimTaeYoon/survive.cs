using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class survive : MonoBehaviour {

    int playerHP; //체력
    //추움
    float coldingTime;
    float coldTime;
    //뜨거워짐
    public float hottingTime;
    float hotTime;
    //불타입
    bool isCold;

    public Text hpText1;

    public GameObject Fire;

    public Animator coldIn;

    public AudioClip needItem;
    public Text youNeedItem;
    private float textTime;
    
    //public Animator coldOut;


    private void OnTriggerEnter(Collider col)
    {
        
        if(col.tag == "Fire")
        {
			coldIn.SetBool("coldOut", true);
			coldIn.SetBool("coldIn", false);
            
            isCold = false;
            
        }
        else if(col.tag == "unFire")
        {
            if(Inventory.itemwooden == 1 && Inventory.itemmatch == 1)
            {
                Instantiate(Fire, col.transform.position, col.transform.rotation);
                col.SendMessage("burnAndDestroy");
            }
            else
            {
                GetComponent<AudioSource>().PlayOneShot(needItem);
                youNeedItem.enabled = true;
            }
        }
    }


    private void OnTriggerExit(Collider col)
    {
        if(col.tag == "Fire")
        {
			coldIn.SetBool("coldOut", false);
			coldIn.SetBool("coldIn", true);

            hottingTime = 0; //따뜻해지기전까지 시간 초기화
            isCold = true;

			 

            
        }
        
    }




    // Use this for initialization
    void Start () {
        coldIn.SetBool("coldOut", false);
		coldIn.SetBool("coldIn", true);

        playerHP = 100;
        hottingTime = 0;
        hotTime = 0;
        
        isCold = true;
	}
	
	// Update is called once per frame
	void Update () {
        //if(youNeedItem.enabled)
        //{
        //    textTime = textTime + Time.deltaTime;
        //    if(textTime > 3.0f)
        //    {
        //        textTime = 0;
        //        youNeedItem.enabled = false;
        //    }
        //}



        if (isCold == true)
        {
            if (coldingTime >= 1.0f)
            {
                if (coldTime >= 2.0f)
                {
                    playerHP = playerHP-10;
                    hpText1.text = playerHP.ToString();
                    coldTime = 0;
                }

                coldTime = Time.deltaTime + coldTime;

            }
            else
            {
                coldingTime = coldingTime + Time.deltaTime;
                
            }

        }



        else if (isCold == false)
        {
            if (hottingTime >= 1.0f) //몸뎁혀지기 대기시간 만족후
            {
                if (hotTime >= 0.5f)
                {
                    if (playerHP < 100) // 10이상 추가상승을 막기위한 제한
                    {
                        
                        playerHP = playerHP + 10;
                    }

                    hpText1.text = playerHP.ToString();
                    hotTime = 0;
                }
                hotTime = hotTime + Time.deltaTime;
            }


            else //몸뎁혀지기 시간이 아직 안지났을 경우
            {
                hottingTime = hottingTime + Time.deltaTime;
                
            }

        }


       //플레이어 게임오버 조건
        if (playerHP == 0)
        {
            SceneManager.LoadScene("GAMEOVER");
        }
	}
}
