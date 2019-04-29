using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : Animal
{

	//public Color FinColor;

	// Use this for initialization
	void Start () {
		//print("Hello, World!");
		//IsWarmBlooded = false;
		//newColor = Color.blue;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,100,0);
		
	}

	/*public Color getFinColor()
	{
		return FinColor;
	}

	public void setFinColor(Color newFinColor)
	{
		FinColor = newFinColor;
	}*/
}
