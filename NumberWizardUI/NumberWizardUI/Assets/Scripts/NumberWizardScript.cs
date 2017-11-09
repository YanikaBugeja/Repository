using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class NumberWizardScript : MonoBehaviour {
    int min = 0;
    int max = 0;
    int guess = 0; //Random Number
    int numGuess = 5;
    int currentGuess = 0;

    public Text myGuess;



    // Use this for initialization
    void Start()
    {
        StartGame(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           
           min = guess + 1;
           NextGuess();
 
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartGame();
        }
    }

    void StartGame()
    {
        min = 1;
        max = 1000;
  
        NextGuess();
        
    }

    void NextGuess()
    {
        guess =  Random.Range(min,(max +1));
        myGuess.text = guess.ToString();

        if (currentGuess == numGuess)
        {
            SceneManager.LoadScene("Win");
        }

       
    }

    public void GuessHigher ()
    {
        min = guess + 1;
        currentGuess++;
        NextGuess();
    }
    public void GuessLower()
    {
        max = guess;
        currentGuess++;
        NextGuess();
    }
    public void Correct()
    {
        SceneManager.LoadScene("Lose");
    }

    

}
