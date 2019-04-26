using System.Collections;
using System.Collections.Generic;
//using System.Drawing;
using UnityEngine;
using UnityEngine.Events;

public class Animal : MonoBehaviour
{

	public string Name;
	//public FloatData Health;
	public float Health = 1.0f;
	public ColorData SkinColor;
	public FloatData Speed; 
	public bool CanMove; 
	protected Color newColor;
	
	public ColorData EyeColor;
	public string Habitat;
	public string Affiliation; // if friendly or hostile or neutral
	public string Message; // Flavor text that activates when approach
	public string Gender;
	public string WeightClass; // light, average, heavy
	public ColorData DeadColor; //color turns to in death
	public float EatingSpeed; 
	public bool CanEat;
	public UnityEvent Event, DeathEvent; //Doesn't need getters/setters?
	public bool IsWarmBlooded; 
	public string FoodType; //Carnivore/Herbivore/Omnivore/Etc.
	
	
	private SpriteRenderer spriteRender;

	// Use this for initialization
	void Start () {
	    //Health = FloatData.CreateInstance(1.0f);
	    //Health = GameObject.Find("Health").GetComponent<FloatData>();
	    SkinColor = ColorData.CreateInstance(Color.black);
	    //Source for learning about CreateInstance: https://answers.unity.com/questions/310847/how-to-create-instance-of-scriptableobject-and-pas.html
		Event.Invoke(); //still need to set details in Unity
		spriteRender = gameObject.GetComponent<SpriteRenderer>();
		//spriteRender.color = SkinColor.Value; //Try to fix this? Need to change color
		//Reference: https://docs.unity3d.com/ScriptReference/SpriteRenderer-sprite.html (also for creating spriteRender)
		//Health.Value = 10;
	}	
	// Update is called once per frame
	void Update () {
		if (Health <= 0.0f)
		{
			getKilled();
		}
	}

	public void decreaseHealth()
	{
		Health = Health - 0.1f;
		Debug.Log("oof" + Health);
	}
	
	public void increaseHealth() 
	{
		Health = Health + 0.1f;
		Debug.Log("Awesome");
	}
	
	public void getKilled()
	{
		SkinColor = DeadColor;
		EyeColor = DeadColor;
		spriteRender.color = DeadColor.Value;
		//Debug.Log("I die");
		DeathEvent.Invoke();
	}
}
