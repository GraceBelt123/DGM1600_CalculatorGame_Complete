using UnityEngine;
using System.Collections;

public class Functions : MonoBehaviour {
    int myAnimal = 10;

    // Use this for initialization
    void Start()
    {
        myAnimal = MultiplyByFive(myAnimal);
        Debug.Log(myAnimal);
    }
    int MultiplyByFive(int number) {
        int ret;
        ret = number * 5;
        return ret;
    }
       
    }
