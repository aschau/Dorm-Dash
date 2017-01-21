using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swipe : MonoBehaviour {
    public bool held = false;
    Vector3 originalPosition;
    GameObject score;
	// Use this for initialization
	void Start () {
        score = GameObject.Find("GameControl");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onPointerDown()
    {
        held = true;
        originalPosition = Input.mousePosition;
    }

    public void onPointerUp()
    {
        if (held == true)
        {
            if ((originalPosition.x)< Input.mousePosition.x)
            {
                held = false;
                score.GetComponent<gameControl>().score += 1;
            }
            else
            {
                held = false;
            }
        }
    }
}
