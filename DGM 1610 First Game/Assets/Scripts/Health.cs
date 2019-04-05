using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class Health : PowerUpBase //Make PowerUpBase later on when can?
{
    //ValueCap = 100; //Reintroduce later?
    public UnityEvent DeathEvent;
    // Start is called before the first frame update
    void OnEnable()
    {
        //Value = 25; //Reintroduce later?
    }

    // Update is called once per frame
    void Update()
    {
        if (Value <= 0)
        {
            //print("You are dead. INSERT FUNCTION THAT ENABLES DEATH");
            DeathEvent.Invoke();
            //Figure out way to remove object, death event call?
            //Transport this function elsewhere? Because this is a power-up class?
        }
    }
}
