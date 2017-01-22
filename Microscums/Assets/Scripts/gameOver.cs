using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour {
	public GameObject rootCanvas;

	void Awake()
	{
		//DontDestroyOnLoad (this.gameObject);
	}

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
		SceneManager.LoadScene ("mainMenu");
	}

}
