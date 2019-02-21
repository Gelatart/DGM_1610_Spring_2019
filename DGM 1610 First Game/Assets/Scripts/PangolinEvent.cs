using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PangolinEvent : MonoBehaviour
{

	public UnityEvent Event;

	// Use this for initialization
	void OnCollisionEnter2D ()
	{
		Event.Invoke();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
