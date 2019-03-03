using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LightSwitch : MonoBehaviour
{
    //Figure out way to make bools or whatever that will cause light switch event to activate
    public bool LightActivated;
    public bool IsActivated = false;
    public UnityEvent ActivateLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsActivated = false && LightActivated = true)
        {
            ActivateLight.Invoke();
        }   
    }
}
