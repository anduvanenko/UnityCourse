using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {

    //these all became global variables because we need Start and Update to be able to use the variables
    int max;
    int min;
    int guess;

    // Use this for initialization
    void Start () {
        StartGame();
	}

    void StartGame()
    {
        //these all became global variables because we need Start and Update to be able to use the variables
        max = 1000;
        min = 1;
        guess = 500;

        //the max is just so then it can reach to 1000 since it only gets to 999
        //with it being an int and doing binary chop, it gets between 999 and 1000 which is 999.5 so then it rounds down to 999
        //we add 1 or make int max = 1001 so then it can actually get up to 1000 when it hits 999.5

        print("======================");
        print("Welcome to Number Wizard");
        print("Pick a number in your head, but don't tell me!");



        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);

        print("Is the number higher or lower than " + guess + "?");
        print("Up = higher, down = lower, return = equal");

        max = max + 1;
    }

   
	
	// Update is called once per frame
	void Update () {
        //get keyboard input unity, what you can google
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //print("Up arrow pressed");
            //min = guess because we know that when the up arrow key is pressed, the min is going to be between
            //500 and 1000 now
            //guess = (max + min) /2 because guess is now halfway between 1000 and 500, so 750
            //called binary chop
            min = guess;
            NextGuess();
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            //print("Down arrow pressed");
            //when guessing 1000, both min and max will only go to 999. it's because it rounds down
            max = guess;
            NextGuess();
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Higher or lower than " + guess);
        print("Up = higher, down = lower, return = equal");
    }
}
