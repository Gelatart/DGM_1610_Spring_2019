﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : PowerUpBase
{
    
    ValueCap = 50;
    // Start is called before the first frame update
    void OnEnable()
    {
        Value = 15;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
