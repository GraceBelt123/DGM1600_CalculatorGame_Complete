using UnityEngine;
using System.Collections;

public class Access : MonoBehaviour {

    public Scrope home;

	// Use this for initialization
	void Start () {
        print(home.owner);
        //if print(home.Awake());
        home.Awake();
    }
		
}
