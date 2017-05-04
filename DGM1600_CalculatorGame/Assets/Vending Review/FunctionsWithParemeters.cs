using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FunctionsWithParemeter : MonoBehaviour {

    public int health = 100;

    void Start()
    {
        AddHealth(50);
        print(health);
        AddHealth(25);
        print(health);
        ReplaceHealth(25, 20);
        print(health);
    }


    public void AddHealth(int _h)
    {
        health += _h;
    }


    public void ReplaceHealth(int _a, int _b)
    {
        health = _a + _b;
    }

    public void WelcomePlayer(string _name)
    {
        print("Welcome" +_name + ",it's good to have you");
    }

    public string userName;

    public void UpdateStringValue(string _s)
    {
        userName += _s;
        print(_s);
    }
        
}


    