using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{

    public Color BeakColor;

    // Use this for initialization
    void Start ()
    {
        IsWarmBlooded = true;
    }
	
    // Update is called once per frame
    void Update () {
		
    }

    public Color getBeakColor()
    {
        return BeakColor;
    }

    public void setBeakColor(Color newBeakColor)
    {
        BeakColor = newBeakColor;
    }
}
