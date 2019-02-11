using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{

	public string Name;
	public Color SkinColor;
	public Color EyeColor;
	public string Habitat;
	public string Affiliation; // if friendly or hostile or neutral
	public string Message; // Flavor text that activates when approach
	public string Gender;
	public string WeightClass; // light, average, heavy
	public Color DeadColor; //color turns to in death

	// Use this for initialization
	void Start () {
		
	}	
	// Update is called once per frame
	void Update () {
		
	}
	public string getName()
	{
		return Name;
	}
	public void setName(string newName)
	{
		Name = newName;
	}

	public Color getSkinColor()
	{
		return SkinColor;
	}

	public void setSkinColor(Color newColor)
	{
		SkinColor = newColor;
	}

	public Color getEyeColor()
	{
		return EyeColor;
	}

	public void setEyeColor(Color newColor)
	{
		EyeColor = newColor;
	}

	public string getHabitat()
	{
		return Habitat;
	}

	public void setHabitat(string newHabitat)
	{
		Habitat = newHabitat;
	}

	public string getAffiliation()
	{
		return Affiliation;
	}

	public void setAffiliation(string newAffiliation)
	{
		Affiliation = newAffiliation;
	}

	public string getMessage()
	{
		return Message;
	}

	public void setMessage(string newMessage)
	{
		Message = newMessage;
	}

	public string getGender()
	{
		return Gender;
	}

	public void setGender(string newGender)
	{
		Gender = newGender;
	}

	public string getWeightClass()
	{
		return WeightClass;
	}

	public void setWeightClass(string newWeightClass)
	{
		WeightClass = newWeightClass;
	}

	public Color getDeadColor()
	{
		return DeadColor;
	}

	public void setDeadColor(Color newDeadColor)
	{
		DeadColor = newDeadColor;
	}

	public void getKilled()
	{
		SkinColor = DeadColor;
		EyeColor = DeadColor;
	}
}
