using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LightSwitch : MonoBehaviour
{
    //Figure out way to make bools or whatever that will cause light switch event to activate
    public bool LightActivate;
    public bool IsActivated = false;
    public UnityEvent ActivateLight, DeactivateLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsActivated == false && LightActivate == true)
        {
            ActivateLight.Invoke();
        }   
        else if (IsActivated == true && LightActivate == false)
        {
            DeactivateLight.Invoke();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //TriggerEnterEvent.Invoke();
        LightActivate = true;
        Debug.Log("Open sesame");
    }

    public void setLitTrue()
    {
        LightActivate = true;
    }
}
