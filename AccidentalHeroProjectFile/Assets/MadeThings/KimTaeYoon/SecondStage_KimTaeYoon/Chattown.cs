using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Chattown : MonoBehaviour
{
    private const float WAIT_TIME = 0.1f;

    private float waitTimer = 0.0f;
    private string wholeText;
    private string typewriterText = "";
    private int currentIndex = 0;
    public Text[] chatlist;
    private int chatcount;
    
    public bool blackcheck = false;
    public GameObject[] goblin;
    // Use this for initialization
    void Start()
    {
        chatcount = 0;
        wholeText = chatlist[chatcount].text;
    }

    // Update is called once per frame
    void Update()
    {
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
        if (chatcount == 2)
        {
            for (int i = 0; i < 3; i++)
            {
                goblin[i].GetComponent<Animator>().SetBool("Run", true);

            }
            goblin[0].transform.position = Vector3.MoveTowards(goblin[0].transform.position,  new Vector3(170,0, goblin[0].transform.position.z), 10 * Time.deltaTime);
            goblin[1].transform.position = Vector3.MoveTowards(goblin[1].transform.position,  new Vector3(170, 0, goblin[1].transform.position.z), 10 * Time.deltaTime);
            goblin[2].transform.position = Vector3.MoveTowards(goblin[2].transform.position,  new Vector3(170, 0, goblin[2].transform.position.z), 10 * Time.deltaTime);
        }
        if (blackcheck == true)
        {
            GameObject.Find("Black").GetComponent<RectTransform>().localScale += new Vector3(0, 0.1f, 0);
            if (GameObject.Find("Black").GetComponent<RectTransform>().localScale.y >= 11.0f)
                SceneManager.LoadScene(5);
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

