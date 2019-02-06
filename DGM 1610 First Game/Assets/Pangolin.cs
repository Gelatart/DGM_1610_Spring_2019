using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pangolin : Animal
{

	public Color ScaleColor;

	// Use this for initialization
	void Start () {
		Affiliation = "Neutral";
		Habitat = "Arid";
		Message = "Please, sir, just $5 goes a long way for us penitent pangolins.";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
