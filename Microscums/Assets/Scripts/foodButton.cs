using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodButton : MonoBehaviour
{
    public string itemName = "";
    GameObject item, space;
    public void Start()
    {
       // itemName = this.name + "Button";
        item = GameObject.Find(itemName);
        space = GameObject.Find("First Space");
    }
	// Update is called once per frame
	void Update () {
		
	}

    public void onClick()
    {
        GameObject.Instantiate(item);

        //whatever happens when the button gets clicked
    }

}
