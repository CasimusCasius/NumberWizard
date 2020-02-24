using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int min = 1;
        int max = 1000;

        Debug.Log("Witaj w Grze Number Wizard!");
        Debug.Log("Wybierz liczbę z zakresu");
        Debug.Log("Najmniejsza to: " + min);
        Debug.Log("Największa to: " + max);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
