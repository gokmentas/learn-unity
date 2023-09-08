using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour
{
    private void Start()
    {
       
        Player warrior = new Player(1, 2, "Lizard");
        Player archer = new Player(20, 30, "Archer");

        warrior.Info();
        archer.Info();
        archer.Attack();

    }

       

} // class
