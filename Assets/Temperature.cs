using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    float originalFahrenheit = 0.5f;
    float Celcius;
    double calculateFahrenheit;
    // Start is called before the first frame update
    void Start()
    {
        Celcius = (originalFahrenheit - 32) / 9 * 5;
        calculateFahrenheit = (Celcius * 9) / 5 + 32;

        Debug.Log("originalFahrenheit : " + originalFahrenheit);
        Debug.Log("Celcius : " + Celcius);
        Debug.Log("calculate Fahrenheit : " +calculateFahrenheit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
