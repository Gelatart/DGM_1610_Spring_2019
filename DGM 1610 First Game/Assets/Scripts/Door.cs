﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Door : MonoBehaviour
{
    //public bool IsOpen;
    public bool IsOpen;
    //public bool WillOpen;
    public bool WillOpen;
    //make it so if it is open and activate, it closes and vice versa, using if statements
    public UnityEvent OpenDoor, CloseDoor, TriggerEnterEvent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsOpen == false && WillOpen == true)
        {
            OpenDoor.Invoke();
        }
        else if (IsOpen == true && WillOpen == false)
        {
            CloseDoor.Invoke();
        } 
    }
    
    private void OnTriggerEnter(Collider other)
    {
        //TriggerEnterEvent.Invoke();
        WillOpen = true;
        Debug.Log("Open sesame");
    }

    public void setOpenTrue()
    {
        WillOpen = true;
    }
}
