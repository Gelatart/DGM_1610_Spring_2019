using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    [SerializeField] private float value; // visible in editor?
    public float Value { //visible in events system
    	get { return value; }
    	set { this.value += value; }
    }
    
    public void UpdateValue(float floatInput) {
	    Value += floatInput;	
    }

    public void UpdateValue(FloatData dataObj)
    {
	    Value += dataObj.Value;
    }

}
