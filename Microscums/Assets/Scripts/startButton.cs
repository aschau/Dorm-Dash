using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startButton : MonoBehaviour {
    GameObject closed, opened, control, food;
    GameObject[] foodItems;
    private bool isOpened = false;

    void Awake()
    {
        closed = GameObject.Find("closedMicrowave");
        opened = GameObject.Find("openedMicrowave");
        control = GameObject.Find("microwaveControl");
        food = GameObject.Find("Items");
        
    }
	// Use this for initialization
	void Start () {
        opened.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onClick()
    {
        if (isOpened)
        {
            closed.SetActive(true);
            opened.SetActive(false);
            control.GetComponent<microControl>().door = true;
            isOpened = false;
        }
        else
        {
            isOpened = true;
            closed.SetActive(false);
            opened.SetActive(true);
            control.GetComponent<microControl>().door = false;
            
            control.GetComponent<microControl>().swipes = 0;
        }
    }

}
