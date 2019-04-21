using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ColorData : ScriptableObject
{
    public Color Value;
    
    public void Init(Color Value)
    {
        this.Value = Value;
    }
    public static ColorData CreateInstance(Color Value)
    {
        var data = ScriptableObject.CreateInstance<ColorData>();
        data.Init(Value);
        return data;
    }
    //Source for Init and CreateInstance idea: https://answers.unity.com/questions/310847/how-to-create-instance-of-scriptableobject-and-pas.html
}
