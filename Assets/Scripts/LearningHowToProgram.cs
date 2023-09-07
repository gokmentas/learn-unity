using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(ExecuteSomething(2));

        StartCoroutine("ExecuteSomething");
        StopCoroutine("ExecuteSomething");
    }

    IEnumerator ExecuteSomething(float time)
    {
        yield return new WaitForSeconds(time);

        Debug.Log("Something is executed");
    }

} // class
