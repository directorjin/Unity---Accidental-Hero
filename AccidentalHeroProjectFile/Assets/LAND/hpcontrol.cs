using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class hpcontrol : MonoBehaviour {

    public Text hpText;
    public AudioClip hitt;
    bool tof = false;


    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (tof)
            StartCoroutine("gotitle");
       

    }

    public void playerDamage()
    {
        int d = int.Parse(hpText.text) - 20;
        hpText.text = d.ToString();
        GetComponent<AudioSource>().PlayOneShot(hitt);

        if (d == 0)
        {
            tof = true;
        }

    }


    IEnumerator gotitle()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("GAMEOVER");
    }
}
