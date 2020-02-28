using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Imageskip : MonoBehaviour {
    public Image[] Imglist;
    int current;
    
    public int sceneindex;
	// Use this for initialization
	void Start () {
        current = 0;
        
        Imglist[current].GetComponent<Image>().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
        {
            if (current >= Imglist.Length)
            {
                
                SceneManager.LoadScene(sceneindex);

            }
            else
            {
               
                Imglist[current].GetComponent<Image>().enabled = false;
                current++;
                if(current<Imglist.Length)
                Imglist[current].GetComponent<Image>().enabled = true;
                
            }
        }

    }
}
