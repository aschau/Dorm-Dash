using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class microControl : MonoBehaviour {
    //true == there is something on that space
    //false == there is nothing on that space
    private GameObject microwave;
    public Sprite open, closed;
    public bool door = true;
    public int swipes = 0;
    public bool space1 = false;
    public bool space2 = false;
    public bool space3 = false;
    public int spaces = 3;
    public bool held = false;
    void Awake()
    {
        microwave = GameObject.Find("Microwave");
        //opened = GameObject.Find("openMicrowave");
    }
	// Use this for initialization
	void Start () {
        //closed.SetActive(true);
        //opened.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void pushButton()
    {
        this.microwave.GetComponent<Image>().sprite = open;
        door = false;
    }

    public void startButton()
    {
        this.microwave.GetComponent<Image>().sprite = closed;
        door = true;
    }


}
