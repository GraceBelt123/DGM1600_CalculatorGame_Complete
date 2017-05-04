using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class SwitchStatement : MonoBehaviour
{

	Text gameWords;
	public static Text gameover;
	public Text youwon;
	int correctAnswersNeeded = 20;
	//Switch for input numbers.
	//ElseClause for to display YOU WON!!! or Game Over!!!
	//Perhaps, create ClickButton for numbers in another script. Maybe, including arrays and stuff things like that.
	void Start ()
	{
		gameover = GameObject.Find ("Game Over").GetComponent<Text> ();
		gameover.enabled = false;
	}
	//    public void ElseClause ()
	//    {
	//
	//    }

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "FallingNum") {
			print ("Collided");
			Timer.gameLost = true;
			gameover.enabled = true;
		}

//		if (col.gameObject.tag == "FallingNum1")
//		{
//			print ("Collided2");
//			youwon.enabled = true;
//		}
	}
	//		if (col.gameObject.tag == "UpNum")
	//		{
	//			print ("Correct");
	//			youwon.enabled = true;
	//		}
}
//}
//	void Switch (int numbers){

//		switch (numbers)
//		{
//		case 1:
//			numbers =
//		case 2:
//		case 3:
//		default:
//	}
//}

//		public void ButtonClick (){

//		foreach (Text numbers in characters){
//		print (numbers);
//		}
// }

