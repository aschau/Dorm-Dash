﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startGame(){
		SceneManager.LoadScene ("mainGame");
	}

	public void exitGame(){
		Application.Quit ();
	}
}