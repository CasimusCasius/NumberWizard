using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min;
    int max;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        min = 1;
        max = 1000;
        guess = 500;

        Debug.Log("Witaj w Grze Number Wizard!");
        Debug.Log("Wybierz liczbę z zakresu");
        Debug.Log("Najmniejsza to: " + min);
        Debug.Log("Największa to: " + max);
        Debug.Log("Powiedz mi czy twoja liczba jest mniejsza czy większa od " + guess);
        Debug.Log("Do góry = Większa, Do Dołu = Mniejsza, Enter = Trafiłem");        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Debug.Log("Wcisnąłeś Do góry!");
            min = guess + 1;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Debug.Log("Wcisnąłeś Do dołu!");
            if (guess > 1)
                max = guess - 1;
            else
                max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            //Debug.Log("Wcisnąłeś Enter.");
            Debug.Log("To liczba" + guess);
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (min + max) / 2;
        Debug.Log("Powiedz mi czy twoja liczba jest mniejsza czy większa od " + guess);
    }
}