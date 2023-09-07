using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour
{
    private void Start()
    {

        //CalculateTwoNumbers();
        //CalculateUnknownNumbers(30, 22);

        //float sum = returnTwoNumbers();
        //Debug.Log("The sum is: " + sum);

        Debug.Log($"The sum is: {CalculateSum(10, 20)}");

    }

    // a function that doesn't return a value and doesn't take parameters
    void CalculateTwoNumbers()
    {
        float a = 20;
        float b = 7;
        float c = a + b;
        Debug.Log($"The sum of {a} and {b} is: {c}");
    }

    // a function that doesn't return a value but takes parameters
    void CalculateUnknownNumbers(float a, float b)
    {
        Debug.Log($"The sum of {a} and {b} is: {a + b}");
    }

    float returnTwoNumbers()
    {
        return 20 + 30;
    }

    float CalculateSum(float a, float b)
    {
        return (a + b);
    }

} // class
