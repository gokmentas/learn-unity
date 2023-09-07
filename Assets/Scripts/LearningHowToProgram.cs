using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour
{
    private void Start()
    {
        float health = 101;

        switch (health)
        {
            case 100:
                Debug.Log("Health is 100");
                break;

            case 50:
                Debug.Log("Health is 50");
                break;

            case 0:
                Debug.Log("Health is 0");
                break;

            default:
                Debug.Log("Healt is neighter of the value above");
                break;
        }

        //if (health == 0)
        //{
        //    // if health is less than zero, then condition is true
        //    // code that is here, will be executed
        //    Debug.Log("Health is 0 player has died");
        //}else if (health < 50)
        //{
        //    Debug.Log("Health is less than 50 unlock some power for player");
        //}
        //else
        //{
        //    Debug.Log("Player has health greater than 50");
        //}
    }
} // class
