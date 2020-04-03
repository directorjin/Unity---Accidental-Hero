using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Invector.CharacterController;

public class HpSpControl : MonoBehaviour {

    public Text hpText;
    public AudioClip hitt;
    public Image spBar;
    bool gameOver = false;
    


    #region Sprint Varation
    bool canSprint = true;
    public bool isSprint = false;
    public float recoveryPeriod = 2f;
    #endregion

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        
        

        #region gameOver Control

        if (gameOver)
            StartCoroutine("gotitle");
        
        #endregion



        #region Sprint Control
        if (isSprint == false) //running is healing
        {
            spBar.fillAmount += 0.3f * Time.deltaTime;
        }
        

        if(GetComponent<vThirdPersonController>().isSprinting == true) //if user press the shift
        {
            if(spBar.fillAmount==0)
            {
                canSprint = false;
                isSprint = false;
                GetComponent<vThirdPersonInput>().sprintInput = KeyCode.None;
                GetComponent<vThirdPersonController>().isSprinting = false;
                spBar.color = Color.red;
                StartCoroutine("Playerexhaustion");

            }
            else
            {
                    isSprint = true;
            }
        
        }
        else //if user do not press the shift
        {
            isSprint = false;
        }


        if(canSprint == true && isSprint == true) //sprint use Sp
        {
            spBar.fillAmount -= 0.3f * Time.deltaTime;
        }
        #endregion


        


    }



    public void playerDamage()
    {
        int d = int.Parse(hpText.text) - 10;
        hpText.text = d.ToString();
        GetComponent<AudioSource>().PlayOneShot(hitt);

        if (d == 0)
        {
            gameOver = true;
        }

    }

    IEnumerator Playerexhaustion() //if user exhausted, then he can run after X second.
    {
        yield return new WaitForSeconds(recoveryPeriod);
        canSprint = true;
        spBar.color = Color.green;
        GetComponent<vThirdPersonInput>().sprintInput = KeyCode.LeftShift;
    }

    IEnumerator gotitle()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("GAMEOVER");
    }
    
    
}
