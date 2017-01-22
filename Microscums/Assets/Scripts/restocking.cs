using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;
using System;
public class restocking : MonoBehaviour {
	private Text amount, totAmount;
	private float total = 0f;
	private float ramen = .50f;
	private float popcorn =  1f;
	private float hotPocket = 2f;
	private float tvdinner = 5f;
    private moneyControl mc;

	// Use this for initialization
	void Awake()
	{
		amount = this.transform.FindChild("Amount").GetComponent<Text>();
		totAmount = GameObject.Find ("Total Amount").GetComponent<Text> ();
        mc = GameObject.Find("Money Control").GetComponent<moneyControl>();
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void buyItem()
	{
	}
	public void inStock()
	{
	}
	public int itemAmount()
	{
		return int.Parse (amount.text);
	}
	public void increaseItem()
	{
        if (this.name == "Popcorn")
        {
            totalAmount();
            if (RestockManager.popcorn + int.Parse(amount.text) < RestockBars.popcorn_max)
            {
                if (total + popcorn < mc.total)
                {
                    amount.text = (itemAmount() + 1).ToString();
                    totalAmount();
                    parseTotal();
                }
            }
        }

        else if (this.name == "Ramen")
        {
            if (RestockManager.ramen + int.Parse(amount.text) < RestockBars.ramen_max)
            {
                if (total + ramen < mc.total)
                {
                    amount.text = (itemAmount() + 1).ToString();
                    totalAmount();
                    parseTotal();
                }

            }
        }

        else if (this.name == "TV Dinner")
        {
            if (RestockManager.tvDinner + int.Parse(amount.text) < RestockBars.tvDinner_max)
            {
                if (total + tvdinner < mc.total)
                {
                    amount.text = (itemAmount() + 1).ToString();
                    totalAmount();
                    parseTotal();
                }

            }
        }

        else if (this.name == "Hot Pocket")
        {
            if (RestockManager.hotPocket + int.Parse(amount.text) < RestockBars.hotPocket_max)
            {
                if (total + hotPocket < mc.total)
                {
                    amount.text = (itemAmount() + 1).ToString();
                    totalAmount();
                    parseTotal();
                }

            }
        }

	}
	public void decreaseItem()
	{
		if (int.Parse(amount.text) > 0) {
			amount.text = (itemAmount () - 1).ToString ();
			totalAmount ();
            parseTotal();
		}
	}
	public void userAmount()
	{
	}

	public void totalAmount()
	{
		total = 0;
		int hotPocketAmount = int.Parse(GameObject.Find ("Hot Pocket").transform.FindChild("Amount").GetComponent<Text> ().text);
		if (hotPocketAmount > 0){
			total += hotPocket * hotPocketAmount; 
		}
		int ramenAmount = int.Parse(GameObject.Find ("Ramen").transform.FindChild("Amount").GetComponent<Text> ().text);
		if (ramenAmount > 0){
			total += ramen * ramenAmount; 
		}
		int popcornAmount = int.Parse(GameObject.Find ("Popcorn").transform.FindChild("Amount").GetComponent<Text> ().text);
		if (popcornAmount > 0){
			total += popcorn * popcornAmount; 
		}
		int tvdinnerAmount = int.Parse(GameObject.Find ("TV Dinner").transform.FindChild("Amount").GetComponent<Text> ().text);
		if (tvdinnerAmount > 0){
			total += tvdinner * tvdinnerAmount; 
		}
	}

    public void parseTotal()
    {
        totAmount.text = "$" + total.ToString("0.00");

    }
}

