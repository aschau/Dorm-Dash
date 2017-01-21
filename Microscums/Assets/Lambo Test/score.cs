using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    GameObject game;
    // Use this for initialization
    void Start()
    {
        game = GameObject.Find("GameControl");
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Text>().text = game.GetComponent<gameControl>().score.ToString();
    }
}
