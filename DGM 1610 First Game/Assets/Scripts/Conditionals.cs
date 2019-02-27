using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{

    public bool CanWalk;
    public int Number = 11;
    public string Password;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CanWalk)
        {
            print("True");
        }
        else
        {
            print(false);
        }

        if (Number >= 10)
        {
            print("Greater");
        }
        else
        {
            print("Lesser");
        }

        if (Password == "OU812")
        {
            print("The password is correct.");
        }
        else
        {
            print("The password is incorrect.");
        }
    }
}
