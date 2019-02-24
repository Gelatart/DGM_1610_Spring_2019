using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Health : PowerUpBase
{
    
    ValueCap = 100;
    // Start is called before the first frame update
    void OnEnable()
    {
        Value = 25;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
