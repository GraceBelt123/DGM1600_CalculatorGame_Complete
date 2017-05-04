using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public float timer = 30;
	public Text timerText;
	public static bool startedGame = false;
	public GameObject startButtonObj;
	public Text winText;
	public static int matchCount = 0;
	public int matchesToWin = 3;
	public static bool gameWon = false;
	public static bool gameLost = false;
	// Use this for initialization
	void Start () {
		matchCount = 0;
		startedGame = false;
		winText.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (startedGame == true) 
		{
			print ("Matches: " + matchCount);
			if (matchCount >= matchesToWin && !gameLost) 
			{
				gameWon = true;
				winText.enabled = true;
				StaticVars.falling1.SetActive (false);
				StaticVars.falling2.SetActive (false);
				StaticVars.falling3.SetActive (false);
				StaticVars.falling4.SetActive (false);
			}
			//print (timer);
			timerText.text = System.Math.Round (timer, 2).ToString ();
			if (timer > 0 && !gameWon && !gameLost) {
				timer -= Time.deltaTime;
			}
			if (timer < 0) {
				timer = 0;
				if (!gameWon)
				{
					gameLost = true;
					SwitchStatement.gameover.enabled = true;
				}
			}
			if (gameWon || gameLost) 
			{
				timer = timer;
			}
		}
	}



	public void StartGameClicked()
	{
		startedGame = true;
		StaticVars.falling1.SetActive (true);
		StaticVars.falling2.SetActive (true);
		StaticVars.falling3.SetActive (true);
		StaticVars.falling4.SetActive (true);
		startButtonObj.SetActive (false);
	}
}
