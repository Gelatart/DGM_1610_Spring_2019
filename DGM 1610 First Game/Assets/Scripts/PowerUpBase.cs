using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PowerUpBase : ScriptableObject
{
    
    public float Value = 10.5f;
    
    // Start is called before the first frame update
    void OnEnable()
    {
        Value = 20;
    }
}
