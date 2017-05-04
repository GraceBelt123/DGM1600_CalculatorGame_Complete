using UnityEngine;
using System.Collections;

public class VarsAndFunctions : MonoBehaviour {

    public string userName;
    private int health = 100;

	// Use this for initialization
	void Start () {
        string welcomeUser = "Welcome" + userName + "it's good to have you.";
        print("welcomeUser");
        string dadSaysNo = "yes";

        if(welcomeUser == "Dad")
        {
            string daySaysNo = "no";
        }
       
	}
	
	// Update is called once per frame
	void Update () {
        string welcomeUser = "Hello, your health is low. It's" + health;
        print(welcomeUser);
	}
}
