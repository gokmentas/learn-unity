using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour
{
    Player warrior;
    Player archer;


    private void Start()
    {
       
        warrior = new Player(1, 2, "Lizard"); 

        warrior.Health = 50;

        Debug.Log($"Health is {warrior.Health}");


    }

       

} // class
