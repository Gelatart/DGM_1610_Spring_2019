using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : Animal
{

	public Color FinColor;

	// Use this for initialization
	void Start () {
		print("Hello, World!");
		Affiliation = "Neutral";
		Habitat = "Aquatic";
		Message = "Move along, buddy, I don't date anyone shorter than me.";
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,100,0);
		
	}
}
