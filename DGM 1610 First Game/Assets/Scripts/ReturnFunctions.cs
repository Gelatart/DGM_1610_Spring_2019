using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnFunctions : MonoBehaviour
{
    public int A;
    public int B;
    public int C;

    public Vector3 position;
    public CharacterController Controller;
   
    
    private int Add()
    {
        return A + B;
    }

    private int Subtract()
    {
        return A - B;
    }

    private int Multiply()
    {
        return A * B;
    }

    private int Divide()
    {
        return A / B;
    }

    private int Modulo()
    {
        return A % B;
    }

    private int AddSeries() //Trying to make a function that goes through adding numbers between two endpoints
    {
         int D = 0;
         int E = B;
        while (E > A)
        {
            D += B;
            E--;
        }

        D += A;
        return D;
    }

    public Vector3 Move()
    {
        position.y = Input.GetAxis("Horizontal");
        Controller.Move(position);
        return position;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        C = Add();
        C = Subtract();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
