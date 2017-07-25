using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class foodButton : MonoBehaviour
{
    //public string itemName = "";
    GameObject item, space1, space2, space3, space12, space23, control;
    public static bool hotPocketButton, popcornButton, tvDinnerButton, ramenButton;
    public GameObject create, parent;
    private GameObject[] itemStocks;

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
        itemStocks = GameObject.FindGameObjectsWithTag("itemStock");

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
                    foreach (GameObject item in this.itemStocks)
                    {
                        if (item.name == "Ramen")
                        {
                            Debug.Log("RAMEN DECREASE CHANGE");
                            item.transform.Find("Stock").GetComponent<Text>().text = RestockManager.ramen.ToString();
                        }
                    }
                    ramenButton = true;

                    GameObject newObject = (GameObject)Instantiate(create, new Vector3(space1.transform.position.x, space1.transform.position.y + 27f, space1.transform.position.z) , Quaternion.identity, parent.transform);
                    newObject.gameObject.GetComponent<foodItem>().occupied = 1;
                    control.GetComponent<microControl>().spaces -= 1;
                    control.GetComponent<microControl>().space1 = true;
                }
                else if (control.GetComponent<microControl>().space2 == false)
                {
                    RestockManager.ramen -= 1; //decrease stock
                    foreach (GameObject item in this.itemStocks)
                    {
                        if (item.name == "Ramen")
                        {
                            item.transform.Find("Stock").GetComponent<Text>().text = RestockManager.ramen.ToString();
                        }
                    }
                    ramenButton = true;

                    GameObject newObject = (GameObject)Instantiate(create, new Vector3(space2.transform.position.x, space2.transform.position.y + 27f, space2.transform.position.z), Quaternion.identity, parent.transform);
                    newObject.gameObject.GetComponent<foodItem>().occupied = 2;
                    control.GetComponent<microControl>().spaces -= 1;
                    control.GetComponent<microControl>().space2 = true;
                }
                else if (control.GetComponent<microControl>().space3 == false)
                {
                    RestockManager.ramen -= 1; //decrease stock
                    foreach (GameObject item in this.itemStocks)
                    {
                        if (item.name == "Ramen")
                        {
                            item.transform.Find("Stock").GetComponent<Text>().text = RestockManager.ramen.ToString();
                        }
                    }
                    ramenButton = true;

                    GameObject newObject = (GameObject)Instantiate(create, new Vector3(space3.transform.position.x, space3.transform.position.y + 27f, space3.transform.position.z), Quaternion.identity, parent.transform);
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
                        foreach (GameObject item in this.itemStocks)
                        {
                            if (item.name == "Popcorn")
                            {
                                item.transform.Find("Stock").GetComponent<Text>().text = RestockManager.popcorn.ToString();
                            }
                        }
                        popcornButton = true;

                        GameObject newObject = (GameObject)Instantiate(create, new Vector3(space12.transform.position.x, space12.transform.position.y - 20f, space12.transform.position.z), Quaternion.identity, parent.transform);
                        newObject.gameObject.GetComponent<foodItem>().occupied = 12;
                        control.GetComponent<microControl>().spaces -= 2;
                        control.GetComponent<microControl>().space2 = true;
                        control.GetComponent<microControl>().space1 = true;
                    }
                    else if (control.GetComponent<microControl>().space2 == false && control.GetComponent<microControl>().space3 == false)
                    {
                        RestockManager.popcorn -= 1; //decrease stock
                        foreach (GameObject item in this.itemStocks)
                        {
                            if (item.name == "Popcorn")
                            {
                                item.transform.Find("Stock").GetComponent<Text>().text = RestockManager.popcorn.ToString();
                            }
                        }
                        popcornButton = true;

                        GameObject newObject = (GameObject)Instantiate(create, new Vector3(space23.transform.position.x, space23.transform.position.y - 20f, space23.transform.position.z), Quaternion.identity, parent.transform);
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
                        foreach (GameObject item in this.itemStocks)
                        {
                            if (item.name == "Hot Pocket")
                            {
                                item.transform.Find("Stock").GetComponent<Text>().text = RestockManager.hotPocket.ToString();
                            }
                        }
                        hotPocketButton = true;

                        GameObject newObject = (GameObject)Instantiate(create, new Vector3(space12.transform.position.x, space12.transform.position.y - 45f, space12.transform.position.z), Quaternion.identity, parent.transform);
                        newObject.gameObject.GetComponent<foodItem>().occupied = 12;
                        control.GetComponent<microControl>().spaces -= 2;
                        control.GetComponent<microControl>().space2 = true;
                        control.GetComponent<microControl>().space1 = true;
                    }
                    else if (control.GetComponent<microControl>().space2 == false && control.GetComponent<microControl>().space3 == false)
                    {
                        RestockManager.hotPocket -= 1; //decrease stock
                        foreach (GameObject item in this.itemStocks)
                        {
                            if (item.name == "Hot Pocket")
                            {
                                item.transform.Find("Stock").GetComponent<Text>().text = RestockManager.hotPocket.ToString();
                            }
                        }
                        hotPocketButton = true;

                        GameObject newObject = (GameObject)Instantiate(create, new Vector3(space23.transform.position.x, space23.transform.position.y - 45f, space23.transform.position.z), Quaternion.identity, parent.transform);
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
                    foreach (GameObject item in this.itemStocks)
                    {
                        if (item.name == "TV Dinner")
                        {
                            item.transform.Find("Stock").GetComponent<Text>().text = RestockManager.tvDinner.ToString();
                        }
                    }
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
