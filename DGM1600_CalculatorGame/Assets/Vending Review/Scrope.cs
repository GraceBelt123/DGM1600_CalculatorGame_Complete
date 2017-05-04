using UnityEngine;
using System.Collections;

public class Scrope : MonoBehaviour {
    //iphone is owner's and named "Joe" or others a give of names. 
    //

    public string owner = "Bob";
    
    
	// Use this for initialization
	public void Awake () {
        
        string iphone = "Joe";
        print(iphone);
        print(owner);

    }
	
	// Update is called once per frame
	void Start () {
        string ipad = "Frank";
        print(ipad);
        print(owner);

    }
}
