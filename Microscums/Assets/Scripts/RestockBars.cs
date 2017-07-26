using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestockBars : MonoBehaviour {

    public static float decreaseby = 0;

    public static int hotPocket_max = RestockManager.hotPocket;
    public static int popcorn_max = RestockManager.popcorn;
    public static int ramen_max = RestockManager.ramen;
    public static int tvDinner_max = RestockManager.tvDinner;

    // Use this for initialization
    void Start () {

        //print("offset max: "+this.transform.GetComponent<RectTransform>().offsetMax.y);
        //this.transform.GetComponent<RectTransform>().offsetMax = new Vector2(
        //   this.transform.GetComponent<RectTransform>().offsetMax.x, -50);
        //print("lossy scale: "+this.transform.GetComponent<RectTransform>().lossyScale);
        //rectTransform.offsetMax = new Vector2(rectTransform.offsetMax.x, top);

    }
	
	// Update is called once per frame
	void Update () {
        //decreaseby += Time.deltaTime;
        
        if (this.name == "hotPocket" && foodButton.hotPocketButton==true)
        {
            
            print("decreased hotpocket");
            
            this.transform.GetComponent<RectTransform>().offsetMax = new Vector2(
                this.transform.GetComponent<RectTransform>().offsetMax.x, 
                this.transform.GetComponent<RectTransform>().offsetMax.y + 158/hotPocket_max);

            foodButton.hotPocketButton = false;
        }
        if (this.name == "ramen" && foodButton.ramenButton == true)
        {
            print("ramen");
            this.transform.GetComponent<RectTransform>().offsetMax = new Vector2(
                this.transform.GetComponent<RectTransform>().offsetMax.x, 
                this.transform.GetComponent<RectTransform>().offsetMax.y + 158 / ramen_max);

            foodButton.ramenButton = false;
        }
        if (this.name == "popcorn" && foodButton.popcornButton == true)
        {
            print("popcorn");
            this.transform.GetComponent<RectTransform>().offsetMax = new Vector2(
                this.transform.GetComponent<RectTransform>().offsetMax.x, 
                this.transform.GetComponent<RectTransform>().offsetMax.y + 158 / popcorn_max);

            foodButton.popcornButton = false;
        }
        if (this.name == "tvDinner" && foodButton.tvDinnerButton == true)
        {
            print("tvDinner");
            this.transform.GetComponent<RectTransform>().offsetMax = new Vector2(
                this.transform.GetComponent<RectTransform>().offsetMax.x,
                this.transform.GetComponent<RectTransform>().offsetMax.y + 158 / tvDinner_max);

            foodButton.tvDinnerButton = false;
        }
    }
}
