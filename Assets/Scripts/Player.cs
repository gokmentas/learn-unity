using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{

    int health;
    int power;
    string name;

    public Player(int health, int power, string name)
    {
        this.health = health;
        this.power = power;
        this.name = name;
    }

    public void Attack()
    {
        Debug.Log($"{name} is atacking.");
    }

    public void Info()
    {
        Debug.Log($"Health is: {health}");
        Debug.Log($"power is: {power}");
        Debug.Log($"name is: {name}");
    }

} // class
