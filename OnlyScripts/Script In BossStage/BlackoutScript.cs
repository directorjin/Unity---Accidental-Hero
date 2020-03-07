using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackoutScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<RectTransform>().localScale -= new Vector3(0, 0.1f, 0);

        if (GetComponent<RectTransform>().localScale.y <= 0)
        {
            GetComponent<Image>().enabled = false;
            GameObject.Find("SPBar").GetComponent<Image>().enabled = true;
            GameObject.Find("SPText").GetComponent<Text>().enabled = true;
        }
    }
}