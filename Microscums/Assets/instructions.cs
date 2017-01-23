using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instructions : MonoBehaviour {
	GameObject instruct;
	// Use this for initialization
	void Start () {
		this.instruct = GameObject.Find ("Instructions");
		this.instruct.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onClick()
	{
		this.instruct.gameObject.SetActive (!this.instruct.gameObject.activeSelf);
	}
}
