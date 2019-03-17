using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Conditionals : MonoBehaviour
{
    public UnityEvent OnEvent, OffEvent;
    public bool OnBool;
    //public bool CanWalk;
    //public int Number = 11;
    public string Password;

    // Update is called once per frame
    private void Update()
    {
        if (OnBool)
        {
            OnEvent.Invoke();
        }
        else
        {
            OffEvent.Invoke();
        }

        /*if (Number >= 10)
        {
            //print("Greater");
        }
        else
        {
            //print("Lesser");
        }

        if (Password == "OU812")
        {
            //print("The password is correct.");
        }
        else
        {
            //print("The password is incorrect.");
        }*/
    }
}
