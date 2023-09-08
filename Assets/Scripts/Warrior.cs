using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Player
{

    public Warrior(int health, int power, string name)
    {
        Health = health;
        Power = power;
        Name = name;
    }

    public override void Attack()
    {
        Debug.Log("Player is atacking with an axe.");
    }

} // class
