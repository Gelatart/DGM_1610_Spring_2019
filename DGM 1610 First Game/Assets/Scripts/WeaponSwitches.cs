using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class WeaponSwitches : MonoBehaviour
{
    
    public UnityEvent BlasterEvent, BombEvent, AssaultRifleEvent, NukeEvent;
    
    public enum States
    {
        Blaster,
        Bomb,
        AssaultRifle,
        Nuke
    }
    
    public States CurrentState;

    void Update()
    {
        switch (CurrentState)
        {
            case States.Blaster:
                BlasterEvent.Invoke();
                break;
            case States.Bomb:
                BombEvent.Invoke();
                break;
            case States.AssaultRifle:
                AssaultRifleEvent.Invoke();
                break;
            case States.Nuke:
                NukeEvent.Invoke();
                break;
            default:
                throw new ArgumentOutOfRangeException();

        }
    }
}