using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class anchorInit : MonoBehaviour {
    private RectTransform sidebar, microwave, items, pushButton, startButton, timer, closedMicrowave, pauseButton, shopButton, restockBar;
	
    void Awake()
    {
        this.sidebar = GameObject.Find("Right Sidebar").GetComponent<RectTransform>();
        this.microwave = GameObject.Find("Microwave").GetComponent<RectTransform>();
        this.closedMicrowave = GameObject.Find("closedMicrowave").GetComponent<RectTransform>();
        this.items = GameObject.Find("Buttons").GetComponent<RectTransform>();
        this.pushButton = GameObject.Find("Push Button").GetComponent<RectTransform>();
        this.startButton = GameObject.Find("Start Button").GetComponent<RectTransform>();
        this.timer = GameObject.Find("Timer").GetComponent<RectTransform>();
        this.pauseButton = GameObject.Find("Pause Button").GetComponent<RectTransform>();
        this.shopButton = GameObject.Find("Restock Button").GetComponent<RectTransform>();
        this.restockBar = GameObject.Find("restockBar").GetComponent<RectTransform>();
    }
    
    // Use this for initialization
	void Start () {
        this.sidebar.anchorMin = new Vector2(0.8f, 0f);
        this.sidebar.anchorMax = new Vector2(1f, 1f);
        this.sidebar.offsetMax = Vector2.zero;
        this.sidebar.offsetMin = Vector2.zero;

        this.closedMicrowave.anchorMin = new Vector2(0f, 0f);
        this.closedMicrowave.anchorMax = new Vector2(1f, 1f);
        this.closedMicrowave.offsetMax = Vector2.zero;
        this.closedMicrowave.offsetMin = Vector2.zero;

        this.pauseButton.anchorMin = new Vector2(0f, .8f);
        this.pauseButton.anchorMax = new Vector2(.15f, 1f);
        this.pauseButton.offsetMax = Vector2.zero;
        this.pauseButton.offsetMin = Vector2.zero;

        this.shopButton.anchorMin = new Vector2(.6f, .8f);
        this.shopButton.anchorMax = new Vector2(.8f, 1f);
        this.shopButton.offsetMax = Vector2.zero;
        this.shopButton.offsetMin = Vector2.zero;

        //RectTransform orderRT = this.sidebar.GetChild(0).GetComponent<RectTransform>();
        //orderRT.anchorMin = new Vector2(.2f, 0.775f);
        //orderRT.anchorMax = new Vector2(.8f, 0.975f);
        //orderRT.offsetMin = Vector2.zero;
        //orderRT.offsetMax = Vector2.zero;

        //orderRT = this.sidebar.GetChild(1).GetComponent<RectTransform>();
        //orderRT.anchorMin = new Vector2(.2f, 0.525f);
        //orderRT.anchorMax = new Vector2(.8f, 0.725f);
        //orderRT.offsetMin = Vector2.zero;
        //orderRT.offsetMax = Vector2.zero;

        //orderRT = this.sidebar.GetChild(2).GetComponent<RectTransform>();
        //orderRT.anchorMin = new Vector2(.2f, 0.275f);
        //orderRT.anchorMax = new Vector2(.8f, 0.475f);
        //orderRT.offsetMin = Vector2.zero;
        //orderRT.offsetMax = Vector2.zero;

        //orderRT = this.sidebar.GetChild(3).GetComponent<RectTransform>();
        //orderRT.anchorMin = new Vector2(.2f, 0.025f);
        //orderRT.anchorMax = new Vector2(.8f, 0.225f);
        //orderRT.offsetMin = Vector2.zero;
        //orderRT.offsetMax = Vector2.zero;

        this.microwave.anchorMin = new Vector2(0.05f, 0.1f);
        this.microwave.anchorMax = new Vector2(0.75f, 0.8f);
        this.microwave.offsetMax = Vector2.zero;
        this.microwave.offsetMin = Vector2.zero;

        this.timer.anchorMin = new Vector2(0.3f, 0.8f);
        this.timer.anchorMax = new Vector2(0.5f, 1f);
        this.timer.offsetMax = Vector2.zero;
        this.timer.offsetMin = Vector2.zero;

        this.pushButton.anchorMin = new Vector2(0.69f, 0.03f);
        this.pushButton.anchorMax = new Vector2(0.99f, 0.23f);
        this.pushButton.offsetMax = Vector2.zero;
        this.pushButton.offsetMin = Vector2.zero;

        this.startButton.anchorMin = new Vector2(0.69f, .24f);
        this.startButton.anchorMax = new Vector2(0.99f, .46f);
        this.startButton.offsetMax = Vector2.zero;
        this.startButton.offsetMin = Vector2.zero;

        this.items.anchorMin = new Vector2(0.7f, 0.52f);
        this.items.anchorMax = new Vector2(0.98f, 0.96f);
        this.items.offsetMax = Vector2.zero;
        this.items.offsetMin = Vector2.zero;

        RectTransform itemRT = this.items.GetChild(0).GetComponent<RectTransform>();
        itemRT.anchorMin = new Vector2(0.0f, 0.55f);
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

        this.restockBar.anchorMin = new Vector2(0.7f, 0.52f);
        this.restockBar.anchorMax = new Vector2(0.98f, 0.96f);
        this.restockBar.offsetMax = Vector2.zero;
        this.restockBar.offsetMin = Vector2.zero;

        RectTransform restockRT = this.restockBar.GetChild(0).GetComponent<RectTransform>();
        restockRT.anchorMin = new Vector2(0.05f, 0.55f);
        restockRT.anchorMax = new Vector2(0.45f, 0.95f);
        restockRT.offsetMax = Vector2.zero;
        restockRT.offsetMin = Vector2.zero;

        restockRT = this.restockBar.GetChild(1).GetComponent<RectTransform>();
        restockRT.anchorMin = new Vector2(0.55f, 0.55f);
        restockRT.anchorMax = new Vector2(0.95f, 0.95f);
        restockRT.offsetMax = Vector2.zero;
        restockRT.offsetMin = Vector2.zero;


        restockRT = this.restockBar.GetChild(2).GetComponent<RectTransform>();
        restockRT.anchorMin = new Vector2(0.05f, 0.05f);
        restockRT.anchorMax = new Vector2(0.45f, 0.45f);
        restockRT.offsetMax = Vector2.zero;
        restockRT.offsetMin = Vector2.zero;


        restockRT = this.restockBar.GetChild(3).GetComponent<RectTransform>();
        restockRT.anchorMin = new Vector2(0.55f, 0.05f);
        restockRT.anchorMax = new Vector2(0.95f, 0.45f);
        restockRT.offsetMax = Vector2.zero;
        restockRT.offsetMin = Vector2.zero;


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
