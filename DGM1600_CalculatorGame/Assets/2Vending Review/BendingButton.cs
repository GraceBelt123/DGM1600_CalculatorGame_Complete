using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BendingButton : MonoBehaviour {

    public Text buttonLabel;

    void Start ()
    {
        buttonLabel.text = productName + "$" + productPrice;
       // transform.parent.name = productName + " " + productPrice;

    }
    public MoneyInputs moneyInput;
    public string productName = "Coke";
    public float productPrice = 1.5f;

    float VendProduct(float money)
    {
        float change = 0;
        if (money >= productPrice)
        {
            print("Vending" + productName + ".");
            change = money - productPrice;
        }
    
        return change;
       // return money - productPrice; 

    }

    public void ButtonClick ()
    {
        print("$" + VendProduct (moneyInput. MoneyToFloat()) + "is your change.");
    }
}
