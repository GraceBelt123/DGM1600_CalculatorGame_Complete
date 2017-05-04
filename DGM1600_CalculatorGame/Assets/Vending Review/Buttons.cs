using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AnimalButtons : MonoBehaviour {

    //Function is Buttons or ButtonCLick.
    //Function is ButtonCLick.
    //Two things of an image and a button are a script and inside the button is text element. 
    //The one fuction a need to be public. 
    //Start will run at the start of the game no matter what, at least need to be public, and start is built into Unity. 
    //ButtonClick has a function, public void and OnButtonClick.
    // When it clicks an object which is for example animals.Add("Dog"); as a word pops up when it has been clicked. It's how to set up a button.
    //Moreover, it will print those animals.Add"    "); a word or whatever that is, if it's true or false. 
    //The fuction can be any name. 
    //The first step is to drag the script with that fuction onto the button. 
    //The item is equal to those animals (animals.Add("Dog"); which it has been set for print. 


    public List<string> animal;

    void Start ()
    {
        animal.Add("Dog");
        animal.Add("Cat");
        animal.Add("Frog");
        animal.Add("Hamster");
        animal.Add("Lizard");
        animal.Add("Kitty");
        animal.Add("Fish");
        animal.Add("Shrimp");
        animal.Add("Cow");
        animal.Add("Duck");
        animal.Add("Goose");
        animal.Add("Mice");
        animal.Add("Rat");
        animal.Add("Horse");
        animal.Add("Goat");
        animal.Add("Pig");
        animal.Add("Monkey");
        animal.Add("Rabbit");
        animal.Add("Rooster");
        animal.Add("Swan");
        animal.Add("Ox");
        animal.Add("Hawk");
        animal.Add("Eagle");
        animal.Add("Chicken");
        animal.Add("Boar");
        animal.Add("Snake");

    }

    public void ButtonClick()
    {
        foreach (string item in animal)
        {
            print(item);
        }

    }

}