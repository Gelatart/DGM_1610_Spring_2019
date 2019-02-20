using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Animal : MonoBehaviour
{

	public string Name;
	public ColorData SkinColor;
	public ColorData EyeColor;
	public string Habitat;
	public string Affiliation; // if friendly or hostile or neutral
	public string Message; // Flavor text that activates when approach
	public string Gender;
	public string WeightClass; // light, average, heavy
	public ColorData DeadColor; //color turns to in death
	//public IntData Health = 100; //No getters or setters yet
	public FloatData Speed; 
	public bool CanMove; 
	public float EatingSpeed; 
	public bool CanEat;
	public UnityEvent Event; //Doesn't need getters/setters?
	public bool IsWarmBlooded; 
	public string FoodType; //Carnivore/Herbivore/Omnivore/Etc.

	// Use this for initialization
	void Start () {
		Event.Invoke(); //still need to set details in Unity
		GetComponent<SpriteRenderer>().color = SkinColor.Value;
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

	public ColorData getSkinColor()
	{
		return SkinColor;
	}

	public void setSkinColor(ColorData newColor)
	{
		SkinColor = newColor;
	}

	public ColorData getEyeColor()
	{
		return EyeColor;
	}

	public void setEyeColor(ColorData newColor)
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

	public ColorData getDeadColor()
	{
		return DeadColor;
	}

	public void setDeadColor(ColorData newDeadColor)
	{
		DeadColor = newDeadColor;
	}

	public FloatData getSpeed()
	{
		return Speed;
	}

	public void setSpeed(FloatData newSpeed)
	{
		Speed = newSpeed;
	}

	public bool getCanMove()
	{
		return CanMove;
	}

	public void setCanMove(bool newCanMove)
	{
		CanMove = newCanMove;
	}

	public float getEatingSpeed()
	{
		return EatingSpeed;
	}

	public void setEatingSpeed(float newEatingSpeed)
	{
		EatingSpeed = newEatingSpeed;
	}

	public bool getCanEat()
	{
		return CanEat;
	}

	public void setCanEat(bool newCanEat)
	{
		CanEat = newCanEat;
	}

	public bool getIsWarmBlooded()
	{
		return IsWarmBlooded;
	}

	public void setIsWarmBlooded(bool newIsWarmBlooded)
	{
		IsWarmBlooded = newIsWarmBlooded;
	}

	public string getFoodType()
	{
		return FoodType;
	}

	public void setFoodType(string newFoodType)
	{
		FoodType = newFoodType;
	}
	public void getKilled()
	{
		SkinColor = DeadColor;
		EyeColor = DeadColor;
	}
}
