using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour {
    public AudioClip gameoverSound;
    private float time = 0;
    int on = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(on == 1)
        {
            time = time + Time.deltaTime;

            if(time > 1.0f)
            {
                GetComponent<AudioSource>().PlayOneShot(gameoverSound);
                on = 0;
                StartCoroutine("scenego");

            }
        }
	}

    IEnumerator scenego()
    {
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene("TITLE");
    }
}
