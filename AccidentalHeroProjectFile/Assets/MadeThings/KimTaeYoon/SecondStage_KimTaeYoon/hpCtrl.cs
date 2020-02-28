using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class hpCtrl : MonoBehaviour {


    public Text hpText;

    

    public void playerDamage()
    {
        int d = int.Parse(hpText.text) - 20;
        hpText.text = d.ToString();
        FireSnow.on = false;
        FireSnow.onTime = 0.0f;
        GameObject.Find("snowFight-J").SendMessage("Normalize");
    }
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (int.Parse(hpText.text) <= 0)
        { 
            SceneManager.LoadScene("GAMEOVER");
        }
	}


}
