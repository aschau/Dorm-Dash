using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;
using System;

public class moneyControl : MonoBehaviour {
	private Text scoreText, totalMoney;
	public float total = 0f;

	void Awake()
	{
		DontDestroyOnLoad (this.gameObject);
		totalMoney = GameObject.Find ("Total Money").GetComponent<Text> ();

	}
	// Use this for initialization
	void Start () {
		totalAmount();

	}
	
	// Update is called once per frame
	void Update () {
	}

	public void totalAmount()
	{
		total = 100;
		totalMoney.text = "$"+ total.ToString ("0.00");
	}
}
