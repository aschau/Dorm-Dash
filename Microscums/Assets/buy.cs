using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buy : MonoBehaviour {
    moneyControl playerMoney;
    restocking amounts;
    Text totAmount, tempTotAmount;
    private float total = 0f;

    private float ramen = .50f;
    private float popcorn = 1f;
    private float hotPocket = 2f;
    private float tvdinner = 5f;
    private GameObject[] itemStocks;
    private GameObject restockMenu;
    public AudioSource buying;
    public AudioClip buy_item; 


    private int hotPocketAmount, ramenAmount, popcornAmount, tvdinnerAmount;
	// Use this for initialization
	void Awake () {
        buying = GameObject.Find("buy").GetComponent<AudioSource>(); 
        playerMoney = GameObject.Find("Money Control").GetComponent<moneyControl>();
        itemStocks = GameObject.FindGameObjectsWithTag("itemStock");
        totAmount = GameObject.Find("Total Money").GetComponent<Text>();
        tempTotAmount = GameObject.Find("Total Amount").GetComponent<Text>();
        restockMenu = GameObject.Find("Restock Menu");

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onClick()
    {
        buying.Play(); 
        totalAmount();
        playerMoney.total -= total;
		totAmount.text = "$" + playerMoney.total.ToString("0.00");
        RestockManager.hotPocket += hotPocketAmount;
        RestockManager.ramen += ramenAmount;
        RestockManager.popcorn += popcornAmount;
        RestockManager.tvDinner += tvdinnerAmount;
        restock();

        GameObject.Find("Hot Pocket").transform.FindChild("Amount").GetComponent<Text>().text = "0";
        GameObject.Find("Ramen").transform.FindChild("Amount").GetComponent<Text>().text = "0";
        GameObject.Find("Popcorn").transform.FindChild("Amount").GetComponent<Text>().text = "0";
        GameObject.Find("TV Dinner").transform.FindChild("Amount").GetComponent<Text>().text = "0";

        tempTotAmount.text = "$0";

        restockMenu.SetActive(false);
    }

    public void totalAmount()
    {
        total = 0;
        hotPocketAmount = int.Parse(GameObject.Find("Hot Pocket").transform.FindChild("Amount").GetComponent<Text>().text);
        if (hotPocketAmount > 0)
        {
            total += hotPocket * hotPocketAmount;
        }
        ramenAmount = int.Parse(GameObject.Find("Ramen").transform.FindChild("Amount").GetComponent<Text>().text);
        if (ramenAmount > 0)
        {
            total += ramen * ramenAmount;
        }
        popcornAmount = int.Parse(GameObject.Find("Popcorn").transform.FindChild("Amount").GetComponent<Text>().text);
        if (popcornAmount > 0)
        {
            total += popcorn * popcornAmount;
        }
        tvdinnerAmount = int.Parse(GameObject.Find("TV Dinner").transform.FindChild("Amount").GetComponent<Text>().text);
        if (tvdinnerAmount > 0)
        {
            total += tvdinner * tvdinnerAmount;
        }
    }

    public void restock()
    {
        foreach (GameObject item in this.itemStocks)
        {
            if (item.name == "Ramen")
            {
                item.transform.FindChild("Stock").GetComponent<Text>().text = RestockManager.ramen.ToString();
            }

            else if (item.name == "Popcorn")
            {
                item.transform.FindChild("Stock").GetComponent<Text>().text = RestockManager.popcorn.ToString();
            }
            else if (item.name == "Hot Pocket")
            {
                item.transform.FindChild("Stock").GetComponent<Text>().text = RestockManager.hotPocket.ToString();
            }
            else if (item.name == "TV Dinner")
            {
                item.transform.FindChild("Stock").GetComponent<Text>().text = RestockManager.tvDinner.ToString();
            }
        }
    }
}
