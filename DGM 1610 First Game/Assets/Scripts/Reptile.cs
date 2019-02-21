using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reptile : Animal
{

    public ColorData ScaleColor;
    
    // Start is called before the first frame update
    void Start()
    {
        IsWarmBlooded = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public ColorData getScaleColor()
    {
        return ScaleColor;
    }

    public void setScaleColor(ColorData newScaleColor)
    {
        ScaleColor = newScaleColor;
    }
}
