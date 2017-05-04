using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

    // Use this for initialization
    public List home;

    // Use this for initialization
    void Start()
    {
        print(home.myFavorites);
        //if print(home.Awake());
        home.Start();
    }

    void ButtonClick ()
    {
        print(home.myFavorites);
        home.ButtonClick();
    }
}
