using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
public class StaticVars : MonoBehaviour {

	public static int operation = 0;

	public static Text randNum1;
	public static Text randNum2;
	public static Text randNum3;
	public static Text randNum4;

	public static GameObject falling1;
	public static GameObject falling2;
	public static GameObject falling3;
	public static GameObject falling4;

	public static Vector3 num1Pos;
	public static Vector3 num2Pos;
	public static Vector3 num3Pos;
	public static Vector3 num4Pos;

	public static int result = 0;
	public static int firstNum = 0;
	public static int secondNum = 0;
	public static bool printedResult = false;
	public static int[] values;

	// Use this for initialization
	void Start () {
		randNum1 = GameObject.Find ("FallingNum1").GetComponent<Text>();
		randNum2 = GameObject.Find ("FallingNum2").GetComponent<Text>();
		randNum3 = GameObject.Find ("FallingNum3").GetComponent<Text>();
		randNum4 = GameObject.Find ("FallingNum4").GetComponent<Text>();
		values = new int[4];

		GenerateNum (randNum1);
		GenerateNum (randNum2);
		GenerateNum (randNum3);
		GenerateNum (randNum4);
		values [0] = int.Parse(randNum1.text);
		values [1] = int.Parse(randNum2.text);
		values [2] = int.Parse(randNum3.text);
		values [3] = int.Parse(randNum4.text);

		falling1 = randNum1.gameObject;
		falling2 = randNum2.gameObject;
		falling3 = randNum3.gameObject;
		falling4 = randNum4.gameObject;

		falling1.SetActive (false);
		falling2.SetActive (false);
		falling3.SetActive (false);
		falling4.SetActive (false);

		num1Pos = randNum1.gameObject.transform.position;
		num2Pos = randNum2.gameObject.transform.position;
		num3Pos = randNum3.gameObject.transform.position;
		num4Pos = randNum4.gameObject.transform.position;
	}
	

	public void GenerateNum(Text fallingNum)
	{
		fallingNum.text = Random.Range(1, 99).ToString();
		//randomNum.text = number.ToString();
	}
}
