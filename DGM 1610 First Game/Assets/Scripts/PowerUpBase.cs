﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PowerUpBase : ScriptableObject
{
    
    public float Value = 10.5f;
    public float ValueCap;
    
    
    // Start is called before the first frame update
    void OnEnable()
    {
        Value = 20;
    }

    public void OnPowerUp(float addValue)
    {
        Value += addValue;
        if (Value > ValueCap)
        {
            Value = ValueCap;
        } 
        else if (Value <= 0)
        {
            //print("You are dead. INSERT FUNCTION THAT ENABLES DEATH");
        }
    }
}
