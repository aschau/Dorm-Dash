using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;
using System;

public class gameOver : MonoBehaviour {
	public bool completeLevel;
	public string highScores;
	public float actualScore;
	public float temp;
	private moneyControl totalMoney;
	private GameObject[] scores;
	private bool completed = false;

	void Awake()
	{
		scores = GameObject.FindGameObjectsWithTag("score");
	}
	// Use this for initialization
	void Start () {
		actualScore = GameObject.Find ("Money Control").GetComponent<moneyControl> ().total;
		onLevelComplete ();
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

	void onLevelComplete(){
		completeLevel = true;

		for(int i = 3; i > -1; i--){
			Debug.Log(PlayerPrefs.GetFloat ("scores" + i) + "isgreaterthan" + actualScore);
			if (PlayerPrefs.GetFloat ("scores" + i) == null) {
				PlayerPrefs.SetFloat ("scores" + i, actualScore);
			}
			else if (PlayerPrefs.GetFloat ("scores" + i) < actualScore) {
				Debug.Log ("here" + i + PlayerPrefs.GetFloat ("scores" + i));
				if (i == 3) {
					PlayerPrefs.SetFloat ("scores" + i, actualScore);
					PlayerPrefs.Save ();
					Debug.Log("aaa " +PlayerPrefs.GetFloat ("scores" + i));
				} else {
					Debug.Log("bbb " +PlayerPrefs.GetFloat ("scores" + i));
					temp = PlayerPrefs.GetFloat ("scores" + i);
					PlayerPrefs.SetFloat ("scores" + i, actualScore);
					PlayerPrefs.SetFloat ("scores" + (i + 1), temp);
					PlayerPrefs.Save ();
				}
			}
		}

		for (int i=3; i > -1; i--)
		{
			if (scores [i].name == "First HS") {
				scores [i].GetComponent<Text> ().text = "$"+ PlayerPrefs.GetFloat("scores"+0).ToString("0.00");
			}
			if (scores [i].name == "Second HS") {
				scores [i].GetComponent<Text> ().text = "$"+ PlayerPrefs.GetFloat("scores"+1).ToString("0.00");
			}
			if (scores [i].name == "Third HS") {
				scores [i].GetComponent<Text> ().text = "$"+ PlayerPrefs.GetFloat("scores"+2).ToString("0.00");
			}
			if (scores [i].name == "Fourth HS") {
				scores [i].GetComponent<Text> ().text = "$"+ PlayerPrefs.GetFloat("scores"+3).ToString("0.00");
			}

		}
	}


}
