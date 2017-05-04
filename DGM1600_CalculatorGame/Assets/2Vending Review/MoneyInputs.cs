using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoneyInputs : MonoBehaviour {

    public InputField money;
    public float MoneyToFloat ()
    {
        //print(money.text);
        //return 10;
        return float.Parse(money.text);
    }

}