using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class List : MonoBehaviour {
    public List<string> myFavorites;

    // Use this for initialization
    public void Start () {
        myFavorites.Add("Dog");
        myFavorites.Add("Book");
        myFavorites.Add("Mountain");
        myFavorites.Add("Plant");
        myFavorites.Add("Shoes");
    }

    public void ButtonClick()
    {
        foreach (string item in myFavorites)
        {
            print(item);
        }

    }
}
