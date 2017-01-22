using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startButton : MonoBehaviour {
    GameObject closed, opened, control, food;
    GameObject[] foodItems;

    void Awake()
    {
        closed = GameObject.Find("closedMicrowave");
        //opened = GameObject.Find("openMicrowave");
        control = GameObject.Find("microwaveControl");
        food = GameObject.Find("Items");
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onClick()
    {
        if (this.name == "Start Button")
        {
            closed.SetActive(true);
            //opened.SetActive(false);
            control.GetComponent<microControl>().door = true;
        }
        else
        {

            closed.SetActive(false);
            //opened.SetActive(true);
            control.GetComponent<microControl>().door = false;
            if (food.transform.childCount > 0)
            {
                foreach (Transform foodChild in food.transform)
                {
                    foodChild.GetComponent<foodItem>().time -= control.GetComponent<microControl>().swipes;
                }
            }
            control.GetComponent<microControl>().swipes = 0;
        }
    }

}
