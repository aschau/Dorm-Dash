﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class anchorInit : MonoBehaviour {
    private RectTransform sidebar, microwave, items, pushButton, startButton, timer;
	
    void Awake()
    {
        this.sidebar = GameObject.Find("Right Sidebar").GetComponent<RectTransform>();
        this.microwave = GameObject.Find("Microwave").GetComponent<RectTransform>();
        this.items = GameObject.Find("Items").GetComponent<RectTransform>();
        this.pushButton = GameObject.Find("Push Button").GetComponent<RectTransform>();
        this.startButton = GameObject.Find("Start Button").GetComponent<RectTransform>();
        this.timer = GameObject.Find("Timer").GetComponent<RectTransform>();
    }
    
    // Use this for initialization
	void Start () {
        this.sidebar.anchorMin = new Vector2(0.8f, 0f);
        this.sidebar.anchorMax = new Vector2(1f, 1f);
        this.sidebar.offsetMax = Vector2.zero;
        this.sidebar.offsetMin = Vector2.zero;

        for (int i = 0; i < 5; i++)
        {
            RectTransform orderRT = this.sidebar.GetChild(i).GetComponent<RectTransform>();
            orderRT.anchorMin = new Vector2(.2f, 1 - (((float)i + 1f) / 4));
            orderRT.anchorMax = new Vector2(.8f, 1 - ((float)i / 4));
            orderRT.offsetMin = Vector2.zero;
            orderRT.offsetMax = Vector2.zero;
        }

        this.microwave.anchorMin = new Vector2(0.05f, 0.1f);
        this.microwave.anchorMax = new Vector2(0.75f, 0.8f);
        this.microwave.offsetMax = Vector2.zero;
        this.microwave.offsetMin = Vector2.zero;

        this.timer.anchorMin = new Vector2(0.3f, 0.8f);
        this.timer.anchorMax = new Vector2(0.5f, 1f);
        this.timer.offsetMax = Vector2.zero;
        this.timer.offsetMin = Vector2.zero;

        this.pushButton.anchorMin = new Vector2(0.65f, 0.25f);
        this.pushButton.anchorMax = new Vector2(0.98f, 0.39f);
        this.pushButton.offsetMax = Vector2.zero;
        this.pushButton.offsetMin = Vector2.zero;

        this.startButton.anchorMin = new Vector2(0.65f, .072f);
        this.startButton.anchorMax = new Vector2(0.98f, .205f);
        this.startButton.offsetMax = Vector2.zero;
        this.startButton.offsetMin = Vector2.zero;

        this.items.anchorMin = new Vector2(0.65f, 0.4f);
        this.items.anchorMax = new Vector2(0.98f, 0.95f);
        this.items.offsetMax = Vector2.zero;
        this.items.offsetMin = Vector2.zero;

        RectTransform itemRT = this.items.GetChild(0).GetComponent<RectTransform>();
        itemRT.anchorMin = new Vector2(0.05f, 0.55f);
        itemRT.anchorMax = new Vector2(0.45f, 0.95f);
        itemRT.offsetMax = Vector2.zero;
        itemRT.offsetMin = Vector2.zero;

        itemRT = this.items.GetChild(1).GetComponent<RectTransform>();
        itemRT.anchorMin = new Vector2(0.55f, 0.55f);
        itemRT.anchorMax = new Vector2(0.95f, 0.95f);
        itemRT.offsetMax = Vector2.zero;
        itemRT.offsetMin = Vector2.zero;


        itemRT = this.items.GetChild(2).GetComponent<RectTransform>();
        itemRT.anchorMin = new Vector2(0.05f, 0.05f);
        itemRT.anchorMax = new Vector2(0.45f, 0.45f);
        itemRT.offsetMax = Vector2.zero;
        itemRT.offsetMin = Vector2.zero;


        itemRT = this.items.GetChild(3).GetComponent<RectTransform>();
        itemRT.anchorMin = new Vector2(0.55f, 0.05f);
        itemRT.anchorMax = new Vector2(0.95f, 0.45f);
        itemRT.offsetMax = Vector2.zero;
        itemRT.offsetMin = Vector2.zero;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}