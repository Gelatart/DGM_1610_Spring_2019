using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mammal : Animal
{
    public ColorData FurColor;
    
    // Use this for initialization
    void Start ()
    {
        IsWarmBlooded = true;
    }
	
    // Update is called once per frame
    void Update () {
		
    }

    /*public ColorData getFurColor()
    {
        return FurColor;
    }

    public void setFurColor(ColorData newFurColor)
    {
        FurColor = newFurColor;
    }*/
}
