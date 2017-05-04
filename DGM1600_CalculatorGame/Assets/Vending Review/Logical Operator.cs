using UnityEngine;
using System.Collections;

public class LogicalOperators : MonoBehaviour
{
//The three logical operators are ||, ! and &&.
//The one of logical operators is double-ampersand operator, and the two combined are conditions being met, if it's testing true or false. 
//If one or another statment can be true, either or can be true that if it's both false. The statement is false. 
//If string1 or string2 is equal to Thing 1 or 2, then there's a space. 
//IF the next statement a logicalOperators, meaning string 1 or two. 
//&& is and. 
//== is equal.
// || is non-zero and a condition. 
//!= is false I think. 
//public string string1; or string2; is attached to string1 or string2 == "Thing 1" or "Thing 2."

    // Use this for initialization
    void Start() { }

    public string string1;
    public string string2;

    //Use this for initialization
    public void OnButtonClick()
    {
        if (string1 == "Thing 1" && string2 == "Thing 2")
        {
            print("These things are quiet time.");

        }

        if (string1 == "Thing 1" || string2 == "Thing 2")
        {
            print("It's fun to have fun if you know what to do.");
        }
        //!= is shows false, not true I think. 
        if (string1 != "Thing 1" && string2 != "Thing 2")
        {
            print("Oh What a shame, what a shame, what a shame.");
        }
        //== is shows true, not false I think. 
        if (string1 == "Thought 1" || string2 == "Thing 2")
        {
            print("Yup, it would be great.");
        }
        if (string1 != "Thing 1" && string2 != "Thing 2")
        {
            print("Honest, what a bad day.");
        }
        if (string1 == "Thing 1" && string2 == "Thing 2")
        {
            print("What a day, what a day, what a day.");
        }
        if (string1 == "Thing 1" && string2 == "Thing 2")
        {
            print("What a good luck, what a good luck, what a good luck.");
        }
        if (string1 != "Thing 1" && string2 != "Thing 2")
        {
            print("Ride a bad day!");
        }
        if (string1 == "Thing 1" && string2 == "Thing 2")
        {
            print("Ride a good day!");
        }
        if (string1 == "Thing 1" && string2 == "Thing 2")
        {
            print("Good day, good day, good day.");
        }
        if (string1 == "Thing1" && string2 == "Thing 2")
        {
            print("Lucky day, lucky day, lucky day!");
        }
        if (string1 == "Thing 1" && string2 == "Thing 2")
        {
            print("what a nice, what a nice, what a nice!");
        }
        if (string1 != "Thing 1" && string2 == "Thing 2")
        {
            print("Drowning day.");
        }
        if (string1 == "Thing 1" && string2 == "Thing 2")
        {
            print("Hello day, hello day!");
        }
        if (string1 == "Thing 1" && string2 == "Thing 2")
        {
            print("Sure, why not. Sure, why not.");
        }

    }
}
