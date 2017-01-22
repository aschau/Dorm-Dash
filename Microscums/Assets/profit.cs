using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class profit : MonoBehaviour {
	private moneyControl totalMoney;

	void Awake()
	{
		totalMoney = GameObject.Find ("Money Control").GetComponent<moneyControl> ();

	}

	// Use this for initialization
	void Start () {
		this.GetComponent<Text>().text = "$"+ totalMoney.total.ToString ("0.00");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
