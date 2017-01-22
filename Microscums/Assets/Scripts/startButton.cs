using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startButton : MonoBehaviour {
    GameObject closed, opened, control;

    void Awake()
    {
        closed = GameObject.Find("closedMicrowave");
        opened = GameObject.Find("openMicrowave");
        control = GameObject.Find("microwaveControl");
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onClick()
    {
        if (this.name == "startButton")
        {
            closed.SetActive(true);
            opened.SetActive(false);
            control.GetComponent<microControl>().door = true;
        }
        else
        {

            closed.SetActive(false);
            opened.SetActive(true);
            control.GetComponent<microControl>().door = false;
            control.GetComponent<microControl>().swipes = 0;
        }
    }
}
