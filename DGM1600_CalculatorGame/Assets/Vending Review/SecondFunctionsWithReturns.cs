using UnityEngine;
using System.Collections;

public class SecondFunctionsWithReturns : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject firstPlayer;

    public string[] deepThoughts;
    public int i = 0;

    GameObject ChooseFirstPlayer()
    {
        int randNum = Random.Range(1, 4);


        switch (randNum)
        {
            case 1:
                return player1;

            case 2:
                return player2;

            default:
                return player3;
        }
    }

    string Messages ()
    {
        if (i >= deepThoughts.Length)
        {
            i = 0;
        }
        return(deepThoughts[i++]);

    }

    public void OnButtonClick ()
    {
        print(Messages());
    }
    void Start () 
        {
             firstPlayer = ChooseFirstPlayer();
        }
    }