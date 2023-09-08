using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{

    private int _health;

    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
        }
    }

    private int power;
    private string name;

    public Player(int health, int power, string name)
    {
        Health = health;
        this.power = power;
        this.name = name;
    }

    public void Attack()
    {
        Debug.Log($"{name} is atacking.");
    }

    public void Info()
    {
        Debug.Log($"Health is: {_health}");
        Debug.Log($"power is: {power}");
        Debug.Log($"name is: {name}");
    }

    //public void SetHealth( int health)
    //{
    //    this.health = health;
    //}

    //public int GetHealth()
    //{
    //    return this.health;
    //}


} // class
