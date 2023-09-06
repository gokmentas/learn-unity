using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour
{
    private void Start()
    {

        float a = 20;
        float b = 7;
        float c = a * b;

        string name = "carl";
        string lastName = " florian";

        string fullName = name + lastName;

        //Debug.Log(a + " / " + b + " = " + c);
        Debug.Log(fullName);

    }

} // class
