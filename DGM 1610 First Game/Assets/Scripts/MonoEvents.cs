﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{
    
    public UnityEvent StartEvent, EnableEvent, DisableEvent, MouseDownEvent, MouseUpEvent, UpdateEvent;
    
    // Start is called before the first frame update
    void Start()
    {
        StartEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateEvent.Invoke();
    }

    private void OnEnable()
    {
        EnableEvent.Invoke();
    }
    
    private void OnDisable()
    {
        DisableEvent.Invoke();
    }

    private void OnMouseDown()
    {
        MouseDownEvent.Invoke();
    }
    
    private void OnMouseUp()
    {
        MouseUpEvent.Invoke();
    }
}
