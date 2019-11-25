using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;  // declaring and assigning a variable 
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
     int guess; 

    // Start is called before the first frame update
    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    public void OnPressHigher() {

        min = guess + 1; // defining "min" as "guess" it takes the variable data of 1 and replaces it with 500  
        NextGuess();

    }

    public void OnPressLower() {

        max = guess;
        NextGuess();//fuction used to call the repeated statements

    }

 

    void NextGuess()
    {

        guess = Random.Range(min , max+1);
        guessText.text = guess.ToString();

    }
}
