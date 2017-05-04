using UnityEngine;
using System.Collections;

public class ifStatement : MonoBehaviour {

    public bool myBool = false;
	// Use this for initialization
	void Start () {

        if (myBool) 
        {
            print(true);
        }
        else 
        {
            print(false);
        }
	
	}
}
