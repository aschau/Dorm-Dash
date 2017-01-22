using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodButton : MonoBehaviour
{
    //public string itemName = "";
    GameObject item, space1, space2, space3, space12, space23, control;
    public static bool hotPocketButton, popcornButton, tvDinnerButton, ramenButton;
    public GameObject create, parent;
    public void Awake()
    {
       // itemName = this.name + "Button";
        space1 = GameObject.Find("First Space");
        space2 = GameObject.Find("Second Space");
        space3 = GameObject.Find("Third Space");
        space12 = GameObject.Find("FirstSecond Space");
        space23 = GameObject.Find("SecondThird Space");
        parent = GameObject.Find("Items");
        control = GameObject.Find("microwaveControl");
    }
    public void Start()
    {
        hotPocketButton = popcornButton = tvDinnerButton = ramenButton = false;
    }
	// Update is called once per frame
	void Update () {
		
	}

    public void onClick()
    {
        if (control.GetComponent<microControl>().door == false)
        {
            if (this.name == "cupNoodlesButton" && RestockManager.ramen>0)
            {

                if (control.GetComponent<microControl>().space1 == false)
                {
                    RestockManager.ramen -= 1; //decrease stock
                    ramenButton = true;

                    GameObject newObject = (GameObject)Instantiate(create, space1.transform.position, Quaternion.identity, parent.transform);
                    newObject.gameObject.GetComponent<foodItem>().occupied = 1;
                    control.GetComponent<microControl>().spaces -= 1;
                    control.GetComponent<microControl>().space1 = true;
                }
                else if (control.GetComponent<microControl>().space2 == false)
                {
                    RestockManager.ramen -= 1; //decrease stock
                    ramenButton = true;

                    GameObject newObject = (GameObject)Instantiate(create, space2.transform.position, Quaternion.identity, parent.transform);
                    newObject.gameObject.GetComponent<foodItem>().occupied = 2;
                    control.GetComponent<microControl>().spaces -= 1;
                    control.GetComponent<microControl>().space2 = true;
                }
                else if (control.GetComponent<microControl>().space3 == false)
                {
                    RestockManager.ramen -= 1; //decrease stock
                    ramenButton = true;

                    GameObject newObject = (GameObject)Instantiate(create, space3.transform.position, Quaternion.identity, parent.transform);
                    newObject.gameObject.GetComponent<foodItem>().occupied = 3;
                    control.GetComponent<microControl>().spaces -= 1;
                    control.GetComponent<microControl>().space3 = true;
                }
            }
            else if (this.name == "popcornButton" || this.name == "hotPocketButton")
            {
                if (this.name == "popcornButton" && RestockManager.popcorn>0)
                {
                    if (control.GetComponent<microControl>().space1 == false && control.GetComponent<microControl>().space2 == false)
                    {
                        RestockManager.popcorn -= 1; //decrease stock
                        popcornButton = true;

                        GameObject newObject = (GameObject)Instantiate(create, space12.transform.position, Quaternion.identity, parent.transform);
                        newObject.gameObject.GetComponent<foodItem>().occupied = 12;
                        control.GetComponent<microControl>().spaces -= 2;
                        control.GetComponent<microControl>().space2 = true;
                        control.GetComponent<microControl>().space1 = true;
                    }
                    else if (control.GetComponent<microControl>().space2 == false && control.GetComponent<microControl>().space3 == false)
                    {
                        RestockManager.popcorn -= 1; //decrease stock
                        popcornButton = true;

                        GameObject newObject = (GameObject)Instantiate(create, space23.transform.position, Quaternion.identity, parent.transform);
                        newObject.gameObject.GetComponent<foodItem>().occupied = 23;
                        control.GetComponent<microControl>().spaces -= 2;
                        control.GetComponent<microControl>().space2 = true;
                        control.GetComponent<microControl>().space3 = true;
                    }
                }
                if(this.name =="hotPocketButton" && RestockManager.hotPocket>0)
                {
                    if (control.GetComponent<microControl>().space1 == false && control.GetComponent<microControl>().space2 == false)
                    {
                        RestockManager.hotPocket -= 1; //decrease stock
                        hotPocketButton = true;

                        GameObject newObject = (GameObject)Instantiate(create, space12.transform.position, Quaternion.identity, parent.transform);
                        newObject.gameObject.GetComponent<foodItem>().occupied = 12;
                        control.GetComponent<microControl>().spaces -= 2;
                        control.GetComponent<microControl>().space2 = true;
                        control.GetComponent<microControl>().space1 = true;
                    }
                    else if (control.GetComponent<microControl>().space2 == false && control.GetComponent<microControl>().space3 == false)
                    {
                        RestockManager.hotPocket -= 1; //decrease stock
                        hotPocketButton = true;

                        GameObject newObject = (GameObject)Instantiate(create, space23.transform.position, Quaternion.identity, parent.transform);
                        newObject.gameObject.GetComponent<foodItem>().occupied = 23;
                        control.GetComponent<microControl>().spaces -= 2;
                        control.GetComponent<microControl>().space2 = true;
                        control.GetComponent<microControl>().space3 = true;
                    }
                }
            }
            else if (this.name == "tvDinnerButton" && RestockManager.tvDinner>0)
            {

                if (control.GetComponent<microControl>().spaces == 3)
                {
                    RestockManager.tvDinner -= 1; //decrease stock
                    tvDinnerButton = true;

                    GameObject newObject = (GameObject)Instantiate(create, space2.transform.position, Quaternion.identity, parent.transform);
                    newObject.gameObject.GetComponent<foodItem>().occupied = 123;
                    control.GetComponent<microControl>().spaces = 0;
                    control.GetComponent<microControl>().space1 = true;
                    control.GetComponent<microControl>().space2 = true;
                    control.GetComponent<microControl>().space3 = true;
                }
            }
        }

        //whatever happens when the button gets clicked
    }

}
