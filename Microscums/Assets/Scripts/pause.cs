using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour {
	private timer timerObject;
    private GameObject instructionImage;

	void Awake()
	{
		timerObject = GameObject.Find ("Timer").GetComponent<timer>();
        instructionImage = GameObject.Find("Instructions");
	}

	// Use this for initialization
	void Start () {
		this.gameObject.SetActive (false);
        this.instructionImage.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void toggleMenu()
	{
		this.gameObject.SetActive (!this.gameObject.activeSelf);
		if (this.gameObject.activeSelf) {
			timerObject.paused = true;
		} else {
			timerObject.paused = false;
		}
	}

    public void instructions()
    {
        this.instructionImage.gameObject.SetActive(!this.instructionImage.gameObject.activeSelf);
    }

	public void exit(){
		SceneManager.LoadScene ("mainMenu");
	}
}
