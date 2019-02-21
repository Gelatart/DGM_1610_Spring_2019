using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : Animal
{

    public Color WingColor;

    // Use this for initialization
    void Start () {
        IsWarmBlooded = false;
    }
	
    // Update is called once per frame
    void Update () {
		
    }

    public Color getWingColor()
    {
	    return WingColor;
    }

    public void setWingColor(Color newWingColor)
    {
	    WingColor = newWingColor;
    }
}
