using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moth : Animal
{

	public Color WingColor;

	// Use this for initialization
	void Start () {
		Affiliation = "Neutral";
		Habitat = "Verdant";
		Message = "Mmmmppppphhhhh! *She doesn't appear to have a mouth...*";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
