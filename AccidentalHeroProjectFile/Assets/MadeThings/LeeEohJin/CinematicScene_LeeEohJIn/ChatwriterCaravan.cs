using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ChatwriterCaravan : MonoBehaviour {
    private const float WAIT_TIME = 0.1f;

    private float waitTimer = 0.0f;
    private string wholeText;
    private string typewriterText = "";
    private int currentIndex = 0;
    public Text[] chatlist;
    private int chatcount;
    public Text nametext;
    public bool blackcheck = false;

    // Use this for initialization
    void Start () {
        chatcount = 0;
        wholeText = chatlist[chatcount].text;
    }

    // Update is called once per frame
    void Update() {
        waitTimer += Time.deltaTime;

        if (waitTimer > WAIT_TIME && currentIndex < wholeText.Length)
        {
            typewriterText += wholeText[currentIndex];
            waitTimer = 0.0f;
            ++currentIndex;
        }
         
        
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
        {

            textReset();
            chatcount++;
            if (chatcount == 0 || chatcount == 2)
                nametext.text = "나";
            else
                nametext.text = "캐러벤";
            if (chatcount >= chatlist.Length)
            {

                GameObject.Find("ImgCanvas").GetComponent<Canvas>().enabled = false;
                GameObject.Find("TextCanvas").GetComponent<Canvas>().enabled = false;
                blackcheck = true;
            }
            else
            {
                wholeText = chatlist[chatcount].text;
            }

        }
        if (blackcheck == true)
        {
            GameObject.Find("Black").GetComponent<RectTransform>().localScale += new Vector3(0, 0.1f, 0);
            if (GameObject.Find("Black").GetComponent<RectTransform>().localScale.y >= 11.0f)
                SceneManager.LoadScene(4);
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
