using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class endingscript : MonoBehaviour {

    public GameObject lighton;
    public AudioClip teleport;

    public Image finalblack;
    public Image fin1;
    public Image fin2;
    public Image fin3;

    bool step2 = false;
    bool onlyone = true;
    bool lightup = false;
    bool tof2 = false;
    int count1 = 0;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {

        if (onlyone)
        {
            StartCoroutine("step1");
            onlyone = false;
        }

        if (step2)
        {
            transform.position += transform.forward * -2f * Time.deltaTime;
            transform.localScale += new Vector3(0.3f, 0.3f, 0.3f) * Time.deltaTime;
        }

        if (lightup)
        {
            lighton.GetComponent<Light>().range += 4.0f * Time.deltaTime;

            Transform cameraman = transform.GetChild(2);
            cameraman.position += transform.right * -0.1f * Time.deltaTime;
        }

        if (tof2)
        {
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
            {
                count1++;
                if (count1 == 1)
                    fin1.gameObject.SetActive(true);
                if (count1 == 2)
                    fin2.gameObject.SetActive(true);
                if (count1 == 3)
                    fin3.gameObject.SetActive(true);
                if (count1 == 4)
                    SceneManager.LoadScene("TITLE");

            }
        }
    }


    IEnumerator step1()
    {
        yield return new WaitForSeconds(2.0f);

        Transform twinkle = transform.GetChild(1);
        twinkle.gameObject.SetActive(true);

        yield return new WaitForSeconds(3.0f);
        step2 = true;

        yield return new WaitForSeconds(5.2f);
        step2 = false;
        lightup = true;

        Transform twinkle2 = transform.GetChild(3);
        twinkle2.gameObject.SetActive(true);
        GetComponent<AudioSource>().PlayOneShot(teleport);

        yield return new WaitForSeconds(10.0f);

        Debug.Log("yes");

        finalblack.gameObject.SetActive(true);
        tof2 = true;

    }
    
}