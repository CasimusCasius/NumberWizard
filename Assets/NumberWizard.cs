using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min = 1;
    int max = 1000;
    int guess = 501;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Witaj w Grze Number Wizard!");
        Debug.Log("Wybierz liczbę z zakresu");
        Debug.Log("Najmniejsza to: " + min);
        Debug.Log("Największa to: " + max);
        Debug.Log("Powiedz mi czy twoja liczba jest mniejsza czy większa od 500");
        Debug.Log("Do góry = Większa, Do Dołu = Mniejsza, Enter = Trafiłem");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Wcisnąłeś Do góry!");
            min = guess+1;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Wcisnąłeś Do dołu!");
            max = guess;
            Debug.Log(guess-1);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Wcisnąłeś Enter.");
            Debug.Log(guess);
        }
    }
}
