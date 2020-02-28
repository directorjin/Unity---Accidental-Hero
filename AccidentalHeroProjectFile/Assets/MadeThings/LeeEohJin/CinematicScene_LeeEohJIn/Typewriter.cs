using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Typewriter : MonoBehaviour {
    private const float WAIT_TIME = 0.1f;

    private float waitTimer = 0.0f;
    private string wholeText ;
    private string typewriterText = "";
    private int currentIndex = 0;
    public Text[] chatlist;
    private int chatcount;

    // Use this for initialization
    void Start () {
        chatcount = 0;
        wholeText = chatlist[chatcount].text;
	}
	
	// Update is called once per frame
	void Update () {
        waitTimer += Time.deltaTime;

        if (waitTimer > WAIT_TIME && currentIndex < wholeText.Length)
        {
            typewriterText += wholeText[currentIndex];
            waitTimer = 0.0f;
            ++currentIndex;
        }
        if (Input.GetKeyDown(KeyCode.Return)||Input.GetMouseButtonDown(0))
            {

                textReset();
                chatcount++;
                if (chatcount >= chatlist.Length)
                {
                    GameObject.Find("coldImage").GetComponent<Image>().enabled = true;
                GameObject.Find("woodImage").GetComponent<Image>().enabled = true;
                GameObject.Find("matchImage").GetComponent<Image>().enabled = true;
                GameObject.Find("ImgCanvas").SetActive(false);
                    GameObject.Find("TextCanvas").SetActive(false);
                }
                else
                {
                wholeText = chatlist[chatcount].text;
                } 
            
            }
        GetComponent<Text>().text = typewriterText;
    }
    void textReset()
    {
        waitTimer = 0.0f;
        typewriterText = "";
        currentIndex = 0;
    }
  
}
