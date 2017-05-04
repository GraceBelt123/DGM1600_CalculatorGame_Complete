using UnityEngine;
using System.Collections;

public class VoidFunctions : MonoBehaviour {
    int num1 = 5;
    int num2 = 3;
    public int temp = 8;
   

    // Use this for initialization
    public void AddNumbers() {
        int sum;
        sum = num1 + num2;
        print(sum);
    }

    public void ConvertFtoC()
    {
       float newtemp = (temp - 32) * 5 / 9;
        print(newtemp);

    }

    public void ConvertFtocC()
    {
        float newtemp = (temp * 9 / 5) + 32;
        print(newtemp);
    }

}
