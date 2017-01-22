using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestockManager : MonoBehaviour {

    //max values
    public static int tvDinner = 3;
    public static int hotPocket = 5;
    public static int ramen = 10;
    public static int popcorn = 5;

    void Awake()
    {
    }
	// Use this for initialization
	void Start () {
        //START WITH MAX CAPACITY FOR ALL ITEMS
        tvDinner = 3;
        hotPocket = 5;
        popcorn = 5;
        ramen = 10;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
